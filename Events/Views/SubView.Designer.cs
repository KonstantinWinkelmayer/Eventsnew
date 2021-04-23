
namespace Events.Views
{
    partial class SubView
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
            this.TbText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbText
            // 
            this.TbText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbText.Location = new System.Drawing.Point(12, 52);
            this.TbText.Multiline = true;
            this.TbText.Name = "TbText";
            this.TbText.Size = new System.Drawing.Size(776, 395);
            this.TbText.TabIndex = 0;
            // 
            // Subview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbText);
            this.Name = "Subview";
            this.Text = "Subview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbText;
    }
}