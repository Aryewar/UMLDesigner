namespace UMLDesigner
{
    partial class Form1
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
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(310, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(848, 459);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CustomMouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomMouseUp);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(14, 424);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(45, 40);
            this.colorButton.TabIndex = 6;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // widthBar
            // 
            this.widthBar.Location = new System.Drawing.Point(235, 273);
            this.widthBar.Maximum = 5;
            this.widthBar.Minimum = 1;
            this.widthBar.Name = "widthBar";
            this.widthBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widthBar.Size = new System.Drawing.Size(45, 256);
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
            this.radioButtonCursor.Location = new System.Drawing.Point(12, 60);
            this.radioButtonCursor.Name = "radioButtonCursor";
            this.radioButtonCursor.Size = new System.Drawing.Size(120, 25);
            this.radioButtonCursor.TabIndex = 17;
            this.radioButtonCursor.TabStop = true;
            this.radioButtonCursor.Text = "Cursor";
            this.radioButtonCursor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCursor.UseVisualStyleBackColor = true;
            this.radioButtonCursor.CheckedChanged += new System.EventHandler(this.radioButtonCursor_CheckedChanged);
            // 
            // radioButtonInheritanceArrow
            // 
            this.radioButtonInheritanceArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonInheritanceArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonInheritanceArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonInheritanceArrow.Location = new System.Drawing.Point(12, 89);
            this.radioButtonInheritanceArrow.Name = "radioButtonInheritanceArrow";
            this.radioButtonInheritanceArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonInheritanceArrow.TabIndex = 18;
            this.radioButtonInheritanceArrow.TabStop = true;
            this.radioButtonInheritanceArrow.Text = "Inheritance Arrow";
            this.radioButtonInheritanceArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonInheritanceArrow.UseVisualStyleBackColor = true;
            this.radioButtonInheritanceArrow.CheckedChanged += new System.EventHandler(this.radioButtonInheritanceArrow_CheckedChanged);
            // 
            // radioButtonRealizationArrow
            // 
            this.radioButtonRealizationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRealizationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonRealizationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRealizationArrow.Location = new System.Drawing.Point(13, 118);
            this.radioButtonRealizationArrow.Name = "radioButtonRealizationArrow";
            this.radioButtonRealizationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonRealizationArrow.TabIndex = 19;
            this.radioButtonRealizationArrow.TabStop = true;
            this.radioButtonRealizationArrow.Text = "Realization Arrow";
            this.radioButtonRealizationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRealizationArrow.UseVisualStyleBackColor = true;
            this.radioButtonRealizationArrow.CheckedChanged += new System.EventHandler(this.radioButtonRealizationArrow_CheckedChanged);
            // 
            // radioButtonAssociationArrow
            // 
            this.radioButtonAssociationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAssociationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAssociationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAssociationArrow.Location = new System.Drawing.Point(13, 147);
            this.radioButtonAssociationArrow.Name = "radioButtonAssociationArrow";
            this.radioButtonAssociationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAssociationArrow.TabIndex = 20;
            this.radioButtonAssociationArrow.TabStop = true;
            this.radioButtonAssociationArrow.Text = "Association Arrow";
            this.radioButtonAssociationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAssociationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAssociationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAssociationArrow_CheckedChanged);
            // 
            // radioButtonCompositionArrow
            // 
            this.radioButtonCompositionArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCompositionArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonCompositionArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCompositionArrow.Location = new System.Drawing.Point(13, 176);
            this.radioButtonCompositionArrow.Name = "radioButtonCompositionArrow";
            this.radioButtonCompositionArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonCompositionArrow.TabIndex = 21;
            this.radioButtonCompositionArrow.TabStop = true;
            this.radioButtonCompositionArrow.Text = "Composition Arrow";
            this.radioButtonCompositionArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCompositionArrow.UseVisualStyleBackColor = true;
            this.radioButtonCompositionArrow.CheckedChanged += new System.EventHandler(this.radioButtonCompositionArrow_CheckedChanged);
            // 
            // radioButtonAlternateCompositionArrow
            // 
            this.radioButtonAlternateCompositionArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAlternateCompositionArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAlternateCompositionArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAlternateCompositionArrow.Location = new System.Drawing.Point(13, 205);
            this.radioButtonAlternateCompositionArrow.Name = "radioButtonAlternateCompositionArrow";
            this.radioButtonAlternateCompositionArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAlternateCompositionArrow.TabIndex = 22;
            this.radioButtonAlternateCompositionArrow.TabStop = true;
            this.radioButtonAlternateCompositionArrow.Text = "Alternate Composition";
            this.radioButtonAlternateCompositionArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAlternateCompositionArrow.UseVisualStyleBackColor = true;
            this.radioButtonAlternateCompositionArrow.CheckedChanged += new System.EventHandler(this.radioButtonAlternateCompositionArrow_CheckedChanged);
            // 
            // radioButtonAgregationArrow
            // 
            this.radioButtonAgregationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAgregationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAgregationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAgregationArrow.Location = new System.Drawing.Point(14, 234);
            this.radioButtonAgregationArrow.Name = "radioButtonAgregationArrow";
            this.radioButtonAgregationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAgregationArrow.TabIndex = 23;
            this.radioButtonAgregationArrow.TabStop = true;
            this.radioButtonAgregationArrow.Text = "Agregation Arrow";
            this.radioButtonAgregationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAgregationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAgregationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAgregationArrow_CheckedChanged);
            // 
            // radioButtonAlternateAgregationArrow
            // 
            this.radioButtonAlternateAgregationArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAlternateAgregationArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonAlternateAgregationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAlternateAgregationArrow.Location = new System.Drawing.Point(14, 263);
            this.radioButtonAlternateAgregationArrow.Name = "radioButtonAlternateAgregationArrow";
            this.radioButtonAlternateAgregationArrow.Size = new System.Drawing.Size(120, 25);
            this.radioButtonAlternateAgregationArrow.TabIndex = 24;
            this.radioButtonAlternateAgregationArrow.TabStop = true;
            this.radioButtonAlternateAgregationArrow.Text = "Alternate Agregation Arrow";
            this.radioButtonAlternateAgregationArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAlternateAgregationArrow.UseVisualStyleBackColor = true;
            this.radioButtonAlternateAgregationArrow.CheckedChanged += new System.EventHandler(this.radioButtonAlternateAgregationArrow_CheckedChanged);
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonClass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonClass.Location = new System.Drawing.Point(14, 292);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(120, 25);
            this.radioButtonClass.TabIndex = 25;
            this.radioButtonClass.TabStop = true;
            this.radioButtonClass.Text = "Class";
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
            this.buttonClear.Location = new System.Drawing.Point(176, 60);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(75, 424);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(46, 40);
            this.buttonBackColor.TabIndex = 26;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(402, 24);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(126, 23);
            this.buttonExport.TabIndex = 27;
            this.buttonExport.Text = "Export Image";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png|*.gif|*.gif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 549);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExport);
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
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

