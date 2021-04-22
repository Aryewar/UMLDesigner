
namespace UMLDesigner
{
    partial class ClassDialogForm
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxProperties = new System.Windows.Forms.TextBox();
            this.textBoxFields = new System.Windows.Forms.TextBox();
            this.textBoxMethods = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelProperties = new System.Windows.Forms.Label();
            this.labelFields = new System.Windows.Forms.Label();
            this.labelMethods = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialogText = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.buttonTextColor = new System.Windows.Forms.Button();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.fontDialogEdit = new System.Windows.Forms.FontDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(9, 36);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTitle.Size = new System.Drawing.Size(201, 35);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxProperties
            // 
            this.textBoxProperties.Location = new System.Drawing.Point(9, 101);
            this.textBoxProperties.Multiline = true;
            this.textBoxProperties.Name = "textBoxProperties";
            this.textBoxProperties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProperties.Size = new System.Drawing.Size(201, 158);
            this.textBoxProperties.TabIndex = 2;
            this.textBoxProperties.TextChanged += new System.EventHandler(this.textBoxProperties_TextChanged);
            // 
            // textBoxFields
            // 
            this.textBoxFields.Location = new System.Drawing.Point(236, 36);
            this.textBoxFields.Multiline = true;
            this.textBoxFields.Name = "textBoxFields";
            this.textBoxFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFields.Size = new System.Drawing.Size(201, 72);
            this.textBoxFields.TabIndex = 3;
            this.textBoxFields.TextChanged += new System.EventHandler(this.textBoxFields_TextChanged);
            // 
            // textBoxMethods
            // 
            this.textBoxMethods.Location = new System.Drawing.Point(236, 139);
            this.textBoxMethods.Multiline = true;
            this.textBoxMethods.Name = "textBoxMethods";
            this.textBoxMethods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMethods.Size = new System.Drawing.Size(201, 120);
            this.textBoxMethods.TabIndex = 4;
            this.textBoxMethods.TextChanged += new System.EventHandler(this.textBoxMethods_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(84, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Title";
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProperties.Location = new System.Drawing.Point(64, 77);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(81, 20);
            this.labelProperties.TabIndex = 6;
            this.labelProperties.Text = "Properties";
            // 
            // labelFields
            // 
            this.labelFields.AutoSize = true;
            this.labelFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFields.Location = new System.Drawing.Point(312, 9);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(51, 20);
            this.labelFields.TabIndex = 7;
            this.labelFields.Text = "Fields";
            // 
            // labelMethods
            // 
            this.labelMethods.AutoSize = true;
            this.labelMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethods.Location = new System.Drawing.Point(301, 111);
            this.labelMethods.Name = "labelMethods";
            this.labelMethods.Size = new System.Drawing.Size(71, 20);
            this.labelMethods.TabIndex = 8;
            this.labelMethods.Text = "Methods";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(133, 401);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(201, 50);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Text Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Background Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Line Width";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(122, 346);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(315, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonTextColor
            // 
            this.buttonTextColor.Location = new System.Drawing.Point(93, 278);
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.Size = new System.Drawing.Size(40, 40);
            this.buttonTextColor.TabIndex = 15;
            this.buttonTextColor.UseVisualStyleBackColor = true;
            this.buttonTextColor.Click += new System.EventHandler(this.buttonTextColor_Click);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(297, 278);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(40, 40);
            this.buttonBackColor.TabIndex = 16;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(362, 278);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 40);
            this.buttonFont.TabIndex = 17;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // ClassDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 463);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.buttonTextColor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMethods);
            this.Controls.Add(this.labelFields);
            this.Controls.Add(this.labelProperties);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxMethods);
            this.Controls.Add(this.textBoxFields);
            this.Controls.Add(this.textBoxProperties);
            this.Controls.Add(this.textBoxTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassDialogForm";
            this.Text = "ClassDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxProperties;
        private System.Windows.Forms.TextBox textBoxFields;
        private System.Windows.Forms.TextBox textBoxMethods;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProperties;
        private System.Windows.Forms.Label labelFields;
        private System.Windows.Forms.Label labelMethods;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialogText;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.Button buttonTextColor;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.FontDialog fontDialogEdit;
        private System.Windows.Forms.Button buttonFont;
    }
}