using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
public class GenerateLevel : MonoBehaviour
{

    void Start()
    {
        Debug.Log("here");
        uint square = 5;
        Board test = new Board(square, square);
        Debug.Log("Now here");

       /* GameField gameField = new GameField(sideSize: 5, obstacleCount: 5);            

        var service = new MapService();

        service.MapInit(gameField);
        service.MapPlayer(gameField);
        service.MapObstacle(gameField);

        service.PrintMap(gameField.Map);
        CreateObjects(gameField);*/
    }
    void CreateObjects(GameField gameField)
    {
        for (int i = 0; i <=0; i++)
        {
            for (int j = 0; j < gameField.SideSize; j++)
            {
                for (int g = 0; g < gameField.SideSize; g++)
                {
                    if (gameField.Map[j, g] == i)
                    {
                        gameField.PushObstacle( j, g, i == 0 ? 2 : gameField.Obstacles[i - 1].Size);

                        goto next;
                    }
                }
            }
        next:
            Debug.Log(i + " has been instantiated");
        }
    }
      
}
		