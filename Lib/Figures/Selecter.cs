using System.Drawing;

namespace DrawFigures.Figures
{
    public class Selecter : Rectangle
    {
        public Selecter(Point Location, float Aheigth, float Bwidth, Color Color) 
            : base(Location, Aheigth, Bwidth, Color)
        {

        }

        public Selecter() { }
        public override void Paint(Graphics graphics)
        {
            using (var pen = new Pen(Color.Gray, 2))
                graphics.DrawRectangle(pen, Location.X, Location.Y, Bwidth, Aheigth);
        }
        public override bool Contain(Point point)
        {
            return Location.X < point.X &&
                Location.Y < point.Y &&
                Location.X + Bwidth > point.X &&
                Location.Y + Aheigth > point.Y;
        }
    }
}
