using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class Operation
    {
        public Operation(string name)
        {
            this.Name = name;
        }


        public string Name { get; set; }
    }
}
