using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class PermissionSchema
    {
        public string Id { get; set; }

        public List<Module> Modules { get; set; }

    }
}
