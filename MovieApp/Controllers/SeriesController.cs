using Microsoft.AspNetCore.Mvc;
using MovieApp.Services;

namespace MovieApp.Controllers
{
    public class SeriesController : Controller
    {
        private readonly TmdbService _tmdbService;

        public SeriesController(TmdbService tmdbService)
        {
            _tmdbService = tmdbService;
        }

        public async Task<IActionResult> Index()
        {
            var series = await _tmdbService.GetPopularSeriesAsync();
            return View(series);
        }
    }
}
