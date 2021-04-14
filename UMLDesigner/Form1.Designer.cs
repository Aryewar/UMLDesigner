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
            this.moveButton = new System.Windows.Forms.Button();
            this.buttonInharitanceArrow = new System.Windows.Forms.Button();
            this.buttonRealizationArrow = new System.Windows.Forms.Button();
            this.buttonAssociationArrow = new System.Windows.Forms.Button();
            this.buttonCompozitionArrow = new System.Windows.Forms.Button();
            this.buttonAgregationArrow = new System.Windows.Forms.Button();
            this.buttonAlternateCompositionArrow = new System.Windows.Forms.Button();
            this.buttonAlternateAgregationArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
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
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomMouseUp);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(33, 427);
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
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(12, 24);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(45, 40);
            this.moveButton.TabIndex = 8;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // buttonInharitanceArrow
            // 
            this.buttonInharitanceArrow.Location = new System.Drawing.Point(12, 88);
            this.buttonInharitanceArrow.Name = "buttonInharitanceArrow";
            this.buttonInharitanceArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonInharitanceArrow.TabIndex = 9;
            this.buttonInharitanceArrow.Text = "inharitanceArrow";
            this.buttonInharitanceArrow.UseVisualStyleBackColor = true;
            this.buttonInharitanceArrow.Click += new System.EventHandler(this.buttonInheritanceArrow_Click);
            // 
            // buttonRealizationArrow
            // 
            this.buttonRealizationArrow.Location = new System.Drawing.Point(12, 117);
            this.buttonRealizationArrow.Name = "buttonRealizationArrow";
            this.buttonRealizationArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonRealizationArrow.TabIndex = 10;
            this.buttonRealizationArrow.Text = "realizationArrow";
            this.buttonRealizationArrow.UseVisualStyleBackColor = true;
            this.buttonRealizationArrow.Click += new System.EventHandler(this.buttonRealizationArrow_Click);
            // 
            // buttonAssociationArrow
            // 
            this.buttonAssociationArrow.Location = new System.Drawing.Point(12, 146);
            this.buttonAssociationArrow.Name = "buttonAssociationArrow";
            this.buttonAssociationArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonAssociationArrow.TabIndex = 11;
            this.buttonAssociationArrow.Text = "associationArrow";
            this.buttonAssociationArrow.UseVisualStyleBackColor = true;
            this.buttonAssociationArrow.Click += new System.EventHandler(this.buttonAssociationArrow_Click);
            // 
            // buttonCompozitionArrow
            // 
            this.buttonCompozitionArrow.Location = new System.Drawing.Point(12, 215);
            this.buttonCompozitionArrow.Name = "buttonCompozitionArrow";
            this.buttonCompozitionArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonCompozitionArrow.TabIndex = 12;
            this.buttonCompozitionArrow.Text = "compozitionArrow";
            this.buttonCompozitionArrow.UseVisualStyleBackColor = true;
            this.buttonCompozitionArrow.Click += new System.EventHandler(this.buttonCompozitionArrow_Click);
            // 
            // buttonAgregationArrow
            // 
            this.buttonAgregationArrow.Location = new System.Drawing.Point(12, 274);
            this.buttonAgregationArrow.Name = "buttonAgregationArrow";
            this.buttonAgregationArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonAgregationArrow.TabIndex = 13;
            this.buttonAgregationArrow.Text = "agregationArrow";
            this.buttonAgregationArrow.UseVisualStyleBackColor = true;
            this.buttonAgregationArrow.Click += new System.EventHandler(this.buttonAgregationArrow_Click);
            // 
            // buttonAlternateCompositionArrow
            // 
            this.buttonAlternateCompositionArrow.Location = new System.Drawing.Point(12, 244);
            this.buttonAlternateCompositionArrow.Name = "buttonAlternateCompositionArrow";
            this.buttonAlternateCompositionArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonAlternateCompositionArrow.TabIndex = 14;
            this.buttonAlternateCompositionArrow.Text = "alternateCompositionArrow";
            this.buttonAlternateCompositionArrow.UseVisualStyleBackColor = true;
            this.buttonAlternateCompositionArrow.Click += new System.EventHandler(this.buttonAlternateCompositionArrow_Click);
            // 
            // buttonAlternateAgregationArrow
            // 
            this.buttonAlternateAgregationArrow.Location = new System.Drawing.Point(12, 303);
            this.buttonAlternateAgregationArrow.Name = "buttonAlternateAgregationArrow";
            this.buttonAlternateAgregationArrow.Size = new System.Drawing.Size(114, 23);
            this.buttonAlternateAgregationArrow.TabIndex = 15;
            this.buttonAlternateAgregationArrow.Text = "alternateAgregation";
            this.buttonAlternateAgregationArrow.UseVisualStyleBackColor = true;
            this.buttonAlternateAgregationArrow.Click += new System.EventHandler(this.buttonAlternateAgregationArrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 580);
            this.Controls.Add(this.buttonAlternateAgregationArrow);
            this.Controls.Add(this.buttonAlternateCompositionArrow);
            this.Controls.Add(this.buttonAgregationArrow);
            this.Controls.Add(this.buttonCompozitionArrow);
            this.Controls.Add(this.buttonAssociationArrow);
            this.Controls.Add(this.buttonRealizationArrow);
            this.Controls.Add(this.buttonInharitanceArrow);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button buttonInharitanceArrow;
        private System.Windows.Forms.Button buttonRealizationArrow;
        private System.Windows.Forms.Button buttonAssociationArrow;
        private System.Windows.Forms.Button buttonCompozitionArrow;
        private System.Windows.Forms.Button buttonAgregationArrow;
        private System.Windows.Forms.Button buttonAlternateCompositionArrow;
        private System.Windows.Forms.Button buttonAlternateAgregationArrow;
    }
}

