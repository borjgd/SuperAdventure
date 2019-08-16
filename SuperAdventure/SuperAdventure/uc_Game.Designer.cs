namespace SuperAdventure
{
    partial class uc_Game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Options
            // 
            this.btn_Options.Location = new System.Drawing.Point(24, 18);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(75, 38);
            this.btn_Options.TabIndex = 0;
            this.btn_Options.Text = "Opciones";
            this.btn_Options.UseVisualStyleBackColor = true;
            // 
            // uc_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Options);
            this.Name = "uc_Game";
            this.Size = new System.Drawing.Size(800, 610);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Options;
    }
}
