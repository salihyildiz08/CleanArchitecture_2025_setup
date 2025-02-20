﻿using System.Text.Json.Serialization;

namespace CleanArchictecture_2025.Domain.Dtos;
public sealed class GetAccessTokenResponseDto
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = default!;
}
