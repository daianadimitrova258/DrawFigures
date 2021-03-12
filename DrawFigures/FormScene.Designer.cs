namespace DrawFigures
{
    partial class FormScene
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
            this.components = new System.ComponentModel.Container();
            this.buttonToFigures = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxCircum = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.statusStripArea = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAvgArea = new System.Windows.Forms.TextBox();
            this.textBoxAvrCircum = new System.Windows.Forms.TextBox();
            this.listBoxArea = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBoxCircum = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAvgAreaEach = new System.Windows.Forms.ListBox();
            this.listBoxAvgCircumEach = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Периметър = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStripArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonToFigures
            // 
            this.buttonToFigures.Location = new System.Drawing.Point(163, 4);
            this.buttonToFigures.Name = "buttonToFigures";
            this.buttonToFigures.Size = new System.Drawing.Size(101, 27);
            this.buttonToFigures.TabIndex = 1;
            this.buttonToFigures.Text = "Избор на фигура";
            this.buttonToFigures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToFigures.UseVisualStyleBackColor = true;
            this.buttonToFigures.Click += new System.EventHandler(this.buttonToFigures_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лице";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обиколка";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(11, 28);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 4;
            this.textBoxArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCircum
            // 
            this.textBoxCircum.Location = new System.Drawing.Point(11, 78);
            this.textBoxCircum.Name = "textBoxCircum";
            this.textBoxCircum.ReadOnly = true;
            this.textBoxCircum.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircum.TabIndex = 5;
            this.textBoxCircum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(83, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 27);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // statusStripArea
            // 
            this.statusStripArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelArea});
            this.statusStripArea.Location = new System.Drawing.Point(0, 428);
            this.statusStripArea.Name = "statusStripArea";
            this.statusStripArea.Size = new System.Drawing.Size(927, 22);
            this.statusStripArea.TabIndex = 7;
            this.statusStripArea.Text = "statusStrip1";
            // 
            // toolStripStatusLabelArea
            // 
            this.toolStripStatusLabelArea.Name = "toolStripStatusLabelArea";
            this.toolStripStatusLabelArea.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabelArea.Text = "Общо лице: ";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(2, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 27);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxSide);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxArea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxAvgArea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxAvrCircum);
            this.panel1.Controls.Add(this.textBoxCircum);
            this.panel1.Location = new System.Drawing.Point(656, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 376);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Об. ср. обиколка";
            // 
            // textBoxSide
            // 
            this.textBoxSide.Location = new System.Drawing.Point(13, 168);
            this.textBoxSide.Multiline = true;
            this.textBoxSide.Name = "textBoxSide";
            this.textBoxSide.ReadOnly = true;
            this.textBoxSide.Size = new System.Drawing.Size(100, 37);
            this.textBoxSide.TabIndex = 7;
            this.textBoxSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Спецификация: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Об. ср. лице";
            // 
            // textBoxAvgArea
            // 
            this.textBoxAvgArea.Location = new System.Drawing.Point(13, 274);
            this.textBoxAvgArea.Name = "textBoxAvgArea";
            this.textBoxAvgArea.ReadOnly = true;
            this.textBoxAvgArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvgArea.TabIndex = 15;
            this.textBoxAvgArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAvrCircum
            // 
            this.textBoxAvrCircum.Location = new System.Drawing.Point(13, 326);
            this.textBoxAvrCircum.Name = "textBoxAvrCircum";
            this.textBoxAvrCircum.ReadOnly = true;
            this.textBoxAvrCircum.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvrCircum.TabIndex = 14;
            this.textBoxAvrCircum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxArea
            // 
            this.listBoxArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxArea.FormattingEnabled = true;
            this.listBoxArea.Location = new System.Drawing.Point(6, 19);
            this.listBoxArea.Name = "listBoxArea";
            this.listBoxArea.Size = new System.Drawing.Size(120, 82);
            this.listBoxArea.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonToFigures);
            this.panel2.Location = new System.Drawing.Point(656, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 34);
            this.panel2.TabIndex = 10;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "*.cs|*.cs";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.cs|*.cs";
            // 
            // listBoxCircum
            // 
            this.listBoxCircum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxCircum.FormattingEnabled = true;
            this.listBoxCircum.Location = new System.Drawing.Point(5, 16);
            this.listBoxCircum.Name = "listBoxCircum";
            this.listBoxCircum.Size = new System.Drawing.Size(120, 82);
            this.listBoxCircum.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.listBoxAvgAreaEach);
            this.panel3.Controls.Add(this.listBoxArea);
            this.panel3.Location = new System.Drawing.Point(790, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 185);
            this.panel3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ср. стойност";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Лице";
            // 
            // listBoxAvgAreaEach
            // 
            this.listBoxAvgAreaEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxAvgAreaEach.FormattingEnabled = true;
            this.listBoxAvgAreaEach.Location = new System.Drawing.Point(5, 126);
            this.listBoxAvgAreaEach.Name = "listBoxAvgAreaEach";
            this.listBoxAvgAreaEach.Size = new System.Drawing.Size(120, 56);
            this.listBoxAvgAreaEach.TabIndex = 18;
            // 
            // listBoxAvgCircumEach
            // 
            this.listBoxAvgCircumEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxAvgCircumEach.FormattingEnabled = true;
            this.listBoxAvgCircumEach.Location = new System.Drawing.Point(5, 126);
            this.listBoxAvgCircumEach.Name = "listBoxAvgCircumEach";
            this.listBoxAvgCircumEach.Size = new System.Drawing.Size(120, 56);
            this.listBoxAvgCircumEach.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Периметър);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.listBoxCircum);
            this.panel4.Controls.Add(this.listBoxAvgCircumEach);
            this.panel4.Location = new System.Drawing.Point(790, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 185);
            this.panel4.TabIndex = 14;
            // 
            // Периметър
            // 
            this.Периметър.AutoSize = true;
            this.Периметър.Location = new System.Drawing.Point(32, 1);
            this.Периметър.Name = "Периметър";
            this.Периметър.Size = new System.Drawing.Size(65, 13);
            this.Периметър.TabIndex = 20;
            this.Периметър.Text = "Периметър";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ср. стойност";
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сцена";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.statusStripArea.ResumeLayout(false);
            this.statusStripArea.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToFigures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxCircum;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.StatusStrip statusStripArea;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArea;
        private System.Windows.Forms.Button buttonClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBoxArea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBoxCircum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxAvrCircum;
        private System.Windows.Forms.TextBox textBoxAvgArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAvgAreaEach;
        private System.Windows.Forms.ListBox listBoxAvgCircumEach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Периметър;
        private System.Windows.Forms.Label label6;
    }
}

