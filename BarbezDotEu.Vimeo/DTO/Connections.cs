// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Text.Json.Serialization;

namespace BarbezDotEu.Vimeo.DTO
{
    /// <summary>
    /// Implements connections according to the contract defined by Vimeo.
    /// </summary>
    public class Connections
    {
        /// <summary>
        /// Gets or sets the albums.
        /// </summary>
        [JsonPropertyName("albums")]
        public HttpQueryDefinition Albums { get; set; }

        /// <summary>
        /// Gets or sets the appearances.
        /// </summary>
        [JsonPropertyName("appearances")]
        public HttpQueryDefinition Appearances { get; set; }

        /// <summary>
        /// Gets or sets the channels.
        /// </summary>
        [JsonPropertyName("channels")]
        public HttpQueryDefinition Channels { get; set; }

        /// <summary>
        /// Gets or sets the feed.
        /// </summary>
        [JsonPropertyName("feed")]
        public HttpQueryDefinition Feed { get; set; }

        /// <summary>
        /// Gets or sets the followers.
        /// </summary>
        [JsonPropertyName("followers")]
        public HttpQueryDefinition Followers { get; set; }

        /// <summary>
        /// Gets or sets the following.
        /// </summary>
        [JsonPropertyName("following")]
        public HttpQueryDefinition Following { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        [JsonPropertyName("groups")]
        public HttpQueryDefinition Groups { get; set; }

        /// <summary>
        /// Gets or sets the likes.
        /// </summary>
        [JsonPropertyName("likes")]
        public HttpQueryDefinition Likes { get; set; }

        /// <summary>
        /// Gets or sets the membership.
        /// </summary>
        [JsonPropertyName("membership")]
        public HttpQueryDefinition Membership { get; set; }

        /// <summary>
        /// Gets or sets the moderated channels.
        /// </summary>
        [JsonPropertyName("moderated_channels")]
        public HttpQueryDefinition ModeratedChannels { get; set; }

        /// <summary>
        /// Gets or sets the portfolios.
        /// </summary>
        [JsonPropertyName("portfolios")]
        public HttpQueryDefinition Portfolios { get; set; }

        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        [JsonPropertyName("videos")]
        public HttpQueryDefinition Videos { get; set; }

        /// <summary>
        /// Gets or sets the shared <see cref="HttpQueryDefinition"/>.
        /// </summary>
        [JsonPropertyName("shared")]
        public HttpQueryDefinition Shared { get; set; }

        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        [JsonPropertyName("pictures")]
        public HttpQueryDefinition Pictures { get; set; }

        /// <summary>
        /// Gets or sets the folders root.
        /// </summary>
        [JsonPropertyName("folders_root")]
        public HttpQueryDefinition FoldersRoot { get; set; }

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        [JsonPropertyName("teams")]
        public HttpQueryDefinition Teams { get; set; }

    }
}
