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

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an absolute URL, potentially an URL directing away from Vimeo.
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the bio.
        /// </summary>
        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or sets the short bio.
        /// </summary>
        [JsonPropertyName("short_bio")]
        public string ShortBio { get; set; }

        /// <summary>
        /// Gets or sets the created time.
        /// </summary>
        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        // Skipping "pictures" property for now.

        /// <summary>
        /// Gets or sets the websites.
        /// </summary>
        [JsonPropertyName("websites")]
        public Website[] Websites { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        [JsonPropertyName("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        [JsonPropertyName("location_details")]
        public LocationDetails LocationDetails { get; set; }
    }
}
