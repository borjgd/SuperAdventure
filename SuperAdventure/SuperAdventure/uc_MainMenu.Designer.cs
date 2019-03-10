namespace SuperAdventure
{
    partial class uc_MainMenu
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
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(340, 133);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(140, 46);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.Location = new System.Drawing.Point(340, 223);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(140, 46);
            this.btn_LoadGame.TabIndex = 1;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.UseVisualStyleBackColor = true;
            this.btn_LoadGame.Click += new System.EventHandler(this.btn_LoadGame_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.Location = new System.Drawing.Point(340, 317);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(140, 46);
            this.btn_Options.TabIndex = 2;
            this.btn_Options.Text = "Options";
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(340, 409);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 46);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // uc_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_NewGame);
            this.Name = "uc_MainMenu";
            this.Size = new System.Drawing.Size(800, 610);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_LoadGame;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_Exit;
    }
}
