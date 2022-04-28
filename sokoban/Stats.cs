using System.Collections.Generic;
using System.Drawing;

namespace sokoban
{
    public class Stats
    {
        public int CountOfSteps { get; set; }
        public int CountOfCrateBumps { get; set; }

        public void Reset()
        {
            CountOfSteps = 0;
            CountOfCrateBumps = 0;
        }
    }
}