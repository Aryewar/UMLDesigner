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
            this.inheritanceArrow = new System.Windows.Forms.RadioButton();
            this.realizationArrow = new System.Windows.Forms.RadioButton();
            this.associationArrow = new System.Windows.Forms.RadioButton();
            this.compositionArrow = new System.Windows.Forms.RadioButton();
            this.agragationArrow = new System.Windows.Forms.RadioButton();
            this.colorButton = new System.Windows.Forms.Button();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(69, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(907, 485);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // inheritanceArrow
            // 
            this.inheritanceArrow.AutoSize = true;
            this.inheritanceArrow.Location = new System.Drawing.Point(68, 12);
            this.inheritanceArrow.Name = "inheritanceArrow";
            this.inheritanceArrow.Size = new System.Drawing.Size(77, 17);
            this.inheritanceArrow.TabIndex = 1;
            this.inheritanceArrow.TabStop = true;
            this.inheritanceArrow.Text = "inheritance";
            this.inheritanceArrow.UseVisualStyleBackColor = true;
            this.inheritanceArrow.CheckedChanged += new System.EventHandler(this.inheritanceArrow_CheckedChanged);
            // 
            // realizationArrow
            // 
            this.realizationArrow.AutoSize = true;
            this.realizationArrow.Location = new System.Drawing.Point(159, 12);
            this.realizationArrow.Name = "realizationArrow";
            this.realizationArrow.Size = new System.Drawing.Size(72, 17);
            this.realizationArrow.TabIndex = 2;
            this.realizationArrow.TabStop = true;
            this.realizationArrow.Text = "realization";
            this.realizationArrow.UseVisualStyleBackColor = true;
            this.realizationArrow.CheckedChanged += new System.EventHandler(this.realizationArrow_CheckedChanged);
            // 
            // associationArrow
            // 
            this.associationArrow.AutoSize = true;
            this.associationArrow.Location = new System.Drawing.Point(250, 12);
            this.associationArrow.Name = "associationArrow";
            this.associationArrow.Size = new System.Drawing.Size(78, 17);
            this.associationArrow.TabIndex = 3;
            this.associationArrow.TabStop = true;
            this.associationArrow.Text = "association";
            this.associationArrow.UseVisualStyleBackColor = true;
            this.associationArrow.CheckedChanged += new System.EventHandler(this.associationArrow_CheckedChanged);
            // 
            // compositionArrow
            // 
            this.compositionArrow.AutoSize = true;
            this.compositionArrow.Location = new System.Drawing.Point(341, 12);
            this.compositionArrow.Name = "compositionArrow";
            this.compositionArrow.Size = new System.Drawing.Size(81, 17);
            this.compositionArrow.TabIndex = 4;
            this.compositionArrow.TabStop = true;
            this.compositionArrow.Text = "composition";
            this.compositionArrow.UseVisualStyleBackColor = true;
            this.compositionArrow.CheckedChanged += new System.EventHandler(this.compositionArrow_CheckedChanged);
            // 
            // agragationArrow
            // 
            this.agragationArrow.AutoSize = true;
            this.agragationArrow.Location = new System.Drawing.Point(432, 12);
            this.agragationArrow.Name = "agragationArrow";
            this.agragationArrow.Size = new System.Drawing.Size(75, 17);
            this.agragationArrow.TabIndex = 5;
            this.agragationArrow.TabStop = true;
            this.agragationArrow.Text = "agregation";
            this.agragationArrow.UseVisualStyleBackColor = true;
            this.agragationArrow.CheckedChanged += new System.EventHandler(this.agragationArrow_CheckedChanged);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 24);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(45, 79);
            this.colorButton.TabIndex = 6;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // widthBar
            // 
            this.widthBar.Location = new System.Drawing.Point(12, 109);
            this.widthBar.Maximum = 5;
            this.widthBar.Minimum = 1;
            this.widthBar.Name = "widthBar";
            this.widthBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widthBar.Size = new System.Drawing.Size(45, 256);
            this.widthBar.TabIndex = 7;
            this.widthBar.Value = 4;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(234, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "move";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.agragationArrow);
            this.Controls.Add(this.compositionArrow);
            this.Controls.Add(this.associationArrow);
            this.Controls.Add(this.realizationArrow);
            this.Controls.Add(this.inheritanceArrow);
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
        private System.Windows.Forms.RadioButton inheritanceArrow;
        private System.Windows.Forms.RadioButton realizationArrow;
        private System.Windows.Forms.RadioButton associationArrow;
        private System.Windows.Forms.RadioButton compositionArrow;
        private System.Windows.Forms.RadioButton agragationArrow;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

