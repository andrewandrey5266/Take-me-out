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
            for (int j = 0; j < this.ColumnNumber; j++)
            {
                MonoBehaviour.Instantiate(white ? this.WhiteTile : this.BlackTile, 
                    new Vector3(j - (float)ColumnNumber / 2, i - (float)RowNumber / 2, -2), 
                    new Quaternion());
                white = !white;
            }
        }
    }

}
 

