namespace Events.Views
{
    partial class MainView
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
            this.TbText.Location = new System.Drawing.Point(2, 50);
            this.TbText.Multiline = true;
            this.TbText.Name = "TbText";
            this.TbText.Size = new System.Drawing.Size(612, 493);
            this.TbText.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 546);
            this.Controls.Add(this.TbText);
            this.Name = "MainView";
            this.Text = "Mainview   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbText;
    }
}

