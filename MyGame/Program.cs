using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemyNum = int.Parse(args[0]);

            Enemy[] enemyArray = new Enemy[enemyNum];

            for (int i = 1; i <= enemyNum; i++)
            {
                Console.Write($"Nome do inimigo {i}: ");
                string name = Console.ReadLine();
                Enemy newEnemy = new Enemy(name);
                enemyArray[i-1] = newEnemy;
            }

            foreach (Enemy guy in enemyArray)
            {
                string name = guy.GetName();
                float health = guy.GetHealth();
                float shield = guy.GetShield();

                Console.WriteLine($"{name} {health} {shield}");
            }
        }
    }
}
