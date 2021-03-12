
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;


namespace DrawFigures.Figures
{
    [Serializable]
    public class Triangle : Shape
    {
        private PointF[] points;
        private double A1
        {
            get { return Math.Sqrt(Math.Pow(this.C, 2) - Math.Pow(this.Heigth, 2)); }
        }
        private double Heigth
        {
            get { return 2 * CalculateArea() / Math.Max(Aheigth,Bwidth); }           
        }

        public Triangle(Point Location, float Aheigth, float Bwidth, Color Color, float c)
            :
            base(Location, Aheigth, Bwidth, Color)
        {
            C = c;
        }
        protected Triangle() { }

        public override void Paint(Graphics graphics)
        {
            if (Aheigth + Bwidth <= C || Aheigth + C <= Bwidth || Bwidth + C <= Aheigth)
                throw new Exception("Невалидни стойности за триъгълник!");              
            else
            {
                points = new PointF[3]
                {
                     new PointF(Location.X, Location.Y),
                     new PointF(Location.X + Math.Max(Aheigth, Bwidth), Location.Y),
                     new PointF(Location.X + (float)A1, Location.Y + (float)Heigth)
                };

                using (Pen pen = new Pen(Color, 5))
                    graphics.DrawPolygon(pen, points);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
                    graphics.FillPolygon(brush, points);
            }       
        } 
        
        public override bool Contain(Point point)
        { 
            Triangle tr1 = new Triangle();
            Triangle tr2 = new Triangle();
            Triangle tr3 = new Triangle();
            double area1 = Math.Round(
                tr1.triangleArea(points[0], point, points[1]) + 
                tr2.triangleArea(points[0], point, points[2]) + 
                tr3.triangleArea(points[1], point, points[2]),2);
            return area1 == this.CalculateArea();
        }
        public override bool IsItOverllap(Shape fig1, Shape fig2)
        {
                bool a = LineRectangle(fig1, points[0].X, points[0].Y, points[1].X, points[1].Y);
                bool b = LineRectangle(fig1, points[1].X, points[1].Y, points[2].X, points[2].Y);
                bool c = LineRectangle(fig1, points[0].X, points[0].Y, points[2].X, points[2].Y);
                return a || b || c || fig1.Contain(fig2.Location);
        }
        private bool LineRectangle(Shape r, float x1, float y1, float x2, float y2)
        {
            bool left = LineLine(x1, y1,x2,y2, r.Location.X, r.Location.Y, r.Location.X, r.Location.Y + r.Aheigth);
            bool right = LineLine(x1, y1, x2, y2, r.Location.X + r.Bwidth, r.Location.Y, r.Location.X + r.Bwidth, r.Location.Y + r.Aheigth);
            bool top = LineLine(x1, y1, x2, y2, r.Location.X, r.Location.Y, r.Location.X + r.Bwidth, r.Location.Y);
            bool bottom = LineLine(x1, y1, x2, y2, r.Location.X, r.Location.Y + r.Aheigth, r.Location.X + r.Bwidth, r.Location.Y + r.Aheigth);

            return left || right || top || bottom;
        }
        private bool LineLine(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            float uA = ((x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3)) / ((y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1));
            float uB = ((x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3)) / ((y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1));

            return uA >= 0 && uA <= 1 && uB >= 0 && uB <= 1;
        }
        public override double CalculateCircum()
        {
            return Math.Round(Aheigth + Bwidth + C,2);      
        }
        public override double CalculateArea()
        {
            double p = (Aheigth+Bwidth+C)/2;
            return Math.Round(Math.Sqrt(p * (p - Aheigth) * (p - Bwidth) * (p - C)),2) ;
        }
        private double triangleArea(PointF p1, PointF p2, PointF p3)
        {   
            return Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0);
        }
        public override string GetTypeSide()
        {
            string angle = GetTypeAngle();
            if (Aheigth == Bwidth && Aheigth == C)
                return "равностранен и " + angle;
            else if (Aheigth == Bwidth || Aheigth == C || C == Bwidth)
                return "равнобедрен и " + angle;
            else
                return "разностранен и " + angle;
        }
        private string GetTypeAngle()
        {
            double[] sides = new double[3] { Aheigth, Bwidth, C };
            sides = sides
            .OrderByDescending(o => o)
            .ToArray();
            if (Math.Pow(sides[2], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[0], 2))
                return "правоъгълен";
            else if (Math.Pow(sides[2], 2) + Math.Pow(sides[1], 2) > Math.Pow(sides[0], 2))
                return "остроъгълен";
            else
                return "тъпоъгълен";
        }
    }
}
     