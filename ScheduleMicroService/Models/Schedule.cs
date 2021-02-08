using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Models
{
    public class Schedule
    {
        public string RepName { get; set; }
        public string DocName { get; set; }
        public string Ailment { get; set; }
        public List<string> Medicine { get; set; }
        public string Time { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public long Mobile { get; set; }
    }
}
