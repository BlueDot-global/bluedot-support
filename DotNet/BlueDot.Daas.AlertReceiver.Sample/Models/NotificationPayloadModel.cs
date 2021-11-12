using Newtonsoft.Json;
using System;

namespace BlueDot.Daas.AlertReceiver.Sample.Models
{
    /// <summary>
    ///   Notification payload model.
    /// </summary>
    public class NotificationPayloadModel
    {
        /// <summary>Gets or sets the alert identifier.</summary>
        /// <value>The alert identifier.</value>
        [JsonProperty("alertId")] public int? AlertId { get; set; }

        /// <summary>The title.</summary>
        /// <value>The title.</value>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>The details.</summary>
        /// <value>The details.</value>
        [JsonProperty("details")] public string Details { get; set; }

        /// <summary>The reported date.</summary>
        /// <value>The reported date.</value>
        [JsonProperty("reportedDate")] public DateTimeOffset? ReportedDate { get; set; }

        /// <summary>The disease identifier.</summary>
        /// <value>The disease identifier.</value>
        [JsonProperty("diseaseId")] public int? DiseaseId { get; set; }

        /// <summary>The type of the notification.</summary>
        /// <value>The type of the notification.</value>
        [JsonProperty("notificationType")] public string NotificationType { get; set; }
        /// <summary>The location identifier.</summary>
        /// <value>The location identifier.</value>
        [JsonProperty("locationId")] public int? LocationId { get; set; }
        /// <summary>The location type identifier.</summary>
        /// <value>The location type identifier.</value>
        [JsonProperty("locationTypeId")] public int? LocationTypeId { get; set; }
        /// <summary>The location ISO code.</summary>
        /// <value>The location ISO code.</value>
        [JsonProperty("locationIsoCode")] public string LocationIsoCode { get; set; }
        /// <summary>The location name.</summary>
        /// <value>The location name.</value>
        [JsonProperty("locationName")] public string LocationName { get; set; }
        /// <summary>The country identifier.</summary>
        /// <value>The country identifier.</value>
        [JsonProperty("countryId")] public int? CountryId { get; set; }
        /// <summary>The country ISO code.</summary>
        /// <value>The country ISO code.</value>
        [JsonProperty("countryIsoCode")] public string CountryIsoCode { get; set; }
        /// <summary>The location name.</summary>
        /// <value>The location name.</value>
        [JsonProperty("countryName")] public string CountryName { get; set; }
        /// <summary>The longitude.</summary>
        /// <value>The longitude.</value>
        [JsonProperty("longitude")] public double? Longitude { get; set; }

        /// <summary>The latitude.</summary>
        /// <value>The latitude.</value>
        [JsonProperty("latitude")] public double? Latitude { get; set; }

        /// <summary>The source URL.</summary>
        /// <value>The source URL.</value>
        [JsonProperty("sourceUrl")] public string SourceUrl { get; set; }
    }
}
