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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(69, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1080, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // inheritanceArrow
            // 
            this.inheritanceArrow.AutoSize = true;
            this.inheritanceArrow.Location = new System.Drawing.Point(69, 1);
            this.inheritanceArrow.Name = "inheritanceArrow";
            this.inheritanceArrow.Size = new System.Drawing.Size(77, 17);
            this.inheritanceArrow.TabIndex = 1;
            this.inheritanceArrow.TabStop = true;
            this.inheritanceArrow.Text = "inheritance";
            this.inheritanceArrow.UseVisualStyleBackColor = true;
            // 
            // realizationArrow
            // 
            this.realizationArrow.AutoSize = true;
            this.realizationArrow.Location = new System.Drawing.Point(160, 1);
            this.realizationArrow.Name = "realizationArrow";
            this.realizationArrow.Size = new System.Drawing.Size(72, 17);
            this.realizationArrow.TabIndex = 2;
            this.realizationArrow.TabStop = true;
            this.realizationArrow.Text = "realization";
            this.realizationArrow.UseVisualStyleBackColor = true;
            // 
            // associationArrow
            // 
            this.associationArrow.AutoSize = true;
            this.associationArrow.Location = new System.Drawing.Point(251, 1);
            this.associationArrow.Name = "associationArrow";
            this.associationArrow.Size = new System.Drawing.Size(78, 17);
            this.associationArrow.TabIndex = 3;
            this.associationArrow.TabStop = true;
            this.associationArrow.Text = "association";
            this.associationArrow.UseVisualStyleBackColor = true;
            // 
            // compositionArrow
            // 
            this.compositionArrow.AutoSize = true;
            this.compositionArrow.Location = new System.Drawing.Point(342, 1);
            this.compositionArrow.Name = "compositionArrow";
            this.compositionArrow.Size = new System.Drawing.Size(81, 17);
            this.compositionArrow.TabIndex = 4;
            this.compositionArrow.TabStop = true;
            this.compositionArrow.Text = "composition";
            this.compositionArrow.UseVisualStyleBackColor = true;
            // 
            // agragationArrow
            // 
            this.agragationArrow.AutoSize = true;
            this.agragationArrow.Location = new System.Drawing.Point(433, 1);
            this.agragationArrow.Name = "agragationArrow";
            this.agragationArrow.Size = new System.Drawing.Size(75, 17);
            this.agragationArrow.TabIndex = 5;
            this.agragationArrow.TabStop = true;
            this.agragationArrow.Text = "agregation";
            this.agragationArrow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 624);
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
    }
}

