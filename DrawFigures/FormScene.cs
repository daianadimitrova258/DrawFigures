using DrawFigures.Figures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class FormScene : Form
    {
        private bool _tracingMouse = false;
        private Point _mousedownLocation;
        private List<Shape> _figures = new List<Shape>();
        private List<Shape> _Selectedfigure = new List<Shape>();
        private double Area;

        public FormScene()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        private void buttonToFigures_Click(object sender, EventArgs e)
        {
            new FormFigure().Show();
        }

        private void AreaAtAll()
        {
            Area = _figures
                .Select(s => s.CalculateArea())
                .Sum();
            toolStripStatusLabelArea.Text = "Общо лице: " + Math.Round(Area, 2);
        }

        private void OrderFigure_Avg()
        {
            listBoxAvgAreaEach.Items.Clear();
            listBoxAvgCircumEach.Items.Clear();
            listBoxArea.Items.Clear();
            listBoxCircum.Items.Clear();

            var average = _figures
                .GroupBy(x => x.GetType())
                .Select(x => new
                {
                    Type = x.Key.Name,
                    AverageAreaEach = x.Average(y => y.CalculateArea()),
                    AverageCircumEach = x.Average(y => y.CalculateCircum())
                })
                .ToList();
            foreach (var fig in average)
            {
                listBoxAvgAreaEach.Items.Add(fig.Type + " - " + Math.Round(fig.AverageAreaEach, 2));
                listBoxAvgCircumEach.Items.Add(fig.Type + " - " + Math.Round(fig.AverageCircumEach, 2));
            } 

            var OrderedFiguresByArea = _figures
                .Select((s, i) => new
                {
                    Index = i,
                    s.GetType().Name,
                    Area = s.CalculateArea(),
                    Circum = s.CalculateCircum()
                })
                    .OrderBy(o => o.Area)
                    .ToList();
            foreach (var fig in OrderedFiguresByArea)
                listBoxArea.Items.Add(fig.Index + 1 + ". " + fig.Name + " - " + fig.Area);

            var OrderedFiguresByCircum = OrderedFiguresByArea
                .OrderBy(o => o.Circum)
                .ToList();
            foreach (var fig in OrderedFiguresByCircum)
                listBoxCircum.Items.Add(fig.Index + 1 + "." + fig.Name + " - " + fig.Circum);

            if (OrderedFiguresByArea.Count != 0 && OrderedFiguresByCircum.Count != 0)
            {
                var AvrArea = OrderedFiguresByArea
                    .Average(s => s.Area);
                textBoxAvgArea.Text = Math.Round(AvrArea, 2).ToString();

                var AvrCircum = OrderedFiguresByCircum
                    .Average(s => s.Circum);
                textBoxAvrCircum.Text = Math.Round(AvrCircum, 2).ToString();
            }
            else
            { 
                textBoxAvgArea.Text = "0";
                textBoxAvrCircum.Text = "0";
            }
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            _tracingMouse = true;
            _mousedownLocation = e.Location;

            var clickedfigure = e.Button == MouseButtons.Right
            ? _figures
            .OrderByDescending(o => o.Order)
            .Where(shape => shape.Contain(e.Location))
            .LastOrDefault()
            : null;

            foreach (var figure in _figures)
                if (_Selectedfigure.Count == 0)
                    figure.Color = figure.ConstColoring;

            foreach (var selectedfigure in _Selectedfigure)
                selectedfigure.Color = selectedfigure.ConstColoring;

            _Selectedfigure.Clear();

            if (clickedfigure != null)
            {
                textBoxCircum.Text = clickedfigure.CalculateCircum().ToString();
                textBoxArea.Text = clickedfigure.CalculateArea().ToString();
                textBoxSide.Text = clickedfigure.GetTypeSide();

                clickedfigure.Color = Color.Gray;
                _Selectedfigure.Add(clickedfigure);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_figures != null)
            {
                foreach (Shape figure in _figures)
                {
                    figure.Paint(e.Graphics);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_Selectedfigure.Count == 0)
                MessageBox.Show("There is no selected figure!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                for (int i = 0; i < _Selectedfigure.Count; i++)
                {
                    _figures.Remove(_Selectedfigure[i]);
                    textBoxCircum.Text = "0";
                    textBoxArea.Text = "0";
                    textBoxSide.Text = "";
                }

            _Selectedfigure.Clear();
            OrderFigure_Avg();
            AreaAtAll();
            Invalidate();
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            _tracingMouse = false;
            if (e.Button == MouseButtons.Left)
            {
                _Selectedfigure = _figures
                    .Where(c => c.Color == Color.Gray)
                    .ToList();
            }
            Invalidate();
        }

        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_tracingMouse)
                return;
            else if (e.Button == MouseButtons.Left)
            {
                var w = Math.Abs(e.Location.X - _mousedownLocation.X);
                var h = Math.Abs(e.Location.Y - _mousedownLocation.Y);

                if (w > 0 && h > 0)
                {
                    var a = Math.Min(e.Location.X, _mousedownLocation.X);
                    var b = Math.Min(e.Location.Y, _mousedownLocation.Y);
                    var selecter = new Selecter();
                    selecter.Location = new Point(a, b);
                    selecter.Bwidth = w;
                    selecter.Aheigth = h;

                    foreach (var figure in _figures)
                        figure.Color = figure.IsItOverllap(selecter, figure) ? Color.Gray : figure.ConstColoring;

                    Invalidate();
                    Application.DoEvents();

                    using (var graphics = CreateGraphics())
                        selecter.Paint(graphics);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (var figure in _Selectedfigure)
                {
                    figure.Location = new Point(e.X - _mousedownLocation.X + figure.Location.X, e.Y - _mousedownLocation.Y + figure.Location.Y);
                    _mousedownLocation = e.Location;
                    Invalidate();
                }
            }
        }

        private void FormScene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var graphics = CreateGraphics();
            if (e.Button == MouseButtons.Right)
            {
                switch (FormFigure.Figure)
                {
                    case 1:
                        Shape rectangle = new Figures.Rectangle(e.Location, FormRectangle.el1, FormRectangle.el2, FormRectangle.buttonCollor);
                        rectangle.ConstColoring = FormRectangle.buttonCollor;
                        _figures.Add(rectangle);
                        break;
                    case 2:
                        Shape square = new Square(e.Location, FormSquare.el1, FormSquare.el1, FormSquare.buttonCollor);
                        square.ConstColoring = FormSquare.buttonCollor;
                        _figures.Add(square);
                        break;
                    case 3:
                        Shape cicrle = new Circle(e.Location, FormCircle.el1, FormCircle.el1, FormCircle.buttonCollor);
                        cicrle.ConstColoring = FormCircle.buttonCollor;
                        _figures.Add(cicrle);
                        break;
                    case 4:
                        Shape triangle = new Triangle(e.Location, FormTriangle.el1, FormTriangle.el2, FormTriangle.buttonCollor, FormTriangle.el3);
                        triangle.ConstColoring = FormTriangle.buttonCollor;
                        _figures.Add(triangle);
                        break;
                    case 5:
                        Shape ellipse = new Еllipse(e.Location, FormEllipse.el1, FormEllipse.el2, FormEllipse.buttonCollor);
                        ellipse.ConstColoring = FormEllipse.buttonCollor;
                        _figures.Add(ellipse);
                        break;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                var clickedfigure = _figures
                    .OrderByDescending(o => o.Order)
                    .Where(shape => shape.Contain(e.Location))
                    .LastOrDefault();
                if (clickedfigure != null)
                {
                    if (clickedfigure.GetType() == typeof(Figures.Rectangle))
                    {
                        FormRectangle formRectangle = new FormRectangle();
                        FormRectangle.formrectangle.WriteLog(clickedfigure.Aheigth.ToString(), clickedfigure.Bwidth.ToString());
                        if (formRectangle.ShowDialog() == DialogResult.OK)
                        {
                            clickedfigure.Aheigth = FormRectangle.el1;
                            clickedfigure.Bwidth = FormRectangle.el2;
                            clickedfigure.Color = FormRectangle.buttonCollor;
                            clickedfigure.ConstColoring = FormRectangle.buttonCollor;
                        }
                    }
                    else if (clickedfigure.GetType() == typeof(Square))
                    {
                        FormSquare formSquare = new FormSquare();
                        FormSquare.formsquare.WriteLog(clickedfigure.Aheigth.ToString());
                       
                        if (formSquare.ShowDialog() == DialogResult.OK)
                        {
                            clickedfigure.Aheigth = FormSquare.el1;
                            clickedfigure.Bwidth = FormSquare.el1;
                            clickedfigure.Color = FormSquare.buttonCollor;
                            clickedfigure.ConstColoring = FormSquare.buttonCollor;
                        }
                    }
                    else if (clickedfigure.GetType() == typeof(Circle))
                    {
                        FormCircle formCircle = new FormCircle();
                        FormCircle.formcircle.WriteLog(clickedfigure.Aheigth.ToString());
                        if (formCircle.ShowDialog() == DialogResult.OK)
                        {
                            clickedfigure.Aheigth = FormCircle.el1;
                            clickedfigure.Color = FormCircle.buttonCollor;
                            clickedfigure.ConstColoring = FormCircle.buttonCollor;
                        }
                    }
                    else if (clickedfigure.GetType() == typeof(Triangle))
                    {
                        FormTriangle formTriangle = new FormTriangle();
                        FormTriangle.formtriangle.WriteLog(clickedfigure.Aheigth.ToString(), clickedfigure.Bwidth.ToString(), clickedfigure.C.ToString()); ;
                        if (formTriangle.ShowDialog() == DialogResult.OK)
                        {
                            clickedfigure.Aheigth = FormTriangle.el1;
                            clickedfigure.Bwidth = FormTriangle.el2;
                            clickedfigure.C = FormTriangle.el3;
                            clickedfigure.Color = FormTriangle.buttonCollor;
                            clickedfigure.ConstColoring = FormTriangle.buttonCollor;
                        }
                    }
                    else if (clickedfigure.GetType() == typeof(Еllipse))
                    {
                        FormEllipse formEllipse = new FormEllipse();
                        FormEllipse.formellipse.WriteLog(clickedfigure.Aheigth.ToString(), clickedfigure.Bwidth.ToString());
                        if (formEllipse.ShowDialog() == DialogResult.OK)
                        {
                            clickedfigure.Aheigth = FormEllipse.el1;
                            clickedfigure.Bwidth = FormEllipse.el2;
                            clickedfigure.Color = FormEllipse.buttonCollor;
                            clickedfigure.ConstColoring = FormEllipse.buttonCollor;
                        }
                    }
                }
            }
            foreach (var figure in _figures)
            {
                figure.Paint(graphics);
                textBoxCircum.Text = figure.CalculateCircum().ToString();
                textBoxArea.Text = figure.CalculateArea().ToString();
                textBoxSide.Text = figure.GetTypeSide();
                OrderFigure_Avg();
                AreaAtAll();
            }
            Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _figures.Count; i++)
            {
                _figures.Remove(_figures[i]);
                textBoxCircum.Text = "0";
                textBoxArea.Text = "0";
                textBoxSide.Text = "";
            }
            _figures.Clear();
            OrderFigure_Avg();
            AreaAtAll();
            Invalidate();
        }

        private void FormScene_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Искате ли да отворите съществуващ файл?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var formatter = new BinaryFormatter();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    using (var file = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        _figures = (List<Shape>)formatter.Deserialize(file);
                else
                    return;
                foreach (var figure in _figures)
                    if (_Selectedfigure.Count == 0)
                        figure.Color = figure.ConstColoring;
                OrderFigure_Avg();
                AreaAtAll();
            }
            else
                return;
        }
        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_figures.Count == 0)
                return;
            DialogResult dr = MessageBox.Show("Искате ли да запазите фигурите във файл?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var formatter = new BinaryFormatter();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    using (var file = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        formatter.Serialize(file, _figures);
            }
            else if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }
    } 
}
