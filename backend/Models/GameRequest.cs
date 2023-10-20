using backend.Models;
using System.Text.Json.Serialization;

public class GameRequest
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Move PlayerMove { get; set; }
}
