
using System;
using System.Text.Json.Serialization;
    
namespace Overlay.Core.Services.Spotifies.Responses;

[Serializable]
public sealed class SpotifyResponseResumePoint
{
    [JsonPropertyName(name: "fully_played")]
    public bool FullyPlayed { get; set; } = false;

    [JsonPropertyName(name: "resume_position_ms")]
    public string ResumePositionMS { get; set; } = string.Empty;
}