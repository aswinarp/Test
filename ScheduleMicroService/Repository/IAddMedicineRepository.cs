using Microsoft.Extensions.Configuration;
using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    interface IAddMedicineRepository
    {
        public ScheduleList AddMedicineList(ScheduleList scheduleList, IConfiguration _config);
    }
}
