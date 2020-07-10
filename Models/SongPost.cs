using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JpJamsBot.Models
{
    public class SongPost
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public string Artist { get; set; }

        public string Song { get; set; }

        public string Link { get; set; }
        
        public DateTime? TwitterDate { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}