using System.Drawing;

namespace sokoban
{
    public sealed class TileEntity : Entity
    {
        public TileEntity(Point position, TileModel tileModel) 
            : base(position, tileModel) { }
    }
}