using System.Collections.Generic;
using System.Drawing;

namespace sokoban
{
    public class Profile
    {
        public string ProfileName { get; set; }
        public List<Stats> LevelsStatsList { get; set; }
        public int CurrentLevel { get; set; }
        public List<List<Point>> CurrentLevelStateList { get; set; }
    }
}