using System.Text.Json.Serialization;

namespace RapidApiConsume.Models
{
    public class ApiMovieViewModel
    {
        [JsonPropertyName("rank")]
        public int rank { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        //[JsonPropertyName("description")]
        //public string description { get; set; }

        //[JsonPropertyName("image")]
        //public string image { get; set; }

        [JsonPropertyName("genre")]
        public List<string> genre { get; set; }

        //[JsonPropertyName("thumbnail")]
        //public string thumbnail { get; set; }

        [JsonPropertyName("rating")]
        public string rating { get; set; }

        //[JsonPropertyName("id")]
        //public string id { get; set; }

        //[JsonPropertyName("year")]
        //public int year { get; set; }

    }
}
