using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace sokoban
{
    public sealed class Level
    {
        private static List<List<Entity>> _entities;
        private static List<Entity> _playerEntities;
        private static List<Entity> _boxEntities;
        private static List<Entity> _boxHolderEntities;
        private static List<Entity> _tileEntities;
        private static Stack<Dictionary<Dictionary<Entity, Point>, Dictionary<Entity, Point>>> _entitiesMovementStack;

        private readonly Dictionary<char, Model> _modelsMap;
        private readonly string _levelConfigFilePath;

        public Level(Dictionary<char, Model> modelsMap, string levelConfigFilePath)
        {
            _entities = new List<List<Entity>>
            {
                {_playerEntities = new List<Entity>()},
                {_boxEntities = new List<Entity>()},
                {_boxHolderEntities = new List<Entity>()},
                {_tileEntities = new List<Entity>()}
            };
            _entitiesMovementStack = new Stack<Dictionary<Dictionary<Entity, Point>, Dictionary<Entity, Point>>>();
            _modelsMap = modelsMap;
            _levelConfigFilePath = levelConfigFilePath;
        }
        
        public void Render()
        {
            ParseLevelConfigFile();

            foreach (var entity in _entities.SelectMany(entitiesList => entitiesList))
            {
                entity.Render();
            }
        }

        public static void Clear()
        {
            if (_entities == null) return;
            foreach (List<Entity> entitiesList in _entities)
            {
                foreach (Entity entity in entitiesList)
                {
                    entity.Clear();
                }
                
                entitiesList.Clear();
            }
        }
        
        public static PlayerEntity GetPlayerEntity() => _playerEntities.Last() as PlayerEntity;

        public static void LoadLevelState(List<List<Point>> levelState)
        {
            int y = 0;
            int x = 0;

            foreach (List<Entity> entities in _entities)
            {
                foreach (Entity entity in entities)
                {
                    entity.SetPosition(levelState[y][x]);
                    x++;
                }

                y++;
                x = 0;
            }

            foreach (var entity in _entities.SelectMany(entities => entities))
            {
                if (entity is BoxEntity boxEntity)
                {
                    boxEntity.OnTheHolderCheck();
                }
            }
        }

        public static List<List<Point>> GetLevelState()
        {
            List<List<Point>> levelState = new List<List<Point>>();
            for (int k = 0; k < _entities.Count; ++k)
            {
                levelState.Add(new List<Point>());
            }

            int i = 0;
            foreach (List<Entity> entities in _entities)
            {
                foreach (Entity entity in entities)
                {
                    levelState[i].Add(entity.GetPosition());
                }

                i++;
            }

            return levelState;
        }
        
        public static bool CheckPath<T>(T movable, Point direction, out BoxEntity box) where T : Entity, IMovable
        {
            Point intendedPosition = new Point
            {
                X = movable.GetPosition().X + (movable.GetSize().Width * direction.X),
                Y = movable.GetPosition().Y + (movable.GetSize().Height * direction.Y)
            };

            box = null;
            
            foreach (var entity in _entities.SelectMany(entityList => entityList.Where(entity => entity.GetPosition() == intendedPosition && (entity is TileEntity || entity is BoxEntity))))
            {
                if (!(entity is BoxEntity boxEntity)) return false;
                box = boxEntity;
                
                return false;
            }
            
            return true;
        }

        public static bool BoxOnTheHolderCheck(BoxEntity boxEntity)
        {
            return _boxHolderEntities.Any(boxHolderEntity => boxHolderEntity.GetPosition() == boxEntity.GetPosition());
        }

        public static void LevelIsCompleteCheck()
        {
            int countOfBoxes = _boxEntities.Count;
            int countOfHeldBoxes = _boxEntities.Cast<BoxEntity>().Count(boxEntity => boxEntity.OnHold);

            if (countOfBoxes == countOfHeldBoxes)
            {
                LevelManager.LoadNextLevel();
            }
        }

        public static void RecordMovement(PlayerEntity playerEntity, BoxEntity boxEntity = null)
        {
            Dictionary<Entity, Point> oldPlayerEntityStateMap = new Dictionary<Entity, Point>
            {
                {playerEntity, new Point(playerEntity.GetPosition().X, playerEntity.GetPosition().Y)}
            };

            if (boxEntity != null)
            {
                Dictionary<Entity, Point> oldBoxEntityStateMap = new Dictionary<Entity, Point>
                {
                    {boxEntity, new Point(boxEntity.GetPosition().X, boxEntity.GetPosition().Y)}
                };
                
                _entitiesMovementStack.Push(new Dictionary<Dictionary<Entity, Point>, Dictionary<Entity, Point>> {{oldPlayerEntityStateMap, oldBoxEntityStateMap}});
            }
            else
            {
                _entitiesMovementStack.Push(new Dictionary<Dictionary<Entity, Point>, Dictionary<Entity, Point>> {{oldPlayerEntityStateMap, null}});
            }
        }

        public static void UndoMovement()
        {
            if (!_entitiesMovementStack.Any()) return;
            Dictionary<Dictionary<Entity, Point>, Dictionary<Entity, Point>> oldEntitiesStateMap = _entitiesMovementStack.Pop();

            foreach (Dictionary<Entity,Point> oldPlayerStateDictionary in oldEntitiesStateMap.Keys)
            {
                foreach (Entity oldPlayerEntity in oldPlayerStateDictionary.Keys)
                {
                    foreach (var playerEntity in _playerEntities.Where(playerEntity => oldPlayerEntity == playerEntity))
                    {
                        playerEntity.SetPosition(new Point(oldPlayerStateDictionary[oldPlayerEntity].X, oldPlayerStateDictionary[oldPlayerEntity].Y));
                    }
                }
            }

            if (oldEntitiesStateMap.First().Value == null) return;
            foreach (Dictionary<Entity,Point> oldBoxStateDictionary in oldEntitiesStateMap.Values)
            {
                foreach (Entity oldBoxEntity in oldBoxStateDictionary.Keys)
                {
                    foreach (var boxEntity in _boxEntities.Where(boxEntity => oldBoxEntity == boxEntity))
                    {
                        boxEntity.SetPosition(new Point(oldBoxStateDictionary[oldBoxEntity].X, oldBoxStateDictionary[oldBoxEntity].Y));
                        if (boxEntity is BoxEntity box) box.OnTheHolderCheck();
                    }
                }
            }
        }

        private void ParseLevelConfigFile()
        {
            using (StreamReader streamReader = new StreamReader(_levelConfigFilePath, Encoding.Default))
            {
                string line;
                int row = 0;
                
                while ((line = streamReader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; ++i)
                    {
                        if (line[i] == ' ')
                        {
                            continue;
                        }

                        foreach (char mapKey in _modelsMap.Keys)
                        {
                            if (line[i] != mapKey) continue;
                            int xPos = _modelsMap[mapKey].Size.Width * i;
                            int yPos = _modelsMap[mapKey].Size.Height * row;
                            Point position = new Point(xPos, yPos);
                                
                            CreateEntity(position, _modelsMap[mapKey]);
                        }
                    }

                    row++;
                }
            }
        }

        private void CreateEntity(Point position, Model model)
        {
            switch (model)
            {
                case TileModel tileModel:
                    _tileEntities.Add(new TileEntity(position, tileModel));
                    break;
                case BoxModel boxModel:
                    _boxEntities.Add(new BoxEntity(position, boxModel));
                    break;
                case PlayerModel playerModel:
                    _playerEntities.Add(new PlayerEntity(position, playerModel));
                    break;
                case BoxHolderModel boxHolderModel:
                    _boxHolderEntities.Add(new BoxHolderEntity(position, boxHolderModel));
                    break;
            }
        }
    }
}