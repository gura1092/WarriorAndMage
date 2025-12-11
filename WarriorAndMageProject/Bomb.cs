using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Bomb : Item, IUsableItem
    {
        private readonly int damage;

        public Bomb(int maxStack, int damage, string name, string description) : base(maxStack, name, description)
        {
            this.damage = damage;
        }

        public void Use(Player player, Enemy target = null)
        {
            int currentDamage = Math.Max(0, damage);

            if (target != null)
            {
                target.ApplyDamage(currentDamage);
            }
        }
    }
}
