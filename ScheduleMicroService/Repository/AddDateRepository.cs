using System;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class AddDateRepository:IAddDateRepository
    {
        public ScheduleList AddDateToList(ScheduleList scheduleList,DateTime startdate)
        {
            int extra = 0;
            foreach(Schedule schedule in scheduleList.Schedules)
            {
                if (startdate.DayOfWeek == DayOfWeek.Sunday)
                {
                    extra++;
                    startdate = startdate.AddDays(extra);
                }
                else startdate = startdate.AddDays(1);
                schedule.Date = startdate;                
            }
            return scheduleList;
        }
    }
}
