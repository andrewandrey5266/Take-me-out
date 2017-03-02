using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts
{ 
    public class Obstacle
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public bool IsVertical { get; set; }
        
        public GameObject Object { get; set; }

        public int? xPos { get; set; }
        public int? yPos { get; set; }        
    }
}
