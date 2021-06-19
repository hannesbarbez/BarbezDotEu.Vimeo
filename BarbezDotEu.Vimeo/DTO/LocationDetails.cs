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
        /// <summary>
        /// Gets or sets the formatted address.
        /// </summary>
        [JsonPropertyName("formatted_address")]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the neighborhood.
        /// </summary>
        [JsonPropertyName("neighborhood")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets the sub locality.
        /// </summary>
        [JsonPropertyName("sub_locality")]
        public string SubLocality { get; set; }

        /// <summary>
        /// Gets or sets the state ISO code.
        /// </summary>
        [JsonPropertyName("state_iso_code")]
        public string StateIsoCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country ISO code.
        /// </summary>
        [JsonPropertyName("country_iso_code")]
        public string CountryIsoCode { get; set; }
    }
}
