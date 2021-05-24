// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a location details object according to the interface defined by Vimeo.
    /// </summary>
    public class LocationDetails
    {
        [JsonPropertyName("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonPropertyName("sub_locality")]
        public string SubLocality { get; set; }

        [JsonPropertyName("state_iso_code")]
        public string StateIsoCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_iso_code")]
        public string CountryIsoCode { get; set; }
    }
}
