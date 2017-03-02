using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts;

public class MapService{
		public void MapInit(GameField gameField){
			for (int i = 0; i < gameField.Map.GetLength(0); i++) 
				for(int j = 0; j < gameField.Map.GetLength(1); j++)
					gameField.Map [i, j] = -1;
		}
		public void MapPlayer(GameField gameField){
			gameField.Map [0, 2] = 0;
			gameField.Map [1, 2] = 0;
		}
		public void MapObstacle(GameField gameField)
		{
			SetObstacleSize(gameField.Obstacles);

			PlaceObstacles(gameField.Obstacles, gameField.Map);
		}		
		public void PrintMap(int [,] map){
                string row = "";

            for (int a = 0; a<map.GetLength(0); a++) {

                row += a.ToString() + "|";
                for(int b = 0; b< map.GetLength(1); b++)
                {
                    row += map[a, b].ToString() + " ";
                }
            row+="\n";
               
            }
			Debug.Log(row);
		}

		private void PlaceObstacles(Obstacle[] obstacles, int[,] map){
			
		}
		//Generates sizes of obstacles
    	private void SetObstacleSize(Obstacle[] obstacles){
			for (int i = 0; i < obstacles.Length; i++) {
				obstacles [i].Size = 2;
				if (i % 2 != 0)
					obstacles [i].Size++;
			}
		}

}


