// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using Newtonsoft.Json;

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
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an absolute URL, potentially an URL directing away from Vimeo.
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("short_bio")]
        public string ShortBio { get; set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        // Skipping "pictures" property because complex object that with time will point to dead assets anyway.

        [JsonProperty("websites")]
        public Website[] Websites { get; set; }

        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        [JsonProperty("location_details")]
        public LocationDetails LocationDetails { get; set; }
    }
}
