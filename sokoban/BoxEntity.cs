using System.Drawing;

namespace sokoban
{
    public sealed class BoxEntity : Entity, IMovable
    {
        public bool OnHold { get; private set; }

        public BoxEntity(Point position, BoxModel boxModel)
            : base(position, boxModel) { }
        
        public void Move(Commands command)
        {
            switch (command)
            {
                case Commands.MoveUp:
                    MoveUp();
                    break;
                case Commands.MoveDown:
                    MoveDown();
                    break;
                case Commands.MoveLeft:
                    MoveLeft();
                    break;
                case Commands.MoveRight:
                    MoveRight();
                    break;
            }
        }
        
        private void MoveUp()
        {
            Position.Y -= Model.Size.Height;
            Sprite.Location = new Point(Position.X, Position.Y);

            OnTheHolderCheck();
            Level.LevelIsCompleteCheck();
        }

        private void MoveDown()
        {
            Position.Y += Model.Size.Height;
            Sprite.Location = new Point(Position.X, Position.Y);
            
            OnTheHolderCheck();
            Level.LevelIsCompleteCheck();
        }

        private void MoveLeft()
        {
            Position.X -= Model.Size.Width;
            Sprite.Location = new Point(Position.X, Position.Y);
            
            OnTheHolderCheck();
            Level.LevelIsCompleteCheck();
        }

        private void MoveRight()
        {
            Position.X += Model.Size.Width;
            Sprite.Location = new Point(Position.X, Position.Y);
            
            OnTheHolderCheck();
            Level.LevelIsCompleteCheck();
        }

        public void OnTheHolderCheck()
        {
            OnHold = Level.BoxOnTheHolderCheck(this);
        }
    }
}