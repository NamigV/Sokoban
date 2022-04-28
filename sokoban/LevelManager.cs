using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace sokoban
{
    public sealed class LevelManager
    {
        public static Form GameForm { get; private set; }
        public static PlayerEntity PlayerEntity { get; private set; }
        public static List<Level> Levels { get; private set; }
        public static int CurrentLevel { get; private set; }

        private readonly Dictionary<char, Model> _modelsMap;
        private readonly string _modelsCatalog;
        private readonly string _levelsCatalog;
        
        public LevelManager(Form form, string modelsCatalog, string levelsCatalog)
        {
            GameForm = form;
            _modelsCatalog = modelsCatalog;
            _levelsCatalog = levelsCatalog;
            Levels = new List<Level>();
            _modelsMap = new Dictionary<char, Model>();

            FillModelsMap();
            FillLevelsList();
        }

        public static bool StartGame(int currentLevel = 0)
        {
            if (Levels == null) return false;
            
            try
            {
                CurrentLevel = currentLevel;
                Levels[CurrentLevel].Render();
                PlayerEntity = Level.GetPlayerEntity();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не найдено ни одного уровня в папке \"levels\"", "Ошибка!");
                return false;
            }

            return true;
        }
        
        public static void LoadNextLevel()
        {
            if (Levels == null) return;
            Level.Clear();
            CurrentLevel++;

            try
            {
                Levels[CurrentLevel].Render();
                PlayerEntity = Level.GetPlayerEntity();
            }
            catch (ArgumentOutOfRangeException)
            {
                CurrentLevel = 0;
                StartGame();
            }
        }

        public static void RestartLevel()
        {
            Level.Clear();
            Levels[CurrentLevel].Render();
            PlayerEntity = Level.GetPlayerEntity();
        }
        
        private void FillLevelsList()
        {
            string[] levelsFiles = Directory.GetFiles(_levelsCatalog);
            Array.Sort(levelsFiles);

            foreach (string level in levelsFiles)
            {
                Levels.Add(new Level(_modelsMap, level));
            }
        }

        private void FillModelsMap()
        {
            string[] modelsFiles = Directory.GetFiles(_modelsCatalog);

            foreach (string model in modelsFiles)
            {
                Image image = Image.FromFile(model);
                
                if (model.Contains("wall"))
                {
                    _modelsMap.Add('#', new TileModel(new Size(32, 32), image));
                }
                else if (model.Contains("crate"))
                {
                    _modelsMap.Add('*', new BoxModel(new Size(32, 32), image));
                }
                else if (model.Contains("player"))
                {
                    _modelsMap.Add('0', new PlayerModel(new Size(32, 32), image));
                }
                else if (model.Contains("goal"))
                {
                    _modelsMap.Add('X', new BoxHolderModel(new Size(32, 32), image));
                }
            }
        }
    }
}