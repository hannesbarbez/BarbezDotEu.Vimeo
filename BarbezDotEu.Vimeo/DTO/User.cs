// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Text.Json.Serialization;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a user according to the contract defined by Vimeo.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets a relative Vimeo URL for the user.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an absolute URL, potentially an URL directing away from Vimeo.
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("short_bio")]
        public string ShortBio { get; set; }

        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        // Skipping "pictures" property because complex object that with time will point to dead assets anyway.

        [JsonPropertyName("websites")]
        public Website[] Websites { get; set; }

        [JsonPropertyName("metadata")]
        public MetaData MetaData { get; set; }

        [JsonPropertyName("location_details")]
        public LocationDetails LocationDetails { get; set; }
    }
}
