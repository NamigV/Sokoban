using System;
using System.Drawing;

namespace sokoban
{
    public class Model : ICloneable
    {
        public Size Size { get; }
        public Image Texture { get; }

        protected Model(Size size, Image texture)
        {
            Size = size;
            Texture = texture;
        }

        public object Clone() =>
            new Model(Size, Texture);
    }
}