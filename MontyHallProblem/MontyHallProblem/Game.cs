using System;
using System.Collections.Generic;

namespace MontyHallProblem
{
    public class Game
    {
        public Game()
        {
            _generator = new Random();
            _winningDoor = _generator.Next(3);
            Doors = new Dictionary<int, char>()
            {
                {1, 'G'},
                {2, 'G'},
                {3, 'G'}
            };
        }

        private readonly Random _generator;
        private readonly int _winningDoor;
        
        public Dictionary<int, char> Doors { get; private set; }
        public int PickedDoor { get; set; }

        public void Init()
        {
            Doors[_winningDoor] = 'C';
        }

        public int ShowDoor()
        {
            int value;
            do
            {
                value = _generator.Next(3);
            } while (value == PickedDoor || value == _winningDoor);
            
            return value;
        }
    }
}
