using System.Collections.Generic;

namespace MontyHallProblem
{
    public class Game
    {
        public Dictionary<int, char> Doors { get; private set; }

        public void Init()
        {
            Doors = new Dictionary<int, char>()
            {
                {1, 'G'},
                {2, 'C'},
                {3, 'G'}
            };
        }
    }
}
