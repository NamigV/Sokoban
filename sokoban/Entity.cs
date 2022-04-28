using System;
using System.Drawing;
using System.Windows.Forms;

namespace sokoban
{
    public class Entity : ICloneable
    {
        protected Point Position;
        protected readonly Model Model;
        protected PictureBox Sprite;
        
        protected Entity(Point position, Model model)
        {
            Position = position;
            Model = model;
            Sprite = null;
        }

        public void Render()
        {
            if (!(Sprite is null)) return;
            Sprite = new PictureBox();
            Sprite.Image = Model.Texture;
            Sprite.Size = Model.Size;
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            Sprite.Location = Position;
            LevelManager.GameForm.Controls.Add(Sprite);
        }

        public void Clear() =>
            Sprite.Dispose();

        public void SetPosition(Point position)
        {
            Position = position;
            Sprite.Location = Position;
        }

        public Point GetPosition() =>
            Position;
        
        public Size GetSize() =>
            Model.Size;

        public object Clone() =>
            new Entity(Position, Model);
    }
}