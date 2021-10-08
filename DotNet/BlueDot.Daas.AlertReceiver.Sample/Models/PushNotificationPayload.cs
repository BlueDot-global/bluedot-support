using Newtonsoft.Json;
using System;

namespace BlueDot.Daas.AlertReceiver.Sample.Models
{
    public class PushNotificationPayload
    {
        [JsonProperty("alertId")] public int? AlertId { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("details")] public string Details { get; set; }

        [JsonProperty("reportedDate")] public DateTimeOffset? ReportedDate { get; set; }

        [JsonProperty("diseaseId")] public int? DiseaseId { get; set; }

        [JsonProperty("notificationType")] public string NotificationType { get; set; }
        [JsonProperty("locationId")] public int? LocationId { get; set; }
        [JsonProperty("isoCode")] public string IsoCode { get; set; }
        [JsonProperty("countryCode")] public string CountryCode { get; set; }
        [JsonProperty("longitude")] public double? Longitude { get; set; }

        [JsonProperty("latitude")] public double? Latitude { get; set; }

        [JsonProperty("sourceUrl")] public string SourceUrl { get; set; }
    }
}
