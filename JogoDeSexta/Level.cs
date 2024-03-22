using System;

namespace JogoDeSexta
{
    public class Level
    {
        private Enemy[] enemyInRoom;
        private Toughness dificulty;

        public Toughness GetToughness()
        {
            return dificulty;
        }

        public int GetNumRooms()
        {
            return enemyInRoom.Length;
        }

        public int GetNumEnemies()
        {
            int enemyNum = 0;
            foreach (Enemy en in enemyInRoom)
            {
                if (en != null) enemyNum++;
            }
            return enemyNum;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < enemyInRoom.Length; i++)
            {
                if (enemyInRoom[i] != null)
                {
                    string name = enemyInRoom[i].GetName();
                    Console.WriteLine($"Room {i}: {name}");
                }
            }
        }

        public void SetEnemyInRoom(int i, Enemy en)
        {
            enemyInRoom[i] = en;
        }

        public Level(int roomNum, Toughness dificulty)
        {
            enemyInRoom = new Enemy[roomNum];
            this.dificulty = dificulty;
        }
    }
}