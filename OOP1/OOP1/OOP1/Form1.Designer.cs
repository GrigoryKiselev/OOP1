namespace OOP1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.Undo = new System.Windows.Forms.Button();
            this.gbFigures = new System.Windows.Forms.GroupBox();
            this.rbRhombus = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.Redo = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbPentagon = new System.Windows.Forms.RadioButton();
            this.rbStar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gbFigures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(95, 50);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(736, 488);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(676, 21);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 1;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbFigures
            // 
            this.gbFigures.Controls.Add(this.rbStar);
            this.gbFigures.Controls.Add(this.rbPentagon);
            this.gbFigures.Controls.Add(this.rbRhombus);
            this.gbFigures.Controls.Add(this.rbTriangle);
            this.gbFigures.Controls.Add(this.rbLine);
            this.gbFigures.Controls.Add(this.rbEllipse);
            this.gbFigures.Controls.Add(this.rbRectangle);
            this.gbFigures.Location = new System.Drawing.Point(95, 12);
            this.gbFigures.Name = "gbFigures";
            this.gbFigures.Size = new System.Drawing.Size(575, 38);
            this.gbFigures.TabIndex = 2;
            this.gbFigures.TabStop = false;
            this.gbFigures.Text = "Figures";
            // 
            // rbRhombus
            // 
            this.rbRhombus.AutoSize = true;
            this.rbRhombus.Location = new System.Drawing.Point(171, 16);
            this.rbRhombus.Name = "rbRhombus";
            this.rbRhombus.Size = new System.Drawing.Size(70, 17);
            this.rbRhombus.TabIndex = 4;
            this.rbRhombus.TabStop = true;
            this.rbRhombus.Text = "Rhombus";
            this.rbRhombus.UseVisualStyleBackColor = true;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(102, 16);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbTriangle.TabIndex = 3;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(308, 16);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(247, 16);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 1;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Checked = true;
            this.rbRectangle.Location = new System.Drawing.Point(22, 16);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(757, 21);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(75, 23);
            this.Redo.TabIndex = 3;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(0, 117);
            this.tbWidth.Maximum = 100;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(89, 45);
            this.tbWidth.TabIndex = 4;
            this.tbWidth.Value = 1;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(12, 301);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(75, 23);
            this.btnChooseColor.TabIndex = 5;
            this.btnChooseColor.Text = "Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rbPentagon
            // 
            this.rbPentagon.AutoSize = true;
            this.rbPentagon.Location = new System.Drawing.Point(359, 16);
            this.rbPentagon.Name = "rbPentagon";
            this.rbPentagon.Size = new System.Drawing.Size(71, 17);
            this.rbPentagon.TabIndex = 7;
            this.rbPentagon.TabStop = true;
            this.rbPentagon.Text = "Pentagon";
            this.rbPentagon.UseVisualStyleBackColor = true;
            // 
            // rbStar
            // 
            this.rbStar.AutoSize = true;
            this.rbStar.Location = new System.Drawing.Point(436, 16);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(44, 17);
            this.rbStar.TabIndex = 8;
            this.rbStar.TabStop = true;
            this.rbStar.Text = "Star";
            this.rbStar.UseVisualStyleBackColor = true;
            this.rbStar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.gbFigures);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gbFigures.ResumeLayout(false);
            this.gbFigures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.GroupBox gbFigures;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRhombus;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbPentagon;
        private System.Windows.Forms.RadioButton rbStar;
    }
}

