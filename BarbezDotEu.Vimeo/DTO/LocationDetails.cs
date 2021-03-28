// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using Newtonsoft.Json;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a location details object according to the interface defined by Vimeo.
    /// </summary>
    public class LocationDetails
    {
        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("sub_locality")]
        public string SubLocality { get; set; }

        [JsonProperty("state_iso_code")]
        public string StateIsoCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_iso_code")]
        public string CountryIsoCode { get; set; }
    }
}
