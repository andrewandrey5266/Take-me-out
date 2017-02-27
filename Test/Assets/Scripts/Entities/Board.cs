using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {

    public uint RowNumber;
    public uint ColumnNumber;

    public GameObject WhiteTile;
    public GameObject BlackTile;
    private GameObject[,] Tiles;

    public Board(uint RowNumber, uint ColumnNumber)
    {
        this.RowNumber = RowNumber;
        this.ColumnNumber = ColumnNumber;

        this.WhiteTile = Resources.Load("Prefabs/Tiles/WhiteTile", typeof(GameObject)) as GameObject;
        this.BlackTile = Resources.Load("Prefabs/Tiles/BlackTile", typeof(GameObject)) as GameObject;
        //this.Tiles = new GameObject[this.RowNumber,this.ColumnNumber];
        this.DrawTiles();
    }

    private void DrawTiles()
    {
        bool white = true;
        for(int i = 0; i < this.RowNumber; i++)
        {
            white = (i % 2 != 0);
            Debug.Log(white + " " + i);
            for (int j = 0; j < this.ColumnNumber; j++)
            {
                if (white)
                {
                    MonoBehaviour.Instantiate(this.WhiteTile, new Vector3(j, i, -2), new Quaternion());
                    Debug.Log("Object instantiated " + i + " " + j + " And is white " + white);
                    white = !white;
                }
                else
                {
                    MonoBehaviour.Instantiate(this.BlackTile, new Vector3(j, i, -2), new Quaternion());
                    Debug.Log("Object instantiated " + i + " " + j + " And is white " + white);
                    white = !white;
                }
            }
        }
    }

  
 
}
