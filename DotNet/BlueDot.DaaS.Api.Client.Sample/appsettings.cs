namespace BlueDot.DaaS.Api.Client.Sample
{
    public class HttpSettings
    {
        public string BaseUrl { get; set; }
        public int TimeoutSeconds { get; set; }
        public int MaxRetryCount { get; set; }
        public int RetryDelaySeconds { get; set; }
        public int JitterMilliseconds { get; set; }
        public int HandlerLifetimeMinutes { get; set; }
    }
    public class appsettings
    {

        public class DaasApiSettings : HttpSettings
        {
            public string TokenAuthority { get; set; }
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string Scope { get; set; }
            public string SubscriptionKey { get; set; }
        }
    }
}
