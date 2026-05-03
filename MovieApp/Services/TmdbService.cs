using Newtonsoft.Json;
using MovieApp.Models;

namespace MovieApp.Services
{
    public class TmdbService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private const string BaseUrl = "https://api.themoviedb.org/3/";

        public TmdbService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _apiKey = config["Tmdb:ApiKey"]!;
        }

        public async Task<List<Movie>> GetPopularMoviesAsync()
        {
            var url = $"{BaseUrl}movie/popular?api_key={_apiKey}&language=es-ES&page=1";
            var response = await _httpClient.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<MovieResponse>(response);
            return result?.Results ?? new List<Movie>();
        }

        public async Task<List<TvShow>> GetPopularSeriesAsync()
        {
            var url = $"{BaseUrl}tv/popular?api_key={_apiKey}&language=es-ES&page=1";
            var response = await _httpClient.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<TvShowResponse>(response);
            return result?.Results ?? new List<TvShow>();
        }
    }
}
