using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    interface IScheduleRepository
    {
        public ScheduleList Schedule();
    }
}
