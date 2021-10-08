using BlueDot.DaaS.Api.Client.Sample.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlueDot.DaaS.Api.Client.Sample.Services
{
    public class BluedotDaasService : IBluedotDaasService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<BluedotDaasService> _logger;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Creates an instance of <see cref="BluedotDaasService"/>
        /// </summary>
        /// <param name="httpClient">the httpClient</param>
        /// <param name="logger">the logger</param>
        /// <param name="configuration">the configuration</param>
        public BluedotDaasService(HttpClient httpClient, 
            ILogger<BluedotDaasService> logger,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _configuration = configuration;
        }

        /// <summary>
        /// Get the list of supported disease from BlueDot DaaS api
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Disease>> GetDiseases(CancellationToken cancellationToken)
        {
            _logger.LogTrace("{method} hit..", nameof(GetDiseases));

            var url = new Uri(_httpClient.BaseAddress, _configuration["DiseaseLookupUrl"]);

            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                var stream = await response.Content.ReadAsStreamAsync();

                response.EnsureSuccessStatusCode();

                return DeserializeJsonFromStream<List<Disease>>(stream);
            }
        }

        private static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }
        }
    }
}
