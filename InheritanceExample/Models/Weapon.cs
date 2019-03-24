using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Models
{
    public class Weapon : Equipment
    {
        public int Attack { get; set; }
        public int ElemAttack { get; set; }
        public ElemType ElemAttackType { get; set; }
        public bool ElemAttackHidden { get; set; }
    }
}
