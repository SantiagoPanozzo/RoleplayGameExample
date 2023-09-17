using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayLibrary
{
    public abstract class Item : IItem
    {
        public string Name { get; set; }
        public double AttackValue { get; set; }
        public double DefenseValue { get; set; }
        public Item(string name, double attackValue, double defenseValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
        public double GetAttackValue()
        {
            return this.AttackValue;
        }
        public double GetDefenseValue()
        {
            return this.DefenseValue;
        }
    }
}
