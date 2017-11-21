using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class DataPermissionRequirement
    {
        public string Module { get; set; }

        public string Resource { get; set; }

        public int MinCount { get; set; }  //1 by default

        public int? MaxCount { get; set; }
    }
}
