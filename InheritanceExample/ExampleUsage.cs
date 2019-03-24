using InheritanceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class ExampleUsage
    {
        public ExampleUsage()
        {
            Weapon supBlade = new Weapon();
            supBlade.Name = "Supremecy Blade";
            supBlade.Attack = 200;
            supBlade.ElemAttackType = ElemType.Fire;
            supBlade.ElemAttack = 50;
            supBlade.ElemAttackHidden = false;
            supBlade.Slots = new List<GemSlot>();

            //Creating an example of Rathalos Armour
            Armour rathalosChest = new Armour();
            rathalosChest.Name = "Rathalos Chest";
            rathalosChest.Defense = 400;            

            ElementalDefense fireDef = new ElementalDefense();
            fireDef.Type = ElemType.Fire;
            fireDef.Value = 100;

            ElementalDefense watDef = new ElementalDefense();
            watDef.Type = ElemType.Water;
            watDef.Value = 0;

            ElementalDefense ltgDef = new ElementalDefense();
            ltgDef.Type = ElemType.Dragon;
            ltgDef.Value = -100;

            ElementalDefense drgDef = new ElementalDefense();
            drgDef.Type = ElemType.Dragon;
            drgDef.Value = -200;

            rathalosChest.ElemDefenses = new List<ElementalDefense>();
            rathalosChest.ElemDefenses.Add(fireDef);
            rathalosChest.ElemDefenses.Add(watDef);
            rathalosChest.ElemDefenses.Add(ltgDef);
            rathalosChest.ElemDefenses.Add(drgDef);
        }
    }
}
