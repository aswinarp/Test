using ScheduleMicroService.Models;
using System;

namespace ScheduleMicroService.Repository
{
    interface IAddDateRepository
    {
        public ScheduleList AddDateToList(ScheduleList scheduleList, DateTime startdate);
    }
}
