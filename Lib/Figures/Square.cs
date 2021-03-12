using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures.Figures
{
    [Serializable]
    public class Square : Shape
    {
        public Square(Point Location, float Aheigth, float Bwidth, Color Color) 
            : 
            base(Location, Aheigth, Bwidth, Color)
        {
            Aheigth = Bwidth;
        }
        protected Square() {}
        public override void Paint(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, 5))
                graphics.DrawRectangle(pen, Location.X-Bwidth/2, Location.Y-Aheigth/2, Bwidth, Aheigth);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
                graphics.FillRectangle(brush, Location.X - Bwidth / 2, Location.Y - Aheigth / 2, Bwidth, Aheigth);
        }
        public override bool Contain(Point point)
        {
            return base.Contain(point);
        }
        public override bool IsItOverllap(Shape fig1, Shape fig2)
        {
            return base.IsItOverllap(fig1, fig2);
        }

        public override double CalculateArea()
        {
            return Math.Round(Aheigth * Aheigth, 2);
        }
        public override double CalculateCircum()
        { 
            return Math.Round(4 * Aheigth,2);
        }
        public override string GetTypeSide()
        {
            return "квадрат";
        }
    }
}
