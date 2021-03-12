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
    public partial class FormSquare : Form
    {
        public static Color buttonCollor;
        public static FormSquare formsquare;
        public FormSquare()
        {
            InitializeComponent();
            formsquare = this;
        }

        public static float el1 { get; private set; }

        public void WriteLog(string log)
        {
            var x = this.Handle;
            textBoxHeigthS.Text += log;
//            this.Invoke(new Action(() => { textBoxHeigthS.Text += log; }));
        }

        private void buttonFillS_Click(object sender, EventArgs e)
        {
            if (colorDialogSquare.ShowDialog() == DialogResult.OK)
            {
                while (colorDialogSquare.Color == Color.Gray)
                {
                    MessageBox.Show("Color cannot be this gray, because this is the color for marking! Choose another one, please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorDialogSquare.ShowDialog();
                }
                buttonFillS.BackColor = colorDialogSquare.Color;
                buttonFillS.ForeColor = colorDialogSquare.Color;
                buttonCollor = colorDialogSquare.Color;
            }
            
        }

        private void buttonPaintS_Click(object sender, EventArgs e)
        {
            if (textBoxHeigthS.Text == "")
                return;
            else           
                el1 = float.Parse(textBoxHeigthS.Text);

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

        private void textBoxHeigthS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if(!Char.IsDigit(num) && num != 8 && !num.Equals(','))
            {
                e.Handled = true;
                MessageBox.Show("Try again! Only numbers are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSquare_Load(object sender, EventArgs e)
        {

        }
    }
}
