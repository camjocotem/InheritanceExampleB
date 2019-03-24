using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Models
{
    public class Gem
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Description { get; set;  }
        public Skill Skill { get; set; }
    }
}
