using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_RepositoryPattern_demo02.Contracts;
using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TunesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public TunesController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetTunes()
        {
            var tunes = _repository.Tune.GetAllTunes(trackChanges: false);
            return Ok(tunes);
        }

        [HttpPost]
        public IActionResult CreateTunes()
        {
            var tune = new Tune
            {
                Name = "Whole Lotta Love"
            };

            _repository.Tune.CreateTune(tune);
            _repository.Save();
            return Ok(tune);
        }
    }
}
