
using System;
using System.Text.Json.Serialization;
    
namespace Overlay.Core.Services.Spotifies.Responses;

[Serializable]
public sealed class SpotifyResponseExternalIds
{
    [JsonPropertyName(name: "isrc")]
    public string ISRC { get; set; } = string.Empty;

    [JsonPropertyName(name: "ean")]
    public string EAN { get; set; } = string.Empty;

    [JsonPropertyName(name: "upc")]
    public string UPC { get; set; } = string.Empty;
}