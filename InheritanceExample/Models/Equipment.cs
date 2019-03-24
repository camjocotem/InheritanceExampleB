using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Models
{
    public class Equipment
    {
        public string Name { get; set; }
        public List<GemSlot> Slots {get;set;}
    }
}
