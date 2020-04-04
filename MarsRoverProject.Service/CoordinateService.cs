using MarsRoverProject.Lib;
using MarsRoverProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Service
{
    public class CoordinateService : ICoordinate
    {

        public CoordinateService()
        {

        }
        private void Rotate90Left(CoordinateModel _position)
        {
            switch (_position.Direction)
            {
                case Directions.N:
                    _position.Direction = Directions.W;
                    break;
                case Directions.S:
                    _position.Direction = Directions.E;
                    break;
                case Directions.E:
                    _position.Direction = Directions.N;
                    break;
                case Directions.W:
                    _position.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90Right(CoordinateModel _position)
        {
            switch (_position.Direction)
            {
                case Directions.N:
                    _position.Direction = Directions.E;
                    break;
                case Directions.S:
                    _position.Direction = Directions.W;
                    break;
                case Directions.E:
                    _position.Direction = Directions.S;
                    break;
                case Directions.W:
                    _position.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private void MoveInSameDirection(CoordinateModel _position)
        {
            switch (_position.Direction)
            {
                case Directions.N:
                    _position.Y += 1;
                    break;
                case Directions.S:
                    _position.Y -= 1;
                    break;
                case Directions.E:
                    _position.X += 1;
                    break;
                case Directions.W:
                    _position.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public CoordinateModel StartMoving(List<int> maxPoints, string moves, CoordinateModel _position)
        {

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveInSameDirection(_position);
                        break;
                    case 'L':
                        this.Rotate90Left(_position);
                        break;
                    case 'R':
                        this.Rotate90Right(_position);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (_position.X < 0 || _position.X > maxPoints[0] || _position.Y < 0 || _position.Y > maxPoints[1])
                {
                    throw new Exception($"Oops! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
            return _position;
        }
    }
}
