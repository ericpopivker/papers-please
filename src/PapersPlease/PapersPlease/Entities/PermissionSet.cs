using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease.Entities
{
    public class PermissionSet
    {
        public string Id { get; set; }

        public string PermissionSetTemplateId { get; set; }

        public bool InheritOperationPermissionsFromTemplate { get; set; }

        public List<OperationPermission> OperationPermissions { get; set; }

        public List<DataPermission> DataPermission { get; set; }
    }
}
