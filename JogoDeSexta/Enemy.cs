using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDeSexta
{
    public class Enemy
    {
        static int powerUpCount;
        private string name;
        private float health;
        private float shield;

        // Getter do powerUpCount
        public float GetPowerUpCount()
        {
            return powerUpCount;
        }

        // Getter de nome
        public string GetName()
        {
            return name;
        }

        // Getter da vida
        public float GetHealth()
        {
            return health;
        }

        // Getter do shield
        public float GetShield()
        {
            return shield;
        }

        // Setter do nome
        public void SetName(string s)
        {
            string temp = "";
            if (s.Length > 8)
            {
                for (int i = 0; i<8; i++)
                {
                    temp += s[i];
                } 
            }
            else
            {
                temp = s;
            }
            name = temp;
        }

        // Metodo para dar dano
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        // Metodo para apanhar powerups
        public void PickupPowerUp(PowerUp pwu, float fa)
        {
            powerUpCount++;
            if (pwu == PowerUp.Health)
            {
                health += fa;
                if (health > 100) health = 100;
            }
            else if (pwu == PowerUp.Shield)
            {
                shield += fa;
                if (shield > 100) shield = 100;
            }
        }

        // Construtor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }
        static Enemy()
        {
            powerUpCount = 0;
        }
    }
}