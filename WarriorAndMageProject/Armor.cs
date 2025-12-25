using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Armor : Item
    {
        private int protection;
        private int extradamage;
        private string type;
        public Armor(int maxStack, string name, string description, int protection, int extradamage, string type) : base(maxStack, name, description)
        {
            this.type = type;
        }
        public string Type { get { return type; } }
    }
}
