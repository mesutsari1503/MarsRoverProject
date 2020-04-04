using MarsRoverProject.Model;
using MarsRoverProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // max gidebileceği koordinatları alıyoruz.
            var _maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            // başlangıç koordinatlarını alıyoruz
            var _startCoordinate = Console.ReadLine().Trim().Split(' ');

            CoordinateService _coordinateervice = new CoordinateService();
            CoordinateModel _position = new CoordinateModel();


            if (_startCoordinate.Count() == 3)
            {
                _position.X = Convert.ToInt32(_startCoordinate[0]);
                _position.Y = Convert.ToInt32(_startCoordinate[1]);
                _position.Direction = (Directions)Enum.Parse(typeof(Directions), _startCoordinate[2]);
            }

            var _moves = Console.ReadLine().ToUpper();

            try
            {
                _position = _coordinateervice.StartMoving(_maxPoints, _moves, _position);
                Console.WriteLine($"{_position.X} {_position.Y} {_position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
