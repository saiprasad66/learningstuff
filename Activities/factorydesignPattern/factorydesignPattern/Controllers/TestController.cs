using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace factorydesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string check(int id)
        {
            string name;
            if(id==1)
            {
                name = "sai";
            }
            else if(id==2)
            {
                name = "Kaveri";
            }
            else
            {
                name = "notfound";
            }
            return name;
        }
    }
}
