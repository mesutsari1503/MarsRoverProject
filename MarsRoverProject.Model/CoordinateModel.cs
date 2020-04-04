using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Model
{
    public enum Directions
    {
        N = 1,  //North
        S = 2,  //South
        E = 3,  //East
        W = 4   //West
    }
    public class CoordinateModel
    {
      
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public CoordinateModel()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

    }
}
