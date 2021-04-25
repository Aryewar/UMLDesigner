
namespace UMLDesigner
{
    partial class PropertiesDialog
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
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonProperties = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(32, 22);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(139, 26);
            this.ButtonRemove.TabIndex = 0;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonProperties
            // 
            this.ButtonProperties.Location = new System.Drawing.Point(32, 54);
            this.ButtonProperties.Name = "ButtonProperties";
            this.ButtonProperties.Size = new System.Drawing.Size(139, 26);
            this.ButtonProperties.TabIndex = 1;
            this.ButtonProperties.Text = "Properties";
            this.ButtonProperties.UseVisualStyleBackColor = true;
            this.ButtonProperties.Click += new System.EventHandler(this.ButtonProperties_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(32, 86);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(139, 26);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 134);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonProperties);
            this.Controls.Add(this.ButtonRemove);
            this.Name = "PropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonProperties;
        private System.Windows.Forms.Button ButtonCancel;
    }
}