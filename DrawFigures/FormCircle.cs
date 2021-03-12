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
    public partial class FormCircle : Form
    {        
        public static Color buttonCollor;
        public static FormCircle formcircle;
        public FormCircle()
        {
            InitializeComponent();
            formcircle = this;
        }
        public static float el1 { get; private set; }
        public void WriteLog(string log)
        {
            var x = this.Handle;
            this.Invoke(new Action(() => { textBoxRadius.Text += log; }));
        }
        private void buttonFillC_Click(object sender, EventArgs e)
        {
            if (colorDialogCircle.ShowDialog() == DialogResult.OK)
            {
                while (colorDialogCircle.Color == Color.Gray)
                {
                    MessageBox.Show("Color cannot be this gray, because this is the color for marking! Choose another one, please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorDialogCircle.ShowDialog();
                }
                buttonFillC.BackColor = colorDialogCircle.Color;
                buttonFillC.ForeColor = colorDialogCircle.Color;
                buttonCollor = colorDialogCircle.Color;
            }
        }
        private void buttonPaintC_Click(object sender, EventArgs e)
        {
            if (textBoxRadius.Text == "")
                return;
            else
                el1 = float.Parse(textBoxRadius.Text);

            if (el1 <= 0)
                MessageBox.Show("Values must be positive numbers and non-zero! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (el1 > 300)
                MessageBox.Show("Values must be less than 300! Try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Hide();
                DialogResult = DialogResult.OK;
            }
        }

        private void textBoxRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCircle_Load(object sender, EventArgs e)
        {

        }
    }
}
