namespace SuperAdventure
{
    partial class uc_HeroSelection
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
            this.lbl_ChosenHero = new System.Windows.Forms.Label();
            this.heroSelection_back_button = new System.Windows.Forms.Button();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.cbm_Sex = new System.Windows.Forms.ComboBox();
            this.lbl_NameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ChosenHero
            // 
            this.lbl_ChosenHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ChosenHero.Location = new System.Drawing.Point(311, 32);
            this.lbl_ChosenHero.Name = "lbl_ChosenHero";
            this.lbl_ChosenHero.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_ChosenHero.Size = new System.Drawing.Size(152, 35);
            this.lbl_ChosenHero.TabIndex = 9;
            this.lbl_ChosenHero.Text = "Select a name and sex";
            this.lbl_ChosenHero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroSelection_back_button
            // 
            this.heroSelection_back_button.Location = new System.Drawing.Point(17, 32);
            this.heroSelection_back_button.Name = "heroSelection_back_button";
            this.heroSelection_back_button.Size = new System.Drawing.Size(85, 35);
            this.heroSelection_back_button.TabIndex = 10;
            this.heroSelection_back_button.Text = "Back";
            this.heroSelection_back_button.UseVisualStyleBackColor = true;
            this.heroSelection_back_button.Click += new System.EventHandler(this.btn_Back_HeroSelection);
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(694, 32);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(85, 35);
            this.btn_StartGame.TabIndex = 11;
            this.btn_StartGame.Text = "Start";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Visible = false;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(328, 161);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(126, 20);
            this.txt_Name.TabIndex = 12;
            this.txt_Name.TextChanged += new System.EventHandler(this.checkTextAndSex);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(260, 161);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 13);
            this.lbl_Name.TabIndex = 14;
            this.lbl_Name.Text = "Nombre";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(279, 222);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(25, 13);
            this.lbl_Sex.TabIndex = 15;
            this.lbl_Sex.Text = "Sex";
            // 
            // cbm_Sex
            // 
            this.cbm_Sex.FormattingEnabled = true;
            this.cbm_Sex.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbm_Sex.Location = new System.Drawing.Point(328, 214);
            this.cbm_Sex.Name = "cbm_Sex";
            this.cbm_Sex.Size = new System.Drawing.Size(76, 21);
            this.cbm_Sex.TabIndex = 16;
            this.cbm_Sex.TextChanged += new System.EventHandler(this.checkTextAndSex);
            // 
            // lbl_NameError
            // 
            this.lbl_NameError.AutoSize = true;
            this.lbl_NameError.Location = new System.Drawing.Point(325, 184);
            this.lbl_NameError.Name = "lbl_NameError";
            this.lbl_NameError.Size = new System.Drawing.Size(0, 13);
            this.lbl_NameError.TabIndex = 17;
            // 
            // uc_HeroSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_NameError);
            this.Controls.Add(this.cbm_Sex);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.heroSelection_back_button);
            this.Controls.Add(this.lbl_ChosenHero);
            this.Name = "uc_HeroSelection";
            this.Size = new System.Drawing.Size(800, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ChosenHero;
        private System.Windows.Forms.Button heroSelection_back_button;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.ComboBox cbm_Sex;
        private System.Windows.Forms.Label lbl_NameError;
    }
}
