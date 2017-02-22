using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameField
    {
        public int SideSize { get; private set; }
        public Obstacle[] Obstacles { get; private set; }
        public int[,] Map { get; private set; }


        public GameField(int sideSize, int obstacleCount)
        {
            this.SideSize = sideSize;
            this.Obstacles = new Obstacle[obstacleCount];;
            this.Map = new int[sideSize,sideSize];

            for(int i = 0; i < Obstacles.Length; i++)
                Obstacles[i] = new Obstacle();
        }

        //Move TO SEPARATE SERVICE CLASS
        public void PushObstacle(int x, int y, int size)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            if (x < Map.GetLength(0) - 1 && Map[x + 1, y] == Map[x, y])
            {
                cube.transform.position = new Vector3(Map[x, y], Map[x, y] + Map.GetLength(1) / 2, -5);
                cube.transform.localScale = new Vector3(1, size, 1);
            }

            if (y < Map.GetLength(1) - 1 && Map[x, y + 1] == Map[x, y])
            {
                cube.transform.position = new Vector3(Map[x, y], Map[x, y] + Map.GetLength(1) / 2, -5);
                cube.transform.localScale = new Vector3(size, 1, 1);
            }

           /* Obstacle instance = new Obstacle()
            {
                Id = Obstacles.Count, // hardcode
                IsVertical = false, // hardcode
                Object = cube,
                Size = size,
                xPos = x,
                yPos = y
            };

            Obstacles.Add(instance);*/
        }

        public void InstantiateObstacles()
        {
            //foreach (var obstacle in Obstacles)
            //Instantiate(obstacle);
        }
    }
}
