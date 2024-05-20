using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
    public class Resource
    {
            [Key]
            public int ResourceId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public ResourceType Type { get; set; }
        }

        public enum ResourceType
        {
            Room,
            Equipment,
            Other
        }
    
}
