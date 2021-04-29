using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_RPG
{
    public class Enemy
    {
        private int HP;
        private int MaxHP;
        private int AttackDamage;
        private int Cooldown;
        private int MaxCooldown;

        private void DoDamage()
        {

        }

        public void GetDamage(int damage)
        {
            HP = HP - damage;

            if (HP <= 0)
            {
                Die();
            }

        }

        public void DoTurn()
        {
            Cooldown -= 1;

            if (Cooldown == 0)
            {
                DoDamage();
                Cooldown = MaxCooldown;
            }
        }

        private void Die()
        {

        }
    }

}
