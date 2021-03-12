using System;
using DrawFigures.Figures;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = DrawFigures.Figures.Rectangle;

namespace DrawFigures
{
    public partial class FormRectangle : Form
    {
        public static Color buttonCollor;
        public static FormRectangle formrectangle;
        public FormRectangle()
        {
            InitializeComponent();
            formrectangle = this;
        }
        public static float el1 { get; private set; }
        public static float el2 { get; private set; }
        public void WriteLog(string log1, string log2)
        {
            var x = this.Handle;
            this.Invoke(new Action(() => { textBoxHeigth.Text += log1; }));
            this.Invoke(new Action(() => { textBoxWidth.Text += log2; }));
        }

        private void buttonFillR_Click(object sender, EventArgs e)
        {
            if (colorDialogRectangle.ShowDialog() == DialogResult.OK)
            {
                while (colorDialogRectangle.Color == Color.Gray)
                {
                    MessageBox.Show("Color cannot be this gray, because this is the color for marking! Choose another one, please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorDialogRectangle.ShowDialog();
                }
                buttonFillR.BackColor = colorDialogRectangle.Color;
                buttonFillR.ForeColor = colorDialogRectangle.Color;
                buttonCollor = colorDialogRectangle.Color;
            }
        }

        private void buttonPaintR_Click(object sender, EventArgs e)
        {
            if (textBoxHeigth.Text == "" || textBoxWidth.Text == "")
                return;
            else
            {
                el1 = float.Parse(textBoxHeigth.Text);
                el2 = float.Parse(textBoxWidth.Text);
            }

            if (el1 <= 0 || el2 <= 0)
                MessageBox.Show("Values must be positive numbers and non-zero! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (el1 > 300 || el2 > 300)
                MessageBox.Show("Values must be less than 300! Try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Hide();
                DialogResult = DialogResult.OK;
            }
        } 

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxHeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormRectangle_Load(object sender, EventArgs e)
        {

        }
    }
}
