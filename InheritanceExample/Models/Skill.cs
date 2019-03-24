using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Models
{
    public class Skill
    {
        public string SkillName { get; set; }
        public int SkillLevels { get; set;  }
        public bool HasSetBonusSkill { get; set; }
        public int RequiredNoToActivateSetBonus { get; set; }
    }
}
