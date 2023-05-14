using DoctorSchedule.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorSchedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            Doctor d1 = new Doctor();
            Doctor d2 = new Doctor();

            d1.DoctorId = 101;
            d1.DoctorName = "james";
            d1.Speciality = "Ortho";
            d1.Avaiability = System.DateTime.Now;

            d2.DoctorId = 102;
            d2.DoctorName = "saiPrasad";
            d2.Speciality = "Gyane";
            d2.Avaiability = System.DateTime.Now;

            List<Doctor> lsobj = new List<Doctor>
            {
                d1,
                d2
            };
            return lsobj;

        }
    }
}
