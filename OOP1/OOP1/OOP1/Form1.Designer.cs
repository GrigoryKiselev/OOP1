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
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
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
            this.lblFigure = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gbTools.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(337, 37);
            this.tbWidth.Maximum = 40;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(95, 45);
            this.tbWidth.TabIndex = 4;
            this.tbWidth.TickFrequency = 3;
            this.tbWidth.Value = 1;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShift.Location = new System.Drawing.Point(276, 35);
            this.cbShift.Name = "cbShift";
            this.cbShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbShift.Size = new System.Drawing.Size(52, 20);
            this.cbShift.TabIndex = 7;
            this.cbShift.TabStop = false;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.Location = new System.Drawing.Point(343, 24);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(81, 16);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Pen width : 1";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(440, 40);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(46, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(442, 24);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 16);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.OldLace;
            this.btnRedo.Image = global::OOP1.Properties.Resources.Redo50;
            this.btnRedo.Location = new System.Drawing.Point(902, 456);
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
            this.btnUndo.Location = new System.Drawing.Point(836, 456);
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
            this.picture.Location = new System.Drawing.Point(15, 74);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(792, 437);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(833, 212);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(125, 27);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.rbCursor);
            this.gbTools.Controls.Add(this.rbFigure);
            this.gbTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTools.Location = new System.Drawing.Point(501, 24);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(187, 44);
            this.gbTools.TabIndex = 14;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // rbCursor
            // 
            this.rbCursor.AutoSize = true;
            this.rbCursor.Enabled = false;
            this.rbCursor.Location = new System.Drawing.Point(87, 19);
            this.rbCursor.Name = "rbCursor";
            this.rbCursor.Size = new System.Drawing.Size(78, 20);
            this.rbCursor.TabIndex = 1;
            this.rbCursor.Text = "FloodFill";
            this.rbCursor.UseVisualStyleBackColor = true;
            // 
            // rbFigure
            // 
            this.rbFigure.AutoSize = true;
            this.rbFigure.Checked = true;
            this.rbFigure.Location = new System.Drawing.Point(17, 19);
            this.rbFigure.Name = "rbFigure";
            this.rbFigure.Size = new System.Drawing.Size(64, 20);
            this.rbFigure.TabIndex = 0;
            this.rbFigure.TabStop = true;
            this.rbFigure.Text = "Figure";
            this.rbFigure.UseVisualStyleBackColor = true;
            // 
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.Location = new System.Drawing.Point(836, 277);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(120, 173);
            this.lbFigures.TabIndex = 15;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(896, 58);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(62, 20);
            this.tbX.TabIndex = 16;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(896, 84);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(62, 20);
            this.tbY.TabIndex = 17;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(896, 110);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(62, 20);
            this.tbW.TabIndex = 18;
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(896, 136);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(62, 20);
            this.tbH.TabIndex = 19;
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Location = new System.Drawing.Point(896, 186);
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.Size = new System.Drawing.Size(62, 20);
            this.tbPenWidth.TabIndex = 21;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(830, 61);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 16);
            this.lblX.TabIndex = 22;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.Location = new System.Drawing.Point(830, 87);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 16);
            this.lblY.TabIndex = 23;
            this.lblY.Text = "Y:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblW.Location = new System.Drawing.Point(830, 113);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(45, 16);
            this.lblW.TabIndex = 24;
            this.lblW.Text = "Width:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblH.Location = new System.Drawing.Point(830, 139);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(50, 16);
            this.lblH.TabIndex = 25;
            this.lblH.Text = "Height:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCol.Location = new System.Drawing.Point(830, 163);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(43, 16);
            this.lblCol.TabIndex = 26;
            this.lblCol.Text = "Color:";
            // 
            // lblPenW
            // 
            this.lblPenW.AutoSize = true;
            this.lblPenW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPenW.Location = new System.Drawing.Point(830, 189);
            this.lblPenW.Name = "lblPenW";
            this.lblPenW.Size = new System.Drawing.Size(68, 16);
            this.lblPenW.TabIndex = 27;
            this.lblPenW.Text = "Pen width:";
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.SystemColors.Info;
            this.tbColor.Location = new System.Drawing.Point(896, 160);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(62, 20);
            this.tbColor.TabIndex = 28;
            this.tbColor.UseVisualStyleBackColor = false;
            this.tbColor.Click += new System.EventHandler(this.tbColor_Click_1);
            // 
            // lblFigureList
            // 
            this.lblFigureList.AutoSize = true;
            this.lblFigureList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFigureList.Location = new System.Drawing.Point(837, 258);
            this.lblFigureList.Name = "lblFigureList";
            this.lblFigureList.Size = new System.Drawing.Size(80, 16);
            this.lblFigureList.TabIndex = 29;
            this.lblFigureList.Text = "Figure List";
            // 
            // cmbbShapes
            // 
            this.cmbbShapes.FormattingEnabled = true;
            this.cmbbShapes.Location = new System.Drawing.Point(88, 38);
            this.cmbbShapes.Name = "cmbbShapes";
            this.cmbbShapes.Size = new System.Drawing.Size(163, 21);
            this.cmbbShapes.TabIndex = 30;
            // 
            // lblFigure
            // 
            this.lblFigure.AutoSize = true;
            this.lblFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFigure.Location = new System.Drawing.Point(12, 35);
            this.lblFigure.Name = "lblFigure";
            this.lblFigure.Size = new System.Drawing.Size(70, 24);
            this.lblFigure.TabIndex = 31;
            this.lblFigure.Text = "Figure:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Open";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Save";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(829, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Edit Menu";
            // 
            // Form_Kiselev_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lblFigure);
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
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Kiselev_Paint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kiselev_Paint";
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
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
        private System.Windows.Forms.Label lblFigure;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label label1;
    }
}

