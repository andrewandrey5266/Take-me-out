﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using System;

public class GenerateLevel : MonoBehaviour
{

    void Start()
    {
        int square = 5;
        var test = new Board(square, square);
        test.DrawTiles();
        

    }
 
}
		