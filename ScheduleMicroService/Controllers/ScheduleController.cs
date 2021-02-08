using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;
using ScheduleMicroService.Models;
using Microsoft.Extensions.Configuration;

namespace ScheduleMicroService.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ScheduleController(IConfiguration config)
        {
            _config = config;
        }

        //[Authorize]
        [HttpGet("Create")]
        public IActionResult CreateSchedule(string datestr)
        {
            DateTime date = DateTime.Parse(datestr);
            IActionResult response = Unauthorized();
            ScheduleRepository scheduleRepository = new ScheduleRepository();
            ScheduleList scheduleList = scheduleRepository.Schedule();
            AddDateRepository addDate = new AddDateRepository();
            AddMedicineRepository addMedicine = new AddMedicineRepository();
            scheduleList = addDate.AddDateToList(scheduleList,date);
            scheduleList = addMedicine.AddMedicineList(scheduleList,_config);
            if (scheduleList.Schedules.Count == 0)
                return response;
            response=Ok(scheduleList.Schedules);
            return response;            
        }
        [AllowAnonymous]
        [HttpGet("Run")]
        public ActionResult<string> Get()
        {
            return "The Schedule Creation MicroService API is Running";
        }
    }
}
