using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures.Figures
{
    [Serializable]
    public class Еllipse : Shape
    {
        public Еllipse(Point Location, float Aheigth, float Bwidth, Color Color)
            : base(Location, Aheigth, Bwidth, Color)
        {
        }
        protected Еllipse() { }
        public override void Paint(Graphics graphics)
        {
             using (Pen pen = new Pen(Color, 5))
                 graphics.DrawEllipse(pen, Location.X - Aheigth, Location.Y - Bwidth, Aheigth*2, Bwidth*2);
             using (SolidBrush brush = new SolidBrush(Color.FromArgb(
                 Math.Min(byte.MaxValue, Color.R + 100),
                 Math.Min(byte.MaxValue, Color.G + 100),
                 Math.Min(byte.MaxValue, Color.B + 100))))
                 graphics.FillEllipse(brush, Location.X - Aheigth, Location.Y - Bwidth, Aheigth*2, Bwidth*2);
        }
        public override bool Contain(Point point)
        {
            return Math.Pow(point.X - Location.X, 2) /
            Math.Pow(Aheigth, 2) +
            Math.Pow(point.Y - Location.Y, 2) /
            Math.Pow(Bwidth, 2)
            <= 1.0;
        }
        public override bool IsItOverllap(Shape fig1, Shape fig2)
        {
            var rectangleCenter = new PointF(fig1.Location.X + fig1.Bwidth / 2,
                                 fig1.Location.Y + fig1.Aheigth / 2);
            var w = fig1.Bwidth / 2;
            var h = fig1.Aheigth / 2;
            var dx = Math.Abs(fig2.Location.X - rectangleCenter.X);
            var dy = Math.Abs(fig2.Location.Y - rectangleCenter.Y);
            var circleDistance = new PointF(Math.Abs(fig2.Location.X - fig1.Location.X - w),
                                            Math.Abs(fig2.Location.Y - fig1.Location.Y - h));

            if (dx > (fig2.Aheigth + w) || dy > (fig2.Aheigth + h) || dx > (fig2.Bwidth + w) || dy > (fig2.Bwidth + h))
                return false;
            if (circleDistance.X <= w || circleDistance.Y <= h)
                return true;
            return Math.Pow(circleDistance.X - w, 2) +
                Math.Pow(circleDistance.Y - h, 2) <= Math.Pow(fig2.Aheigth, 2) &&
                Math.Pow(circleDistance.X - w, 2) +
                Math.Pow(circleDistance.Y - h, 2) <= Math.Pow(fig2.Bwidth, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Aheigth * Bwidth, 2);
        }
        public override double CalculateCircum()
        {
            return Math.Round(Math.PI * (3 * (Aheigth + Bwidth) - Math.Sqrt((3 * Aheigth + Bwidth) * (Aheigth + 3 * Bwidth))), 2);
        }
        public override string GetTypeSide()
        {
            if (Aheigth == Bwidth)
                return "частен случай -> кръг";
            return "елипса";
        }
    } 
}
