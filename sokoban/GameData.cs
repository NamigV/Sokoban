using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace sokoban
{
    public static class GameData
    {
        public static string DataCatalog { get; set; } = "data";

        public static void SaveData() =>
            File.WriteAllText($"{DataCatalog}\\{ProfileManager.CurrentProfileName}.json", JsonConvert.SerializeObject(ProfileManager.GetCurrentProfile()));
        
        public static void LoadData()
        {
            List<string> dataFiles = Directory.GetFiles(DataCatalog).ToList();
            dataFiles.Sort();
            
            List<Profile> profiles = dataFiles.Select(dataFile => JsonConvert.DeserializeObject<Profile>(File.ReadAllText(dataFile))).ToList();
            ProfileManager.Profiles = profiles;
        }

        public static void ResetData(string profileName)
        {
            foreach (Stats stats in ProfileManager.Profiles.Where(profile => profile.ProfileName == profileName).SelectMany(profile => profile.LevelsStatsList))
            {
                stats.Reset();
            }
        }
    }
}