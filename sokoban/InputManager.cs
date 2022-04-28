using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sokoban
{
    public sealed class InputManager
    {
        public InputManager(Dictionary<Keys, Commands> controlBindsMap)
        {
            LevelManager.GameForm.KeyUp += delegate(object sender, KeyEventArgs args)
            {
                foreach (var key in controlBindsMap.Keys.Where(key => args.KeyCode == key))
                {
                    switch (controlBindsMap[key])
                    {
                        case Commands.MoveUp:
                        case Commands.MoveDown:
                        case Commands.MoveLeft:
                        case Commands.MoveRight:
                            LevelManager.PlayerEntity.Move(controlBindsMap[key]);
                            break;
                        case Commands.UndoMove:
                            Level.UndoMovement();
                            break;
                        case Commands.RestartLevel:
                            LevelManager.RestartLevel();
                            break;
                        case Commands.Escape:
                            break;
                    }
                }
            };
        }
    }
}