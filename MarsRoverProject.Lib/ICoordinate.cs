using MarsRoverProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Lib
{
    public interface ICoordinate
    {
        CoordinateModel StartMoving(List<int> maxPoints, string moves,CoordinateModel _position);
    }
}
