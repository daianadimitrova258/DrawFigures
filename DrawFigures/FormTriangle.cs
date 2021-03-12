using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class FormTriangle : Form
    {
        public static Color buttonCollor;
        public static FormTriangle formtriangle;
        public FormTriangle()
        {
            InitializeComponent();
            formtriangle = this;
        }
        public static float el1 { get; private set; }
        public static float el2 { get; private set; }
        public static float el3 { get; private set; }
        public void WriteLog(string log1, string log2, string log3)
        {
            var x = this.Handle;
            this.Invoke(new Action(() => { textBoxA.Text += log1; }));
            this.Invoke(new Action(() => { textBoxB.Text += log2; }));
            this.Invoke(new Action(() => { textBoxC.Text += log3; }));
        }

        private void buttonFillT_Click(object sender, EventArgs e)
        {
            if (colorDialogTriangle.ShowDialog() == DialogResult.OK)
            {
                while (colorDialogTriangle.Color == Color.Gray)
                {
                    MessageBox.Show("Color cannot be this gray, because this is the color for marking! Choose another one, please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorDialogTriangle.ShowDialog();
                }
                buttonFillT.BackColor = colorDialogTriangle.Color;
                buttonFillT.ForeColor = colorDialogTriangle.Color;
                buttonCollor = colorDialogTriangle.Color;
            }
        }

        private void buttonPaintT_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxC.Text == "")
                return;
            else
            {
                el1 = float.Parse(textBoxA.Text);
                el2 = float.Parse(textBoxB.Text);
                el3 = float.Parse(textBoxC.Text);
            }

            if (el1 <= 0 || el2 <= 0 || el3 <= 0)
                MessageBox.Show("Values must be positive numbers and non-zero! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (el1 > 300 || el2 > 300 || el3 > 300)
                MessageBox.Show("Values must be less than 300! Try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (el1 + el2 <= el3 || el1 + el3 <= el2 || el2 + el3 <= el1)
                MessageBox.Show("Invalid values for triangle! Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                DialogResult = DialogResult.OK;
            }
        } 

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormTriangle_Load(object sender, EventArgs e)
        {

        }
    }
}
