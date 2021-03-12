namespace DrawFigures
{
    partial class FormEllipse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRadius1 = new System.Windows.Forms.TextBox();
            this.textBoxRadius2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFillE = new System.Windows.Forms.Button();
            this.buttonPaintE = new System.Windows.Forms.Button();
            this.colorDialogEllipse = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи размери за двата радиуса: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "r1 = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "r2 = ";
            // 
            // textBoxRadius1
            // 
            this.textBoxRadius1.Location = new System.Drawing.Point(60, 70);
            this.textBoxRadius1.Name = "textBoxRadius1";
            this.textBoxRadius1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadius1.TabIndex = 3;
            this.textBoxRadius1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRadius1_KeyPress);
            // 
            // textBoxRadius2
            // 
            this.textBoxRadius2.Location = new System.Drawing.Point(60, 101);
            this.textBoxRadius2.Name = "textBoxRadius2";
            this.textBoxRadius2.Size = new System.Drawing.Size(101, 20);
            this.textBoxRadius2.TabIndex = 4;
            this.textBoxRadius2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRadius2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Избери цвят  --->";
            // 
            // buttonFillE
            // 
            this.buttonFillE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFillE.Location = new System.Drawing.Point(154, 145);
            this.buttonFillE.Name = "buttonFillE";
            this.buttonFillE.Size = new System.Drawing.Size(87, 29);
            this.buttonFillE.TabIndex = 7;
            this.buttonFillE.Text = "Цветове";
            this.buttonFillE.UseVisualStyleBackColor = true;
            this.buttonFillE.Click += new System.EventHandler(this.buttonFillE_Click);
            // 
            // buttonPaintE
            // 
            this.buttonPaintE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaintE.Location = new System.Drawing.Point(154, 192);
            this.buttonPaintE.Name = "buttonPaintE";
            this.buttonPaintE.Size = new System.Drawing.Size(87, 29);
            this.buttonPaintE.TabIndex = 8;
            this.buttonPaintE.Text = "Изрисувай";
            this.buttonPaintE.UseVisualStyleBackColor = true;
            this.buttonPaintE.Click += new System.EventHandler(this.buttonPaintE_Click);
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(244, 233);
            this.Controls.Add(this.buttonPaintE);
            this.Controls.Add(this.buttonFillE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRadius2);
            this.Controls.Add(this.textBoxRadius1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEllipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Елипса";
            this.Load += new System.EventHandler(this.FormEllipse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRadius1;
        private System.Windows.Forms.TextBox textBoxRadius2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFillE;
        private System.Windows.Forms.Button buttonPaintE;
        private System.Windows.Forms.ColorDialog colorDialogEllipse;
    }
}