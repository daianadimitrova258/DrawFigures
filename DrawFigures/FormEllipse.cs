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
    public partial class FormEllipse : Form
    {        
        public static Color buttonCollor;
        public static FormEllipse formellipse;
        public FormEllipse()
        {
            InitializeComponent();
            formellipse = this;
        }
        public static float el1 { get; private set; }
        public static float el2 { get; private set; }
        public void WriteLog(string log1, string log2)
        {
            var x = this.Handle;
            this.Invoke(new Action(() => { textBoxRadius1.Text += log1; })); 
            this.Invoke(new Action(() => { textBoxRadius2.Text += log2; }));
        }

        private void buttonFillE_Click(object sender, EventArgs e)
        {
            if (colorDialogEllipse.ShowDialog() == DialogResult.OK)
            {
                while (colorDialogEllipse.Color == Color.Gray)
                {
                    MessageBox.Show("Color cannot be this gray, because this is the color for marking! Choose another one, please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorDialogEllipse.ShowDialog();
                }
                buttonFillE.BackColor = colorDialogEllipse.Color;
                buttonFillE.ForeColor = colorDialogEllipse.Color;
                buttonCollor = colorDialogEllipse.Color;
            }
        }

        private void buttonPaintE_Click(object sender, EventArgs e)
        {
            if (textBoxRadius1.Text == "" || textBoxRadius2.Text == "")
                return;
            else
            {
                el1 = float.Parse(textBoxRadius1.Text);
                el2 = float.Parse(textBoxRadius2.Text);
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

        private void textBoxRadius1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxRadius2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
