using backend.Models;
using System.Text.Json.Serialization;

public class GameResult
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Move PlayerMove { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Move ComputerMove { get; set; }

    public required string Result { get; set; }
}
