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
        [JsonPropertyName("albums")]
        public HttpQueryDefinition Albums { get; set; }

        [JsonPropertyName("appearances")]
        public HttpQueryDefinition Appearances { get; set; }

        [JsonPropertyName("channels")]
        public HttpQueryDefinition Channels { get; set; }

        [JsonPropertyName("feed")]
        public HttpQueryDefinition Feed { get; set; }

        [JsonPropertyName("followers")]
        public HttpQueryDefinition Followers { get; set; }

        [JsonPropertyName("following")]
        public HttpQueryDefinition Following { get; set; }

        [JsonPropertyName("groups")]
        public HttpQueryDefinition Groups { get; set; }

        [JsonPropertyName("likes")]
        public HttpQueryDefinition Likes { get; set; }

        [JsonPropertyName("membership")]
        public HttpQueryDefinition Membership { get; set; }

        [JsonPropertyName("moderated_channels")]
        public HttpQueryDefinition ModeratedChannels { get; set; }

        [JsonPropertyName("portfolios")]
        public HttpQueryDefinition Portfolios { get; set; }

        [JsonPropertyName("videos")]
        public HttpQueryDefinition Videos { get; set; }

        [JsonPropertyName("shared")]
        public HttpQueryDefinition Shared { get; set; }

        [JsonPropertyName("pictures")]
        public HttpQueryDefinition Pictures { get; set; }

        [JsonPropertyName("folders_root")]
        public HttpQueryDefinition FoldersRoot { get; set; }

        [JsonPropertyName("teams")]
        public HttpQueryDefinition Teams { get; set; }

    }
}
