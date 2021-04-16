
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
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(88, 36);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTitle.Size = new System.Drawing.Size(201, 35);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxProperties
            // 
            this.textBoxProperties.Location = new System.Drawing.Point(88, 101);
            this.textBoxProperties.Multiline = true;
            this.textBoxProperties.Name = "textBoxProperties";
            this.textBoxProperties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProperties.Size = new System.Drawing.Size(201, 35);
            this.textBoxProperties.TabIndex = 2;
            this.textBoxProperties.TextChanged += new System.EventHandler(this.textBoxProperties_TextChanged);
            // 
            // textBoxFields
            // 
            this.textBoxFields.Location = new System.Drawing.Point(88, 166);
            this.textBoxFields.Multiline = true;
            this.textBoxFields.Name = "textBoxFields";
            this.textBoxFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFields.Size = new System.Drawing.Size(201, 35);
            this.textBoxFields.TabIndex = 3;
            this.textBoxFields.TextChanged += new System.EventHandler(this.textBoxFields_TextChanged);
            // 
            // textBoxMethods
            // 
            this.textBoxMethods.Location = new System.Drawing.Point(88, 243);
            this.textBoxMethods.Multiline = true;
            this.textBoxMethods.Name = "textBoxMethods";
            this.textBoxMethods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMethods.Size = new System.Drawing.Size(201, 35);
            this.textBoxMethods.TabIndex = 4;
            this.textBoxMethods.TextChanged += new System.EventHandler(this.textBoxMethods_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(163, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(45, 24);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Title";
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProperties.Location = new System.Drawing.Point(143, 74);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(95, 24);
            this.labelProperties.TabIndex = 6;
            this.labelProperties.Text = "Properties";
            // 
            // labelFields
            // 
            this.labelFields.AutoSize = true;
            this.labelFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFields.Location = new System.Drawing.Point(153, 139);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(61, 24);
            this.labelFields.TabIndex = 7;
            this.labelFields.Text = "Fields";
            // 
            // labelMethods
            // 
            this.labelMethods.AutoSize = true;
            this.labelMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethods.Location = new System.Drawing.Point(145, 209);
            this.labelMethods.Name = "labelMethods";
            this.labelMethods.Size = new System.Drawing.Size(83, 24);
            this.labelMethods.TabIndex = 8;
            this.labelMethods.Text = "Methods";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(88, 293);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(201, 50);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ClassDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 355);
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
    }
}