using Newtonsoft.Json;

namespace MovieApp.Models
{
    public class MovieResponse
    {
        [JsonProperty("results")]
        public List<Movie>? Results { get; set; }
    }

    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("overview")]
        public string? Overview { get; set; }

        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }

        [JsonProperty("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("original_language")]
        public string? Language { get; set; }

        public string PosterUrl =>
            string.IsNullOrEmpty(PosterPath)
                ? "/images/no-poster.png"
                : $"https://image.tmdb.org/t/p/w500{PosterPath}";

        public string ReleaseYear =>
            string.IsNullOrEmpty(ReleaseDate) || ReleaseDate.Length < 4
                ? "N/A"
                : ReleaseDate[..4];
    }
}
