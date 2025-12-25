using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Weapon : Item
    {
        private int baseDamage;
        private int endurance;
        public Weapon(int maxStack, string name, string description, int baseDamage, int endurance) : base(maxStack, name, description)
        {
            this.baseDamage = baseDamage;
            this.endurance = endurance;
        }
    }
}
