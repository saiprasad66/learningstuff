using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientSchedule.Models;

namespace PatientSchedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<patient> Get()
        {
            patient p1 = new patient();
            patient p2 = new patient();


            p1.PatientId = 100;
            p1.PatientName = "test1";
            p1.DoctorName = "James";

            p2.PatientId = 200;
            p2.PatientName = "test2";
            p2.DoctorName = "Amy";


            List<patient> lsobj = new List<patient>
            {
                p1,
                p2
            };

            return lsobj;




        }
    }
}
