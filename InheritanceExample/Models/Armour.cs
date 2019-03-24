using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Models
{
    public class Armour : Equipment
    {
        public int Defense { get; set; }
        public List<ElementalDefense> ElemDefenses { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
