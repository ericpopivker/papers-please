using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class Module
    {
        public Module(string name, List<Resource> resources)
        {
            this.Name = name;
            this.Resources = resources;
        }

        public string Name { get; set; }
        
        public List<Resource> Resources {get; set;}
    }

}
