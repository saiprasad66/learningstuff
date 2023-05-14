using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using factorydesignPattern.Models;

namespace factorydesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        private readonly SteamFactory streamFactory;
        public StreamController(SteamFactory streamFactory)
        {this.streamFactory = streamFactory;

        }
        [HttpGet("movies/{userchoice}")]
        public IEnumerable<string> Getmovies(string userchoice) {
            return streamFactory.GetStreamService(userchoice).ShowMovies();
        }
    }
}
