// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;
using BarbezDotEu.VideoHost.DTO;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements a website according to the contract as defined by Vimeo.
    /// </summary>
    public class Website
    {
        /// <summary>
        /// Gets or sets the URL
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns this object as a <see cref="WebsiteData"/> DTO.
        /// </summary>
        /// <returns>This object as a <see cref="WebsiteData"/> DTO.</returns>
        public WebsiteData AsWebsiteData()
        {
            return new WebsiteData(this.Uri, this.Name, this.Link, this.Type, this.Description);
        }
    }
}
