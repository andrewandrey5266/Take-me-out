using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
public class GenerateLevel : MonoBehaviour
{

    

    void Start()
    {
        GameField gameField = new GameField(sideSize: 5, obstacleCount: 5, obstacleSize: new int[5], map: new int[0, 0]);
            

        var service = new AssemblyCSharp.MapService();
        service.MapInit(gameField.Map);
        service.MapPlayer(gameField.Map);

        service.PrintMap(gameField.Map);


        CreateObjects(gameField);
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
                        gameField.PushObstacle( j, g, i == 0 ? 2 : gameField.ObstacleSize[i - 1]);

                        goto next;
                    }
                }
            }
        next:
            Debug.Log(i + " has been instantiated");
        }
    }
      
}
		