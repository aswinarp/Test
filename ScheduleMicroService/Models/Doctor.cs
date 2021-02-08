using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public long Mobile { get; set; }
        public string Specialization { get; set; }
    }
}
