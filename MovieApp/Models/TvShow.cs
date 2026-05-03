using Newtonsoft.Json;

namespace MovieApp.Models
{
    public class TvShowResponse
    {
        [JsonProperty("results")]
        public List<TvShow>? Results { get; set; }
    }

    public class TvShow
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("overview")]
        public string? Overview { get; set; }

        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public string? FirstAirDate { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("original_language")]
        public string? Language { get; set; }

        public string PosterUrl =>
            string.IsNullOrEmpty(PosterPath)
                ? "/images/no-poster.png"
                : $"https://image.tmdb.org/t/p/w500{PosterPath}";

        public string AirYear =>
            string.IsNullOrEmpty(FirstAirDate) || FirstAirDate.Length < 4
                ? "N/A"
                : FirstAirDate[..4];
    }
}
