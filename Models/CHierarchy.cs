using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.UI.Models
{
    public class CHierarchy
    {
        public string Name { get; set; }

        public uint Id { get; set; }

        public uint? ParentId { get; set; }

        public string Details { get; set; }
    }
}
