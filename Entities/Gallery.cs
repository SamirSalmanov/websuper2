using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Gallery : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
    }
}
