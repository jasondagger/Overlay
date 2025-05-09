
using System;
using System.Text.Json.Serialization;
    
namespace Overlay.Core.Services.Spotifies.Responses;

[Serializable]
public sealed class SpotifyResponseImage
{
    [JsonPropertyName(name: "height")]
    public int Height { get; set; } = 0;

    [JsonPropertyName(name: "url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName(name: "width")]
    public int Width { get; set; } = 0;
}