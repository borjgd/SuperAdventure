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
            this.uc_MainMenu1 = new SuperAdventure.uc_MainMenu();
            this.SuspendLayout();
            // 
            // uc_MainMenu1
            // 
            this.uc_MainMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.uc_MainMenu1.Location = new System.Drawing.Point(49, 44);
            this.uc_MainMenu1.Name = "uc_MainMenu1";
            this.uc_MainMenu1.Size = new System.Drawing.Size(800, 610);
            this.uc_MainMenu1.TabIndex = 0;
            // 
            // SuperAdventureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.uc_MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "SuperAdventureForm";
            this.Text = "SuperAdventureForm";
            this.ResumeLayout(false);

        }

        #endregion

        private uc_MainMenu uc_MainMenu1;
    }
}