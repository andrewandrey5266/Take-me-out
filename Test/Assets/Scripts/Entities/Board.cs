using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{

    public int RowNumber { get; private set; }
    public int ColumnNumber { get; private set; }

    public GameObject WhiteTile;
    public GameObject BlackTile;
    private GameObject[,] Tiles;

    public Board(int RowNumber, int ColumnNumber)
    {
        this.RowNumber = RowNumber;
        this.ColumnNumber = ColumnNumber;

        this.WhiteTile = Resources.Load("Prefabs/Tiles/WhiteTile", typeof(GameObject)) as GameObject;
        this.BlackTile = Resources.Load("Prefabs/Tiles/BlackTile", typeof(GameObject)) as GameObject;
    }

    public void DrawTiles()
    {
        bool white = true;
        for (int i = 0; i < this.RowNumber; i++)
        {
            white = (i % 2 != 0);
            Debug.Log(white + " " + i);
            for (int j = 0; j < this.ColumnNumber; j++)
            {
                float shiftX = ColumnNumber / 2 - j;
                float sjiftY = RowNumber / 2 - i;

                GameObject seed = null;
                if (white)
                    seed = this.WhiteTile;
                if(!white)
                    seed = this.BlackTile;

                MonoBehaviour.Instantiate(seed, new Vector3(j, i, -2), new Quaternion());
                Debug.Log("Object instantiated " + i + " " + j + " And is white " + white);
                white = !white;

            }
        }
    }

}
 

