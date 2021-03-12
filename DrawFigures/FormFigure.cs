using DrawFigures.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class FormFigure : Form
    {
        public FormFigure()
        {
            InitializeComponent();
        }
        public static int Figure { get; private set; }
        private void buttonToSizes_Click(object sender, EventArgs e)
        {

            if (radioButtonRectangle.Checked)
            {
                Figure = 1;
                new FormRectangle().Show();
            }
            else if (radioButtonSquare.Checked)
            {
                Figure = 2;
                new FormSquare().Show();
            }
            else if (radioButtonCircle.Checked)
            {
                Figure = 3;
                new FormCircle().Show();
            }
            else if (radioButtonTriangle.Checked)
            {
                Figure = 4;
                new FormTriangle().Show();
            }
            else if (radioButtonEllipse.Checked)
            {
                Figure = 5;
                new FormEllipse().Show();
            }
            else
            {
                MessageBox.Show("You have not marked a figure! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
        }
    

        private void FormFigure_Load(object sender, EventArgs e)
        {

        }
    }
}
