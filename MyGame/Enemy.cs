using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

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

        // Construtor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }
    }
}