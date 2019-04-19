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
            this.gbFigures = new System.Windows.Forms.GroupBox();
            this.rbPencil = new System.Windows.Forms.RadioButton();
            this.rbPentagon = new System.Windows.Forms.RadioButton();
            this.rbRhombus = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.btnRedo = new System.Windows.Forms.Button();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.btnUndo = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.gbFigures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFigures
            // 
            this.gbFigures.Controls.Add(this.rbPencil);
            this.gbFigures.Controls.Add(this.rbStar);
            this.gbFigures.Controls.Add(this.rbPentagon);
            this.gbFigures.Controls.Add(this.rbRhombus);
            this.gbFigures.Controls.Add(this.rbTriangle);
            this.gbFigures.Controls.Add(this.rbLine);
            this.gbFigures.Controls.Add(this.rbEllipse);
            this.gbFigures.Controls.Add(this.rbRectangle);
            this.gbFigures.Location = new System.Drawing.Point(21, 21);
            this.gbFigures.Name = "gbFigures";
            this.gbFigures.Size = new System.Drawing.Size(107, 284);
            this.gbFigures.TabIndex = 2;
            this.gbFigures.TabStop = false;
            this.gbFigures.Text = "Figures";
            // 
            // rbPencil
            // 
            this.rbPencil.AutoSize = true;
            this.rbPencil.Location = new System.Drawing.Point(21, 255);
            this.rbPencil.Name = "rbPencil";
            this.rbPencil.Size = new System.Drawing.Size(54, 17);
            this.rbPencil.TabIndex = 9;
            this.rbPencil.TabStop = true;
            this.rbPencil.Text = "Pencil";
            this.rbPencil.UseVisualStyleBackColor = true;
            // 
            // rbPentagon
            // 
            this.rbPentagon.AutoSize = true;
            this.rbPentagon.Location = new System.Drawing.Point(22, 176);
            this.rbPentagon.Name = "rbPentagon";
            this.rbPentagon.Size = new System.Drawing.Size(71, 17);
            this.rbPentagon.TabIndex = 7;
            this.rbPentagon.TabStop = true;
            this.rbPentagon.Text = "Pentagon";
            this.rbPentagon.UseVisualStyleBackColor = true;
            // 
            // rbRhombus
            // 
            this.rbRhombus.AutoSize = true;
            this.rbRhombus.Location = new System.Drawing.Point(22, 76);
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
            this.rbTriangle.Location = new System.Drawing.Point(22, 44);
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
            this.rbLine.Location = new System.Drawing.Point(22, 141);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(22, 105);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 1;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(21, 343);
            this.tbWidth.Maximum = 40;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(107, 45);
            this.tbWidth.TabIndex = 4;
            this.tbWidth.TickFrequency = 3;
            this.tbWidth.Value = 1;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Location = new System.Drawing.Point(36, 412);
            this.cbShift.Name = "cbShift";
            this.cbShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbShift.Size = new System.Drawing.Size(47, 17);
            this.cbShift.TabIndex = 7;
            this.cbShift.TabStop = false;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(29, 327);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(69, 13);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Pen width : 1";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(67, 383);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(46, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(37, 388);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Checked = true;
            this.rbRectangle.Location = new System.Drawing.Point(21, 18);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.OldLace;
            this.btnRedo.Image = global::OOP1.Properties.Resources.Redo50;
            this.btnRedo.Location = new System.Drawing.Point(84, 445);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(54, 55);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // rbStar
            // 
            this.rbStar.AutoSize = true;
            this.rbStar.Image = global::OOP1.Properties.Resources.Star50;
            this.rbStar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbStar.Location = new System.Drawing.Point(21, 199);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(64, 50);
            this.rbStar.TabIndex = 8;
            this.rbStar.TabStop = true;
            this.rbStar.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.OldLace;
            this.btnUndo.Image = global::OOP1.Properties.Resources.Undo50;
            this.btnUndo.Location = new System.Drawing.Point(21, 445);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(57, 55);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(144, 21);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(828, 488);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.gbFigures);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kiselev_Paint";
            this.gbFigures.ResumeLayout(false);
            this.gbFigures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox gbFigures;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRhombus;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.RadioButton rbPentagon;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.RadioButton rbPencil;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
    }
}

