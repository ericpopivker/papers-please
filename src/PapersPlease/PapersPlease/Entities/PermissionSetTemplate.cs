using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    //Not required
    //Can be used for more complicated scenarios

    public class PermissionSetTemplate
    {
       
        public string Id { get; set; }

        public List<OperationPermission> OperationPermissions { get; set; }

        public List<DataPermissionRequirement> DataPermissionRequirements { get; set; }

    }
}
