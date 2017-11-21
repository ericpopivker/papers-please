using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class OperationPermission
    {
        public string Module { get; set; }

        public string Resource { get; set; }

        public string Operation { get; set; }
    }
}
