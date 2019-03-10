namespace SuperAdventure
{
    partial class SuperAdventureForm
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
            this.pn_MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_MainPanel
            // 
            this.pn_MainPanel.Location = new System.Drawing.Point(39, 38);
            this.pn_MainPanel.Name = "pn_MainPanel";
            this.pn_MainPanel.Size = new System.Drawing.Size(821, 625);
            this.pn_MainPanel.TabIndex = 0;
            // 
            // SuperAdventureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pn_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuperAdventureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdventureForm";
            this.Load += new System.EventHandler(this.SuperAdventureForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_MainPanel;
    }
}