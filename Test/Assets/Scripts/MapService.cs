using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace AssemblyCSharp
{
	public class MapService{
		public void MapInit(int[,] map){
			for (int i = 0; i < map.GetLength(0); i++) 
				for(int j = 0; j < map.GetLength(1); j++)
					map [i, j] = -1;
		}
		public void MapPlayer(int[,] map){
			map [0, 2] = 0;
			map [1, 2] = 0;
		}


		public void PlaceObstacle(int obstacleCount, int[] obstacleSize){

		}

		private void SetObstacleSize(int obstacleCount, int[] obstacleSize){
			for (int i = 0; i < obstacleCount; i++) {
				obstacleSize [i] = 2;
				if (i % 2 != 0)
					obstacleSize [i]++;
			
			}
		}


		public void PrintMap(int [,] map){

            for (int a = 0; a<map.GetLength(0); a++) {
                string row = "";

                row += a.ToString() + "|";
                for(int b = 0; b< map.GetLength(1); b++)
                {
                    row += map[a, b].ToString() + " ";
                }
            Debug.Log(row);
               
            }
        }
	}
}

