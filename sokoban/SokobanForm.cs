using System.Collections.Generic;
using System.Windows.Forms;

namespace sokoban
{
    public partial class SokobanForm : Form
    {
        public SokobanForm()
        {
            Dictionary<Keys, Commands> controlBindsMap = new Dictionary<Keys, Commands>
            {
                {Keys.W, Commands.MoveUp},
                {Keys.S, Commands.MoveDown},
                {Keys.A, Commands.MoveLeft},
                {Keys.D, Commands.MoveRight},
                {Keys.Z, Commands.UndoMove},
                {Keys.R, Commands.RestartLevel},
                {Keys.Escape, Commands.Escape}
            };
            LevelManager levelManager = new LevelManager(this,"models","levels");
            InputManager inputManager = new InputManager(controlBindsMap);

            InitializeComponent();
        }
    }
}