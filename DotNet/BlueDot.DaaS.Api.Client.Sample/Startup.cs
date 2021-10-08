using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using static BlueDot.DaaS.Api.Client.Sample.appsettings;
using BlueDot.DaaS.Api.Client.Sample.Services;
using System.Net.Http.Headers;
using System.Net.Http;
using IdentityModel.Client;
using BlueDot.DaaS.Api.Client.Sample.Filters;

namespace BlueDot.DaaS.Api.Client.Sample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var httpSettings = Configuration.GetSection("DaasApi").Get<DaasApiSettings>();

            services.AddControllers(options =>
            {
                options.Filters.Add<OperationCancelledExceptionFilter>();
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.WriteIndented = true;

            });

            services.AddHttpClient<IBluedotDaasService, BluedotDaasService>(client =>
            {//Adds http client to handle the communications with DaaS
                var bearerToken = GetBearerTokenFromAuthService(httpSettings);

                client.BaseAddress = new Uri(httpSettings.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.Timeout = TimeSpan.FromSeconds(httpSettings.TimeoutSeconds);
                client.DefaultRequestHeaders.Add(HeaderNames.Authorization, bearerToken); 
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", httpSettings.SubscriptionKey);
            });
           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /// <summary>
        /// Request a token from the Auth Service to be used as auth header for outgoing DaaS api requests.
        /// </summary>
        /// <param name="settings">Auth service settings</param>
        /// <returns></returns>
        public static string GetBearerTokenFromAuthService(DaasApiSettings settings)
        {
            // TODO: cache this token for a time equals 95% of it's expiry for better performance
            var client = new HttpClient();

            // Get auth-server discovery doc
            var discoveryDocumentResponse = client.GetDiscoveryDocumentAsync(settings.TokenAuthority).Result;
            if (discoveryDocumentResponse.IsError)
            {
                throw new Exception(
                    $"Failed to connect to auth-server discovery api, url: {settings.TokenAuthority} Error: {discoveryDocumentResponse.Error}");
            }

            // Get the access token
            var tokenResponse = client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = discoveryDocumentResponse.TokenEndpoint,
                ClientId = settings.ClientId,
                ClientSecret = settings.ClientSecret,
                Scope = settings.Scope
            }).Result;

            if (tokenResponse.IsError)
            {
                throw new Exception(
                    
                    $"Failed to get token from auth-server, url: {settings.TokenAuthority} Error: {tokenResponse.Error}");
            }

            return $"Bearer {tokenResponse.AccessToken}";
        }
    }
}
