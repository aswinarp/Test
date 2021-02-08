using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class ScheduleRepository:IScheduleRepository
    {
        readonly List<Doctor> doctors = new List<Doctor>();
        readonly RepresentativeList repList = new RepresentativeList();
        public ScheduleList Schedule()
        {
            doctors.Add(new Doctor {Name= "Luke Skywalker", Specialization= "Orthopaedics",Mobile=9988667732 });
            doctors.Add(new Doctor {Name="Obiwan Kenobi",Specialization= "General",Mobile=9988667732 });
            doctors.Add(new Doctor {Name="Mace Windu",Specialization= "General", Mobile=9988667732 });
            doctors.Add(new Doctor {Name="Master Yoda",Specialization= "Orthopaedics",Mobile=9988667732 });
            doctors.Add(new Doctor {Name="Han Solo",Specialization= "Gynaecology", Mobile=9988667732 });

            ScheduleList scheduleList = new ScheduleList();
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[0].RepName , DocName = doctors[0].Name , Ailment = doctors[0].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[0].Mobile }); //, Date = DateTime.Now, Medicine = new List<string> { } }); 
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[1].RepName , DocName = doctors[1].Name , Ailment = doctors[1].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[1].Mobile }); //, Date = DateTime.Now, Medicine = new List<string> { } });
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[2].RepName , DocName = doctors[2].Name , Ailment = doctors[2].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[2].Mobile }); //, Date = DateTime.Now, Medicine = new List<string> { } });
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[0].RepName , DocName = doctors[3].Name , Ailment = doctors[3].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[3].Mobile }); //, Date = DateTime.Now, Medicine = new List<string> { } });
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[1].RepName , DocName = doctors[4].Name , Ailment = doctors[4].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[4].Mobile }); //, Date = DateTime.Now, Medicine = new List<string> { } });
            return scheduleList;            
        }
    }
}
