namespace OOP1
{
    partial class Form_Kiselev_Paint
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
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.rbPentagon = new System.Windows.Forms.RadioButton();
            this.rbRhombus = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnChange = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.rbCursor = new System.Windows.Forms.RadioButton();
            this.rbFigure = new System.Windows.Forms.RadioButton();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbPenWidth = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblPenW = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.Button();
            this.lblFigureList = new System.Windows.Forms.Label();
            this.cmbbShapes = new System.Windows.Forms.ComboBox();
            this.gbFigures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gbTools.SuspendLayout();
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
            this.gbFigures.TabIndex = 0;
            this.gbFigures.TabStop = false;
            this.gbFigures.Text = "Figures";
            // 
            // rbPencil
            // 
            this.rbPencil.AutoSize = true;
            this.rbPencil.Location = new System.Drawing.Point(21, 249);
            this.rbPencil.Name = "rbPencil";
            this.rbPencil.Size = new System.Drawing.Size(54, 17);
            this.rbPencil.TabIndex = 7;
            this.rbPencil.TabStop = true;
            this.rbPencil.Text = "Pencil";
            this.rbPencil.UseVisualStyleBackColor = true;
            // 
            // rbStar
            // 
            this.rbStar.AutoSize = true;
            this.rbStar.Image = global::OOP1.Properties.Resources.Star50;
            this.rbStar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbStar.Location = new System.Drawing.Point(22, 160);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(64, 50);
            this.rbStar.TabIndex = 5;
            this.rbStar.TabStop = true;
            this.rbStar.UseVisualStyleBackColor = true;
            // 
            // rbPentagon
            // 
            this.rbPentagon.AutoSize = true;
            this.rbPentagon.Location = new System.Drawing.Point(21, 137);
            this.rbPentagon.Name = "rbPentagon";
            this.rbPentagon.Size = new System.Drawing.Size(71, 17);
            this.rbPentagon.TabIndex = 4;
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
            this.rbRhombus.TabIndex = 2;
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
            this.rbTriangle.TabIndex = 1;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(21, 216);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 6;
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
            this.rbEllipse.TabIndex = 3;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.CheckedChanged += new System.EventHandler(this.rbEllipse_CheckedChanged);
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
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(837, 408);
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
            this.cbShift.Location = new System.Drawing.Point(852, 477);
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
            this.lblWidth.Location = new System.Drawing.Point(845, 392);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(69, 13);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Pen width : 1";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(883, 448);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(46, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(853, 453);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.OldLace;
            this.btnRedo.Image = global::OOP1.Properties.Resources.Redo50;
            this.btnRedo.Location = new System.Drawing.Point(78, 420);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(54, 55);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.OldLace;
            this.btnUndo.Image = global::OOP1.Properties.Resources.Undo50;
            this.btnUndo.Location = new System.Drawing.Point(15, 420);
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
            this.picture.Location = new System.Drawing.Point(146, 65);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(673, 488);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(78, 485);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(870, 173);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.rbCursor);
            this.gbTools.Controls.Add(this.rbFigure);
            this.gbTools.Location = new System.Drawing.Point(21, 314);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(107, 82);
            this.gbTools.TabIndex = 14;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // rbCursor
            // 
            this.rbCursor.AutoSize = true;
            this.rbCursor.Location = new System.Drawing.Point(12, 42);
            this.rbCursor.Name = "rbCursor";
            this.rbCursor.Size = new System.Drawing.Size(60, 17);
            this.rbCursor.TabIndex = 1;
            this.rbCursor.Text = "Zalivka";
            this.rbCursor.UseVisualStyleBackColor = true;
            // 
            // rbFigure
            // 
            this.rbFigure.AutoSize = true;
            this.rbFigure.Checked = true;
            this.rbFigure.Location = new System.Drawing.Point(12, 19);
            this.rbFigure.Name = "rbFigure";
            this.rbFigure.Size = new System.Drawing.Size(54, 17);
            this.rbFigure.TabIndex = 0;
            this.rbFigure.TabStop = true;
            this.rbFigure.Text = "Figure";
            this.rbFigure.UseVisualStyleBackColor = true;
            // 
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.Location = new System.Drawing.Point(848, 216);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(97, 173);
            this.lbFigures.TabIndex = 15;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(883, 19);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(62, 20);
            this.tbX.TabIndex = 16;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(883, 45);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(62, 20);
            this.tbY.TabIndex = 17;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(883, 71);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(62, 20);
            this.tbW.TabIndex = 18;
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(883, 97);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(62, 20);
            this.tbH.TabIndex = 19;
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Location = new System.Drawing.Point(883, 147);
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.Size = new System.Drawing.Size(62, 20);
            this.tbPenWidth.TabIndex = 21;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(825, 22);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 22;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(825, 48);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 23;
            this.lblY.Text = "Y:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(825, 74);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(38, 13);
            this.lblW.TabIndex = 24;
            this.lblW.Text = "Width:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(825, 100);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(41, 13);
            this.lblH.TabIndex = 25;
            this.lblH.Text = "Height:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(825, 124);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(34, 13);
            this.lblCol.TabIndex = 26;
            this.lblCol.Text = "Color:";
            // 
            // lblPenW
            // 
            this.lblPenW.AutoSize = true;
            this.lblPenW.Location = new System.Drawing.Point(825, 150);
            this.lblPenW.Name = "lblPenW";
            this.lblPenW.Size = new System.Drawing.Size(57, 13);
            this.lblPenW.TabIndex = 27;
            this.lblPenW.Text = "Pen width:";
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.SystemColors.Info;
            this.tbColor.Location = new System.Drawing.Point(883, 121);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(62, 20);
            this.tbColor.TabIndex = 28;
            this.tbColor.UseVisualStyleBackColor = false;
            this.tbColor.Click += new System.EventHandler(this.tbColor_Click_1);
            // 
            // lblFigureList
            // 
            this.lblFigureList.AutoSize = true;
            this.lblFigureList.Location = new System.Drawing.Point(849, 200);
            this.lblFigureList.Name = "lblFigureList";
            this.lblFigureList.Size = new System.Drawing.Size(55, 13);
            this.lblFigureList.TabIndex = 29;
            this.lblFigureList.Text = "Figure List";
            // 
            // cmbbShapes
            // 
            this.cmbbShapes.FormattingEnabled = true;
            this.cmbbShapes.Location = new System.Drawing.Point(146, 18);
            this.cmbbShapes.Name = "cmbbShapes";
            this.cmbbShapes.Size = new System.Drawing.Size(163, 21);
            this.cmbbShapes.TabIndex = 30;
            // 
            // Form_Kiselev_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.cmbbShapes);
            this.Controls.Add(this.lblFigureList);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbPenWidth);
            this.Controls.Add(this.lblPenW);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbW);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbFigures);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gbFigures);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.picture);
            this.Name = "Form_Kiselev_Paint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kiselev_Paint";
            this.gbFigures.ResumeLayout(false);
            this.gbFigures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.RadioButton rbFigure;
        private System.Windows.Forms.RadioButton rbCursor;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbPenWidth;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblPenW;
        private System.Windows.Forms.Button tbColor;
        private System.Windows.Forms.Label lblFigureList;
        private System.Windows.Forms.ComboBox cmbbShapes;
    }
}

