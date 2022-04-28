using System.Drawing;

namespace sokoban
{
    public sealed class PlayerEntity : Entity, IMovable
    {
        public PlayerEntity(Point position, PlayerModel playerModel)
            : base(position, playerModel) { }
        
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
            Point direction = new Point(0, -1);
            bool isObstacle = !Level.CheckPath(this, direction, out BoxEntity box);

            switch (isObstacle)
            {
                case true when box != null:
                {
                    if (Level.CheckPath(box, direction, out _))
                    {
                        Level.RecordMovement(this, box);
                        ProfileManager.RecordStepsCount();
                        ProfileManager.RecordCrateBumpsCount();
                        
                        box.Move(Commands.MoveUp);
                        Position.Y -= Model.Size.Height;
                        Sprite.Location = new Point(Position.X, Position.Y);
                    }

                    break;
                }
                case false:
                    Level.RecordMovement(this);
                    ProfileManager.RecordStepsCount();
                    
                    Position.Y -= Model.Size.Height;
                    Sprite.Location = new Point(Position.X, Position.Y);
                    
                    break;
            }
        }
        
        private void MoveDown()
        {
            Point direction = new Point(0, 1);
            bool isObstacle = !Level.CheckPath(this, direction, out BoxEntity box);

            switch (isObstacle)
            {
                case true when box != null:
                {
                    if (Level.CheckPath(box, direction, out _))
                    {
                        Level.RecordMovement(this, box);
                        ProfileManager.RecordStepsCount();
                        ProfileManager.RecordCrateBumpsCount();

                        box.Move(Commands.MoveDown);
                        Position.Y += Model.Size.Height;
                        Sprite.Location = new Point(Position.X, Position.Y);
                    }

                    break;
                }
                case false:
                    Level.RecordMovement(this);
                    ProfileManager.RecordStepsCount();

                    Position.Y += Model.Size.Height;
                    Sprite.Location = new Point(Position.X, Position.Y);
                    break;
            }
        }

        private void MoveLeft()
        {
            Point direction = new Point(-1, 0);
            bool isObstacle = !Level.CheckPath(this, direction, out BoxEntity box);

            switch (isObstacle)
            {
                case true when box != null:
                {
                    if (Level.CheckPath(box, direction, out _))
                    {
                        Level.RecordMovement(this, box);
                        ProfileManager.RecordStepsCount();
                        ProfileManager.RecordCrateBumpsCount();

                        box.Move(Commands.MoveLeft);
                        Position.X -= Model.Size.Width;
                        Sprite.Location = new Point(Position.X, Position.Y);
                    }

                    break;
                }
                case false:
                    Level.RecordMovement(this);
                    ProfileManager.RecordStepsCount();
                    
                    Position.X -= Model.Size.Width;
                    Sprite.Location = new Point(Position.X, Position.Y);
                    break;
            }
        }

        private void MoveRight()
        {
            Point direction = new Point(1, 0);
            bool isObstacle = !Level.CheckPath(this, direction, out BoxEntity box);

            switch (isObstacle)
            {
                case true when box != null:
                {
                    if (Level.CheckPath(box, direction, out _))
                    {
                        Level.RecordMovement(this, box);
                        ProfileManager.RecordStepsCount();
                        ProfileManager.RecordCrateBumpsCount();

                        box.Move(Commands.MoveRight);
                        Position.X += Model.Size.Width;
                        Sprite.Location = new Point(Position.X, Position.Y);
                    }

                    break;
                }
                case false:
                    Level.RecordMovement(this);
                    ProfileManager.RecordStepsCount();

                    Position.X += Model.Size.Width;
                    Sprite.Location = new Point(Position.X, Position.Y);
                    break;
            }
        }
    }
}