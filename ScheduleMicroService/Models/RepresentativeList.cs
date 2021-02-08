using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Models
{
    public class RepresentativeList
    {
        public List<Representative> representatives = new List<Representative>()
        {
            new Representative {RepName="Darth Vader"},
            new Representative {RepName="Kylo Ren"},
            new Representative {RepName="Boba Fett"}
        };
    }
}
