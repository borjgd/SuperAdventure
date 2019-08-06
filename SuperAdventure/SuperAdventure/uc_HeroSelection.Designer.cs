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
            this.pB_Warrior = new System.Windows.Forms.PictureBox();
            this.pB_Mage = new System.Windows.Forms.PictureBox();
            this.pB_Rogue = new System.Windows.Forms.PictureBox();
            this.pB_Paladin = new System.Windows.Forms.PictureBox();
            this.lbl_Warrior = new System.Windows.Forms.Label();
            this.lbl_Mage = new System.Windows.Forms.Label();
            this.lbl_Rogue = new System.Windows.Forms.Label();
            this.lbl_Paladin = new System.Windows.Forms.Label();
            this.lbl_ChosenHero = new System.Windows.Forms.Label();
            this.heroSelection_back_button = new System.Windows.Forms.Button();
            this.btn_StartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Warrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Mage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Rogue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Paladin)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Warrior
            // 
            this.pB_Warrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Warrior.Image = global::SuperAdventure.Properties.Resources.warrior;
            this.pB_Warrior.Location = new System.Drawing.Point(160, 124);
            this.pB_Warrior.Name = "pB_Warrior";
            this.pB_Warrior.Size = new System.Drawing.Size(137, 184);
            this.pB_Warrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Warrior.TabIndex = 1;
            this.pB_Warrior.TabStop = false;
            this.pB_Warrior.Click += new System.EventHandler(this.pB_Warrior_Click);
            // 
            // pB_Mage
            // 
            this.pB_Mage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Mage.Image = global::SuperAdventure.Properties.Resources.mage;
            this.pB_Mage.Location = new System.Drawing.Point(481, 124);
            this.pB_Mage.Name = "pB_Mage";
            this.pB_Mage.Size = new System.Drawing.Size(137, 184);
            this.pB_Mage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Mage.TabIndex = 2;
            this.pB_Mage.TabStop = false;
            this.pB_Mage.Click += new System.EventHandler(this.pB_Mage_Click);
            // 
            // pB_Rogue
            // 
            this.pB_Rogue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Rogue.Image = global::SuperAdventure.Properties.Resources.rogue;
            this.pB_Rogue.Location = new System.Drawing.Point(160, 381);
            this.pB_Rogue.Name = "pB_Rogue";
            this.pB_Rogue.Size = new System.Drawing.Size(137, 184);
            this.pB_Rogue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Rogue.TabIndex = 3;
            this.pB_Rogue.TabStop = false;
            this.pB_Rogue.Click += new System.EventHandler(this.pB_Rogue_Click);
            // 
            // pB_Paladin
            // 
            this.pB_Paladin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Paladin.Image = global::SuperAdventure.Properties.Resources.paladin;
            this.pB_Paladin.Location = new System.Drawing.Point(481, 381);
            this.pB_Paladin.Name = "pB_Paladin";
            this.pB_Paladin.Size = new System.Drawing.Size(137, 184);
            this.pB_Paladin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Paladin.TabIndex = 4;
            this.pB_Paladin.TabStop = false;
            this.pB_Paladin.Click += new System.EventHandler(this.pB_Paladin_Click);
            // 
            // lbl_Warrior
            // 
            this.lbl_Warrior.AutoSize = true;
            this.lbl_Warrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Warrior.Location = new System.Drawing.Point(208, 92);
            this.lbl_Warrior.Name = "lbl_Warrior";
            this.lbl_Warrior.Size = new System.Drawing.Size(43, 15);
            this.lbl_Warrior.TabIndex = 5;
            this.lbl_Warrior.Text = "Warrior";
            // 
            // lbl_Mage
            // 
            this.lbl_Mage.AutoSize = true;
            this.lbl_Mage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Mage.Location = new System.Drawing.Point(532, 92);
            this.lbl_Mage.Name = "lbl_Mage";
            this.lbl_Mage.Size = new System.Drawing.Size(36, 15);
            this.lbl_Mage.TabIndex = 6;
            this.lbl_Mage.Text = "Mage";
            // 
            // lbl_Rogue
            // 
            this.lbl_Rogue.AutoSize = true;
            this.lbl_Rogue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Rogue.Location = new System.Drawing.Point(208, 350);
            this.lbl_Rogue.Name = "lbl_Rogue";
            this.lbl_Rogue.Size = new System.Drawing.Size(41, 15);
            this.lbl_Rogue.TabIndex = 7;
            this.lbl_Rogue.Text = "Rogue";
            // 
            // lbl_Paladin
            // 
            this.lbl_Paladin.AutoSize = true;
            this.lbl_Paladin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Paladin.Location = new System.Drawing.Point(532, 350);
            this.lbl_Paladin.Name = "lbl_Paladin";
            this.lbl_Paladin.Size = new System.Drawing.Size(44, 15);
            this.lbl_Paladin.TabIndex = 8;
            this.lbl_Paladin.Text = "Paladin";
            // 
            // lbl_ChosenHero
            // 
            this.lbl_ChosenHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ChosenHero.Location = new System.Drawing.Point(339, 32);
            this.lbl_ChosenHero.Name = "lbl_ChosenHero";
            this.lbl_ChosenHero.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_ChosenHero.Size = new System.Drawing.Size(100, 35);
            this.lbl_ChosenHero.TabIndex = 9;
            this.lbl_ChosenHero.Text = "Choose a Hero";
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
            // uc_HeroSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.heroSelection_back_button);
            this.Controls.Add(this.lbl_ChosenHero);
            this.Controls.Add(this.lbl_Paladin);
            this.Controls.Add(this.lbl_Rogue);
            this.Controls.Add(this.lbl_Mage);
            this.Controls.Add(this.lbl_Warrior);
            this.Controls.Add(this.pB_Paladin);
            this.Controls.Add(this.pB_Rogue);
            this.Controls.Add(this.pB_Mage);
            this.Controls.Add(this.pB_Warrior);
            this.Name = "uc_HeroSelection";
            this.Size = new System.Drawing.Size(800, 610);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Warrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Mage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Rogue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Paladin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Warrior;
        private System.Windows.Forms.PictureBox pB_Mage;
        private System.Windows.Forms.PictureBox pB_Rogue;
        private System.Windows.Forms.PictureBox pB_Paladin;
        private System.Windows.Forms.Label lbl_Warrior;
        private System.Windows.Forms.Label lbl_Mage;
        private System.Windows.Forms.Label lbl_Rogue;
        private System.Windows.Forms.Label lbl_Paladin;
        private System.Windows.Forms.Label lbl_ChosenHero;
        private System.Windows.Forms.Button heroSelection_back_button;
        private System.Windows.Forms.Button btn_StartGame;
    }
}
