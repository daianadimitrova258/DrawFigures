using System;
using System.Drawing;


namespace DrawFigures.Figures
{
    class InvalidValueException: Exception
    {
        public InvalidValueException(string message)
            :base(message)
        {
        }
    }
    [Serializable]
    public abstract class Shape
    {
        public Point Location { get; set; }

        private float heigth;
        public float Aheigth
        {
            get { return this.heigth; }
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("Стойностите трябва да са положителни числа и различни от нула!");
                else
                    this.heigth = value;
            }
        }
        private float width;
        public float Bwidth
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("Стойностите трябва да са положителни числа и различни от нула!");
                else
                    this.width = value;
            }
        }
        private float c;
        public float C
        {
            get { return this.c; }
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("Стойностите трябва да са положителни числа и различни от нула!");
                else
                    this.c = value;
            }

        }
        [NonSerialized]
        private Color color;
        public Color Color
        {
            get { return color; }
            set { color = value; }
        } 

        public Color ConstColoring { get; set; }

        public int Order { get; set; }

        public Shape(Point Location, float Aheigth, float Bwidth, Color Color)
        {
            this.Location = Location;
            this.Aheigth = Aheigth;
            this.Bwidth = Bwidth;
            this.Color = Color;
        }
        protected Shape() { }
        public abstract void Paint(Graphics graphics);

        public virtual bool Contain(Point point)
        {
            return Location.X - Bwidth / 2 < point.X &&
                Location.Y - Aheigth / 2 < point.Y &&
                Location.X - Bwidth / 2 + Bwidth > point.X &&
                Location.Y - Aheigth / 2 + Aheigth > point.Y;
        }
        public virtual bool IsItOverllap(Shape fig1, Shape fig2)
        {
            return (fig2.Location.X - Bwidth/2 < fig1.Location.X + fig1.Bwidth) &&
                (fig1.Location.X < fig2.Location.X - Bwidth/2 + fig2.Bwidth) &&
                (fig2.Location.Y - Aheigth/2< fig1.Location.Y + fig1.Aheigth) &&
                (fig1.Location.Y < fig2.Location.Y - Aheigth/2 + fig2.Aheigth);
        } 
        public abstract double CalculateArea();
        public abstract double CalculateCircum();
        public abstract string GetTypeSide();
    }
}
