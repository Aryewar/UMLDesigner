namespace UMLDesigner
{
    partial class UMLDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UMLDesigner));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.radioButtonCursor = new System.Windows.Forms.RadioButton();
            this.radioButtonInheritanceArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonRealizationArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonAssociationArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonCompositionArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonAlternateCompositionArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonAgregationArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonAlternateAgregationArrow = new System.Windows.Forms.RadioButton();
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialogMain = new System.Windows.Forms.FontDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDiagramDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonStack = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(164, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1120, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CustomMouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomMouseUp);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 481);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(45, 40);
            this.colorButton.TabIndex = 6;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // widthBar
            // 
            this.widthBar.Location = new System.Drawing.Point(12, 564);
            this.widthBar.Maximum = 5;
            this.widthBar.Minimum = 1;
            this.widthBar.Name = "widthBar";
            this.widthBar.Size = new System.Drawing.Size(118, 45);
            this.widthBar.TabIndex = 7;
            this.widthBar.Value = 4;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // radioButtonCursor
            // 
            this.radioButtonCursor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCursor.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonCursor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCursor.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonCursor.Image")));
            this.radioButtonCursor.Location = new System.Drawing.Point(12, 50);
            this.radioButtonCursor.Name = "radioButtonCursor";
            this.radioButtonCursor.Size = new System.Drawing.Size(120, 25);
            this.radioButtonCursor.TabIndex = 17;
            this.radioButtonCursor.TabStop = true;
            this.radioButtonCursor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCursor.UseVisualStyleBackColor = true;
            this.radioButtonCursor.CheckedChanged += new System.EventHandler(this.radioButtonCursor_CheckedChanged);
            // 
            // radioButtonInheritanceArrow
            // 
            this.radioButtonInheritanceArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonInheritanceArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonInheritanceArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonInheritanceArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonInheritanceArrow.Image")));
            this.radioButtonInheritanceArrow.Location = new System.Drawing.Point(12, 93);
            this.radioButtonInheritanceArrow.Name = "radioButtonInheritanceArrow";
            this.radioButtonInheritanceArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonInheritanceArrow.TabIndex = 18;
            this.radioButtonInheritanceArrow.TabStop = true;
            this.radioButtonInheritanceArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonInheritanceArrow.UseVisualStyleBackColor = true;
            this.radioButtonInheritanceArrow.CheckedChanged += new System.EventHandler(this.radioButtonInheritanceArrow_CheckedChanged);
            // 
            // radioButtonRealizationArrow
            // 
            this.radioButtonRealizationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRealizationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonRealizationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRealizationArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonRealizationArrow.Image")));
            this.radioButtonRealizationArrow.Location = new System.Drawing.Point(13, 130);
            this.radioButtonRealizationArrow.Name = "radioButtonRealizationArrow";
            this.radioButtonRealizationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonRealizationArrow.TabIndex = 19;
            this.radioButtonRealizationArrow.TabStop = true;
            this.radioButtonRealizationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRealizationArrow.UseVisualStyleBackColor = true;
            this.radioButtonRealizationArrow.CheckedChanged += new System.EventHandler(this.radioButtonRealizationArrow_CheckedChanged);
            // 
            // radioButtonAssociationArrow
            // 
            this.radioButtonAssociationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAssociationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAssociationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAssociationArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonAssociationArrow.Image")));
            this.radioButtonAssociationArrow.Location = new System.Drawing.Point(13, 167);
            this.radioButtonAssociationArrow.Name = "radioButtonAssociationArrow";
            this.radioButtonAssociationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAssociationArrow.TabIndex = 20;
            this.radioButtonAssociationArrow.TabStop = true;
            this.radioButtonAssociationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAssociationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAssociationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAssociationArrow_CheckedChanged);
            // 
            // radioButtonCompositionArrow
            // 
            this.radioButtonCompositionArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCompositionArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonCompositionArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCompositionArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonCompositionArrow.Image")));
            this.radioButtonCompositionArrow.Location = new System.Drawing.Point(12, 204);
            this.radioButtonCompositionArrow.Name = "radioButtonCompositionArrow";
            this.radioButtonCompositionArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonCompositionArrow.TabIndex = 21;
            this.radioButtonCompositionArrow.TabStop = true;
            this.radioButtonCompositionArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCompositionArrow.UseVisualStyleBackColor = true;
            this.radioButtonCompositionArrow.CheckedChanged += new System.EventHandler(this.radioButtonCompositionArrow_CheckedChanged);
            // 
            // radioButtonAlternateCompositionArrow
            // 
            this.radioButtonAlternateCompositionArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAlternateCompositionArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAlternateCompositionArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAlternateCompositionArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonAlternateCompositionArrow.Image")));
            this.radioButtonAlternateCompositionArrow.Location = new System.Drawing.Point(12, 235);
            this.radioButtonAlternateCompositionArrow.Name = "radioButtonAlternateCompositionArrow";
            this.radioButtonAlternateCompositionArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAlternateCompositionArrow.TabIndex = 22;
            this.radioButtonAlternateCompositionArrow.TabStop = true;
            this.radioButtonAlternateCompositionArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAlternateCompositionArrow.UseVisualStyleBackColor = true;
            this.radioButtonAlternateCompositionArrow.CheckedChanged += new System.EventHandler(this.radioButtonAlternateCompositionArrow_CheckedChanged);
            // 
            // radioButtonAgregationArrow
            // 
            this.radioButtonAgregationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAgregationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAgregationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAgregationArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonAgregationArrow.Image")));
            this.radioButtonAgregationArrow.Location = new System.Drawing.Point(13, 272);
            this.radioButtonAgregationArrow.Name = "radioButtonAgregationArrow";
            this.radioButtonAgregationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAgregationArrow.TabIndex = 23;
            this.radioButtonAgregationArrow.TabStop = true;
            this.radioButtonAgregationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAgregationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAgregationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAgregationArrow_CheckedChanged);
            // 
            // radioButtonAlternateAgregationArrow
            // 
            this.radioButtonAlternateAgregationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAlternateAgregationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAlternateAgregationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAlternateAgregationArrow.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonAlternateAgregationArrow.Image")));
            this.radioButtonAlternateAgregationArrow.Location = new System.Drawing.Point(14, 302);
            this.radioButtonAlternateAgregationArrow.Name = "radioButtonAlternateAgregationArrow";
            this.radioButtonAlternateAgregationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAlternateAgregationArrow.TabIndex = 24;
            this.radioButtonAlternateAgregationArrow.TabStop = true;
            this.radioButtonAlternateAgregationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAlternateAgregationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAlternateAgregationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAlternateAgregationArrow_CheckedChanged);
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonClass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonClass.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonClass.Image")));
            this.radioButtonClass.Location = new System.Drawing.Point(14, 346);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(120, 25);
            this.radioButtonClass.TabIndex = 25;
            this.radioButtonClass.TabStop = true;
            this.radioButtonClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonClass.UseVisualStyleBackColor = true;
            this.radioButtonClass.CheckedChanged += new System.EventHandler(this.radioButtonClass_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1184, 620);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 40);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(84, 481);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(46, 40);
            this.buttonBackColor.TabIndex = 26;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // trackBarScale
            // 
            this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarScale.Location = new System.Drawing.Point(506, 620);
            this.trackBarScale.Maximum = 150;
            this.trackBarScale.Minimum = 50;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(475, 45);
            this.trackBarScale.TabIndex = 30;
            this.trackBarScale.Value = 100;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(400, 629);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(34, 13);
            this.labelScale.TabIndex = 31;
            this.labelScale.Text = "Scale";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(440, 626);
            this.textBoxScale.MaxLength = 3;
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(39, 20);
            this.textBoxScale.TabIndex = 32;
            this.textBoxScale.Text = "100";
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxScale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScale_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "%";
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(9, 428);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(121, 23);
            this.buttonFont.TabIndex = 30;
            this.buttonFont.Text = "Text Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1296, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 677);
            this.panel1.TabIndex = 34;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png|*.gif|*.gif";
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.Filter = "*.teamqueue|";
            // 
            // openDiagramDialog
            // 
            this.openDiagramDialog.Filter = "*.teamqueue|";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem2,
            this.exportToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(152, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveToolStripMenuItem2_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Line Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fill Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Line Width";
            // 
            // radioButtonStack
            // 
            this.radioButtonStack.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonStack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonStack.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonStack.Image")));
            this.radioButtonStack.Location = new System.Drawing.Point(14, 381);
            this.radioButtonStack.Name = "radioButtonStack";
            this.radioButtonStack.Size = new System.Drawing.Size(120, 25);
            this.radioButtonStack.TabIndex = 41;
            this.radioButtonStack.TabStop = true;
            this.radioButtonStack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStack.UseVisualStyleBackColor = true;
            this.radioButtonStack.CheckedChanged += new System.EventHandler(this.radioButtonStack_CheckedChanged);
            // 
            // UMLDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 677);
            this.Controls.Add(this.radioButtonStack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.radioButtonClass);
            this.Controls.Add(this.radioButtonAlternateAgregationArrow);
            this.Controls.Add(this.radioButtonAgregationArrow);
            this.Controls.Add(this.radioButtonAlternateCompositionArrow);
            this.Controls.Add(this.radioButtonCompositionArrow);
            this.Controls.Add(this.radioButtonAssociationArrow);
            this.Controls.Add(this.radioButtonRealizationArrow);
            this.Controls.Add(this.radioButtonInheritanceArrow);
            this.Controls.Add(this.radioButtonCursor);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UMLDesigner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RadioButton radioButtonCursor;
        private System.Windows.Forms.RadioButton radioButtonInheritanceArrow;
        private System.Windows.Forms.RadioButton radioButtonRealizationArrow;
        private System.Windows.Forms.RadioButton radioButtonAssociationArrow;
        private System.Windows.Forms.RadioButton radioButtonCompositionArrow;
        private System.Windows.Forms.RadioButton radioButtonAlternateCompositionArrow;
        private System.Windows.Forms.RadioButton radioButtonAgregationArrow;
        private System.Windows.Forms.RadioButton radioButtonAlternateAgregationArrow;
        private System.Windows.Forms.RadioButton radioButtonClass;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.FontDialog fontDialogMain;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveDiagramDialog;
        private System.Windows.Forms.OpenFileDialog openDiagramDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonStack;
    }
}

