using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Jewelry : Armor
    {
        private int extradamage;
        private int extrahealing;
        //public Jewelry(int maxStack, string name, string description, string type) : base(maxStack, name, description)
        //{
        //    this.type = type;
        //}
        //public string Type { get { return type; } }


        public Jewelry(int maxStack, string name, string description, int protection, int extradamage, string type) : base(maxStack, name, description, protection, extradamage, type)
        {
        }
    }
}
