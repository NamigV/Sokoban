using System.Drawing;

namespace sokoban
{
    public sealed class TileModel : Model
    {
        public TileModel(Size size, Image texture) 
            : base(size, texture) { }
    }
}