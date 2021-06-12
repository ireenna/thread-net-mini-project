using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_.NET.DAL.Entities
{
    interface ISoftDeleted
    {
        public bool IsDeleted { get; set; }
    }
}
