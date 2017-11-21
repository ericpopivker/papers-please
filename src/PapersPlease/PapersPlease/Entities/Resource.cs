using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class Resource
    {
        public Resource(string name, List<Operation> operations)
        {
            this.Name = name;
            this.Operations = operations;
        }

        public string Name { get; set; }

        public List<Operation> Operations { get; set; }
    }
}
