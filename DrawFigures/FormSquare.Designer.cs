namespace DrawFigures
{
    partial class FormSquare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPaintS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHeigthS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFillS = new System.Windows.Forms.Button();
            this.colorDialogSquare = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи размер за страната на квадрата:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPaintS
            // 
            this.buttonPaintS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaintS.Location = new System.Drawing.Point(157, 166);
            this.buttonPaintS.Name = "buttonPaintS";
            this.buttonPaintS.Size = new System.Drawing.Size(87, 29);
            this.buttonPaintS.TabIndex = 1;
            this.buttonPaintS.Text = "Изрисувай";
            this.buttonPaintS.UseVisualStyleBackColor = true;
            this.buttonPaintS.Click += new System.EventHandler(this.buttonPaintS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "А =";
            // 
            // textBoxHeigthS
            // 
            this.textBoxHeigthS.Location = new System.Drawing.Point(50, 71);
            this.textBoxHeigthS.Name = "textBoxHeigthS";
            this.textBoxHeigthS.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeigthS.TabIndex = 3;
            this.textBoxHeigthS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeigthS_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Избери цвят  --->";
            // 
            // buttonFillS
            // 
            this.buttonFillS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFillS.Location = new System.Drawing.Point(156, 119);
            this.buttonFillS.Name = "buttonFillS";
            this.buttonFillS.Size = new System.Drawing.Size(87, 29);
            this.buttonFillS.TabIndex = 5;
            this.buttonFillS.Text = "Цветове";
            this.buttonFillS.UseVisualStyleBackColor = true;
            this.buttonFillS.Click += new System.EventHandler(this.buttonFillS_Click);
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(262, 211);
            this.Controls.Add(this.buttonFillS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHeigthS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPaintS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квадрат";
            this.Load += new System.EventHandler(this.FormSquare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPaintS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHeigthS;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonFillS;
        private System.Windows.Forms.ColorDialog colorDialogSquare;
    }
}