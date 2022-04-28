using System.Drawing;

namespace sokoban
{
    public sealed class BoxModel : Model
    {
        public BoxModel(Size size, Image texture) 
            : base(size, texture) { }
    }
}