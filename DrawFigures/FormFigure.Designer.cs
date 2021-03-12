namespace DrawFigures
{
    partial class FormFigure
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
            this.buttonToSizes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonToSizes
            // 
            this.buttonToSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToSizes.Location = new System.Drawing.Point(39, 186);
            this.buttonToSizes.Name = "buttonToSizes";
            this.buttonToSizes.Size = new System.Drawing.Size(168, 27);
            this.buttonToSizes.TabIndex = 4;
            this.buttonToSizes.Text = "Избери размер";
            this.buttonToSizes.UseVisualStyleBackColor = true;
            this.buttonToSizes.Click += new System.EventHandler(this.buttonToSizes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отбележи желаната фигура: ";
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRectangle.Location = new System.Drawing.Point(25, 54);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(121, 21);
            this.radioButtonRectangle.TabIndex = 7;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Правоъгълник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSquare.Location = new System.Drawing.Point(25, 139);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(81, 21);
            this.radioButtonSquare.TabIndex = 8;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Квадрат";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCircle.Location = new System.Drawing.Point(157, 54);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(57, 21);
            this.radioButtonCircle.TabIndex = 9;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Кръг";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTriangle.Location = new System.Drawing.Point(25, 97);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(105, 21);
            this.radioButtonTriangle.TabIndex = 10;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Триъгълник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEllipse.Location = new System.Drawing.Point(157, 97);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(74, 21);
            this.radioButtonEllipse.TabIndex = 11;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Елипса";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // FormFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(256, 228);
            this.Controls.Add(this.radioButtonEllipse);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.radioButtonCircle);
            this.Controls.Add(this.radioButtonSquare);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFigure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фигури";
            this.Load += new System.EventHandler(this.FormFigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToSizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
    }
}