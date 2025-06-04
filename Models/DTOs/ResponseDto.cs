﻿using System.Text.Json.Serialization;

namespace TaskManagementAPI.Models.DTOs
{
    public class ResponseDto
    {
        /// <summary>
        /// Gets or sets a message associated with the response.
        /// </summary>
        /// <remarks>
        /// Documentation: Represents additional information or a message related to the response.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; } = null;

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// </summary>
        /// <remarks>
        /// Documentation: Represents the HTTP status code of the response.
        /// </remarks>
        public int StatusCode { get; set; } = 0;

        /// <summary>
        /// Gets or sets the payload data of the response.
        /// </summary>
        /// <remarks>
        /// Documentation: Represents the data payload of the response.
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Payload { get; set; } = null;
    }
}
