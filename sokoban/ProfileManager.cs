using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace sokoban
{
    public static class ProfileManager
    {
        public static List<Profile> Profiles = new List<Profile>();
        public static string CurrentProfileName { get; private set; }

        public static void CreateProfile(string profileName)
        {
            CurrentProfileName = profileName;
            List<Stats> levelsStatsList = new List<Stats>();
            for (int i = 0; i < LevelManager.Levels.Count; ++i)
            {
                levelsStatsList.Add(new Stats());
            }

            Profile profile = new Profile
            {
                ProfileName = profileName,
                LevelsStatsList = levelsStatsList,
                CurrentLevelStateList = new List<List<Point>>()
            };
            
            Profiles.Add(profile);
        }

        public static bool Login(string profileName)
        {
            if (Profiles.All(profile => profile.ProfileName != profileName)) return false;
            CurrentProfileName = profileName;
            return true;
        }

        public static void RecordStepsCount()
        {
            foreach (Profile profile in Profiles.Where(profile => profile.ProfileName == CurrentProfileName))
            {
                profile.LevelsStatsList[LevelManager.CurrentLevel].CountOfSteps++;
            }
        }

        public static void RecordCrateBumpsCount()
        {
            foreach (Profile profile in Profiles.Where(profile => profile.ProfileName == CurrentProfileName))
            {
                profile.LevelsStatsList[LevelManager.CurrentLevel].CountOfCrateBumps++;
            }
        }

        public static void RecordLevelState()
        {
            foreach (Profile profile in Profiles.Where(profile => profile.ProfileName == CurrentProfileName))
            {
                profile.CurrentLevelStateList = Level.GetLevelState();
                profile.CurrentLevel = LevelManager.CurrentLevel;
            }
        }

        public static Profile GetCurrentProfile()
        {
            return Profiles.FirstOrDefault(profile => profile.ProfileName == CurrentProfileName);
        }
    }
}