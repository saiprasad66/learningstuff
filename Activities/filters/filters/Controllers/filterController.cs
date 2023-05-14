using filters.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace filters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Resourcefilter]
    [Exceptionfiter]
    public class filterController : ControllerBase
    {
        [HttpGet("show")]
        
        public string get()
        {
            return "sai found";
        }
    }
}
