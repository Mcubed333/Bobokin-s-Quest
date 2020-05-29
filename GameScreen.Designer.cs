namespace TestProject
{
    partial class GameScreen
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
            this.buttonFindMerchant = new System.Windows.Forms.Button();
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.buttonNewEncounter = new System.Windows.Forms.Button();
            this.labelCharacterGold = new System.Windows.Forms.Label();
            this.labelCharacterGoldValue = new System.Windows.Forms.Label();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.labelCharacterHealth = new System.Windows.Forms.Label();
            this.labelCharacterMana = new System.Windows.Forms.Label();
            this.labelCharacterManaOutOfTotal = new System.Windows.Forms.Label();
            this.labelCharacterHealthOutOfTotal = new System.Windows.Forms.Label();
            this.labelEnemyHealthOutOfTotal = new System.Windows.Forms.Label();
            this.progressBarEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarCharacterMana = new System.Windows.Forms.ProgressBar();
            this.progressBarCharacterHealth = new System.Windows.Forms.ProgressBar();
            this.pictureBoxEncounter = new System.Windows.Forms.PictureBox();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonCast = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.labelCharacter = new System.Windows.Forms.Label();
            this.richTextBoxGameText = new System.Windows.Forms.RichTextBox();
            this.labelEncounter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRest = new System.Windows.Forms.Button();
            this.progressBarCharacterExperience = new System.Windows.Forms.ProgressBar();
            this.labelExperienceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindMerchant
            // 
            this.buttonFindMerchant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonFindMerchant, 2);
            this.buttonFindMerchant.Location = new System.Drawing.Point(717, 319);
            this.buttonFindMerchant.Name = "buttonFindMerchant";
            this.buttonFindMerchant.Size = new System.Drawing.Size(105, 36);
            this.buttonFindMerchant.TabIndex = 32;
            this.buttonFindMerchant.Text = "Find Merchant";
            this.buttonFindMerchant.UseVisualStyleBackColor = true;
            this.buttonFindMerchant.Click += new System.EventHandler(this.buttonFindMerchant_Click);
            // 
            // buttonExitGame
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonExitGame, 2);
            this.buttonExitGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExitGame.Location = new System.Drawing.Point(983, 423);
            this.buttonExitGame.Name = "buttonExitGame";
            this.tableLayoutPanel1.SetRowSpan(this.buttonExitGame, 2);
            this.buttonExitGame.Size = new System.Drawing.Size(134, 114);
            this.buttonExitGame.TabIndex = 31;
            this.buttonExitGame.Text = "Exit Game";
            this.buttonExitGame.UseVisualStyleBackColor = true;
            this.buttonExitGame.Click += new System.EventHandler(this.buttonExitGame_Click);
            // 
            // buttonNewEncounter
            // 
            this.buttonNewEncounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonNewEncounter, 2);
            this.buttonNewEncounter.Location = new System.Drawing.Point(437, 319);
            this.buttonNewEncounter.Name = "buttonNewEncounter";
            this.buttonNewEncounter.Size = new System.Drawing.Size(105, 36);
            this.buttonNewEncounter.TabIndex = 30;
            this.buttonNewEncounter.Text = "Find New Encounter";
            this.buttonNewEncounter.UseVisualStyleBackColor = true;
            this.buttonNewEncounter.Click += new System.EventHandler(this.buttonNewEncounter_Click);
            // 
            // labelCharacterGold
            // 
            this.labelCharacterGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCharacterGold.AutoSize = true;
            this.labelCharacterGold.Location = new System.Drawing.Point(105, 426);
            this.labelCharacterGold.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelCharacterGold.Name = "labelCharacterGold";
            this.labelCharacterGold.Size = new System.Drawing.Size(32, 13);
            this.labelCharacterGold.TabIndex = 11;
            this.labelCharacterGold.Text = "Gold:";
            // 
            // labelCharacterGoldValue
            // 
            this.labelCharacterGoldValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCharacterGoldValue, 2);
            this.labelCharacterGoldValue.Location = new System.Drawing.Point(143, 426);
            this.labelCharacterGoldValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelCharacterGoldValue.Name = "labelCharacterGoldValue";
            this.labelCharacterGoldValue.Size = new System.Drawing.Size(23, 13);
            this.labelCharacterGoldValue.TabIndex = 24;
            this.labelCharacterGoldValue.Text = "null";
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.Location = new System.Drawing.Point(866, 321);
            this.labelEnemyHealth.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(41, 13);
            this.labelEnemyHealth.TabIndex = 14;
            this.labelEnemyHealth.Text = "Health:";
            // 
            // labelCharacterHealth
            // 
            this.labelCharacterHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCharacterHealth.AutoSize = true;
            this.labelCharacterHealth.Location = new System.Drawing.Point(23, 321);
            this.labelCharacterHealth.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelCharacterHealth.Name = "labelCharacterHealth";
            this.labelCharacterHealth.Size = new System.Drawing.Size(44, 13);
            this.labelCharacterHealth.TabIndex = 1;
            this.labelCharacterHealth.Text = "Health: ";
            // 
            // labelCharacterMana
            // 
            this.labelCharacterMana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCharacterMana.AutoSize = true;
            this.labelCharacterMana.Location = new System.Drawing.Point(30, 381);
            this.labelCharacterMana.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelCharacterMana.Name = "labelCharacterMana";
            this.labelCharacterMana.Size = new System.Drawing.Size(37, 13);
            this.labelCharacterMana.TabIndex = 2;
            this.labelCharacterMana.Text = "Mana:";
            // 
            // labelCharacterManaOutOfTotal
            // 
            this.labelCharacterManaOutOfTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCharacterManaOutOfTotal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCharacterManaOutOfTotal, 3);
            this.labelCharacterManaOutOfTotal.Location = new System.Drawing.Point(163, 362);
            this.labelCharacterManaOutOfTotal.Name = "labelCharacterManaOutOfTotal";
            this.labelCharacterManaOutOfTotal.Size = new System.Drawing.Size(23, 13);
            this.labelCharacterManaOutOfTotal.TabIndex = 29;
            this.labelCharacterManaOutOfTotal.Text = "null";
            // 
            // labelCharacterHealthOutOfTotal
            // 
            this.labelCharacterHealthOutOfTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCharacterHealthOutOfTotal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCharacterHealthOutOfTotal, 3);
            this.labelCharacterHealthOutOfTotal.Location = new System.Drawing.Point(163, 302);
            this.labelCharacterHealthOutOfTotal.Name = "labelCharacterHealthOutOfTotal";
            this.labelCharacterHealthOutOfTotal.Size = new System.Drawing.Size(23, 13);
            this.labelCharacterHealthOutOfTotal.TabIndex = 28;
            this.labelCharacterHealthOutOfTotal.Text = "null";
            // 
            // labelEnemyHealthOutOfTotal
            // 
            this.labelEnemyHealthOutOfTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelEnemyHealthOutOfTotal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelEnemyHealthOutOfTotal, 3);
            this.labelEnemyHealthOutOfTotal.Location = new System.Drawing.Point(1003, 302);
            this.labelEnemyHealthOutOfTotal.Name = "labelEnemyHealthOutOfTotal";
            this.labelEnemyHealthOutOfTotal.Size = new System.Drawing.Size(23, 13);
            this.labelEnemyHealthOutOfTotal.TabIndex = 27;
            this.labelEnemyHealthOutOfTotal.Text = "null";
            // 
            // progressBarEnemyHealth
            // 
            this.progressBarEnemyHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarEnemyHealth, 3);
            this.progressBarEnemyHealth.Location = new System.Drawing.Point(913, 318);
            this.progressBarEnemyHealth.Name = "progressBarEnemyHealth";
            this.progressBarEnemyHealth.Size = new System.Drawing.Size(204, 23);
            this.progressBarEnemyHealth.TabIndex = 19;
            // 
            // progressBarCharacterMana
            // 
            this.progressBarCharacterMana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarCharacterMana, 3);
            this.progressBarCharacterMana.Location = new System.Drawing.Point(73, 378);
            this.progressBarCharacterMana.Name = "progressBarCharacterMana";
            this.progressBarCharacterMana.Size = new System.Drawing.Size(204, 23);
            this.progressBarCharacterMana.TabIndex = 21;
            // 
            // progressBarCharacterHealth
            // 
            this.progressBarCharacterHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarCharacterHealth, 3);
            this.progressBarCharacterHealth.Location = new System.Drawing.Point(73, 318);
            this.progressBarCharacterHealth.Name = "progressBarCharacterHealth";
            this.progressBarCharacterHealth.Size = new System.Drawing.Size(204, 23);
            this.progressBarCharacterHealth.TabIndex = 20;
            // 
            // pictureBoxEncounter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxEncounter, 3);
            this.pictureBoxEncounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEncounter.Location = new System.Drawing.Point(913, 3);
            this.pictureBoxEncounter.Name = "pictureBoxEncounter";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxEncounter, 4);
            this.pictureBoxEncounter.Size = new System.Drawing.Size(204, 234);
            this.pictureBoxEncounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncounter.TabIndex = 25;
            this.pictureBoxEncounter.TabStop = false;
            // 
            // pictureBoxCharacter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxCharacter, 3);
            this.pictureBoxCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCharacter.InitialImage = null;
            this.pictureBoxCharacter.Location = new System.Drawing.Point(73, 3);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxCharacter, 4);
            this.pictureBoxCharacter.Size = new System.Drawing.Size(204, 234);
            this.pictureBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCharacter.TabIndex = 26;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(703, 378);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(64, 23);
            this.buttonRun.TabIndex = 10;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonCast
            // 
            this.buttonCast.Location = new System.Drawing.Point(563, 378);
            this.buttonCast.Name = "buttonCast";
            this.buttonCast.Size = new System.Drawing.Size(64, 23);
            this.buttonCast.TabIndex = 9;
            this.buttonCast.Text = "Cast";
            this.buttonCast.UseVisualStyleBackColor = true;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(423, 378);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(64, 23);
            this.buttonAttack.TabIndex = 8;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // labelCharacter
            // 
            this.labelCharacter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCharacter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCharacter, 3);
            this.labelCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharacter.Location = new System.Drawing.Point(160, 261);
            this.labelCharacter.Name = "labelCharacter";
            this.labelCharacter.Size = new System.Drawing.Size(30, 18);
            this.labelCharacter.TabIndex = 0;
            this.labelCharacter.Text = "null";
            // 
            // richTextBoxGameText
            // 
            this.richTextBoxGameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxGameText, 7);
            this.richTextBoxGameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGameText.Location = new System.Drawing.Point(353, 3);
            this.richTextBoxGameText.Name = "richTextBoxGameText";
            this.richTextBoxGameText.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBoxGameText, 5);
            this.richTextBoxGameText.Size = new System.Drawing.Size(484, 294);
            this.richTextBoxGameText.TabIndex = 7;
            this.richTextBoxGameText.TabStop = false;
            this.richTextBoxGameText.Text = "";
            this.richTextBoxGameText.TextChanged += new System.EventHandler(this.richTextBoxGameText_TextChanged);
            // 
            // labelEncounter
            // 
            this.labelEncounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEncounter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelEncounter, 3);
            this.labelEncounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncounter.Location = new System.Drawing.Point(1000, 261);
            this.labelEncounter.Name = "labelEncounter";
            this.labelEncounter.Size = new System.Drawing.Size(30, 18);
            this.labelEncounter.TabIndex = 13;
            this.labelEncounter.Text = "null";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 17;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.884948F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.884948F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882008F));
            this.tableLayoutPanel1.Controls.Add(this.labelEncounter, 13, 4);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxGameText, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonAttack, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonCast, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonRun, 10, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxCharacter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxEncounter, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBarCharacterHealth, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.progressBarCharacterMana, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.progressBarEnemyHealth, 13, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelEnemyHealthOutOfTotal, 13, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterHealthOutOfTotal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterManaOutOfTotal, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterMana, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterHealth, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelEnemyHealth, 12, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterGoldValue, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelCharacterGold, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewEncounter, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonExitGame, 14, 9);
            this.tableLayoutPanel1.Controls.Add(this.buttonFindMerchant, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonRest, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.progressBarCharacterExperience, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelExperienceText, 7, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1193, 628);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonRest
            // 
            this.buttonRest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonRest, 2);
            this.buttonRest.Location = new System.Drawing.Point(577, 319);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(105, 36);
            this.buttonRest.TabIndex = 33;
            this.buttonRest.Text = "Rest";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // progressBarCharacterExperience
            // 
            this.progressBarCharacterExperience.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarCharacterExperience, 15);
            this.progressBarCharacterExperience.Location = new System.Drawing.Point(73, 543);
            this.progressBarCharacterExperience.Name = "progressBarCharacterExperience";
            this.progressBarCharacterExperience.Size = new System.Drawing.Size(1044, 21);
            this.progressBarCharacterExperience.TabIndex = 34;
            // 
            // labelExperienceText
            // 
            this.labelExperienceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExperienceText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelExperienceText, 3);
            this.labelExperienceText.Location = new System.Drawing.Point(493, 527);
            this.labelExperienceText.Name = "labelExperienceText";
            this.labelExperienceText.Size = new System.Drawing.Size(204, 13);
            this.labelExperienceText.TabIndex = 35;
            this.labelExperienceText.Text = "null";
            this.labelExperienceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindMerchant;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEncounter;
        private System.Windows.Forms.RichTextBox richTextBoxGameText;
        private System.Windows.Forms.Label labelCharacter;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonCast;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.PictureBox pictureBoxEncounter;
        private System.Windows.Forms.ProgressBar progressBarCharacterHealth;
        private System.Windows.Forms.ProgressBar progressBarCharacterMana;
        private System.Windows.Forms.ProgressBar progressBarEnemyHealth;
        private System.Windows.Forms.Label labelEnemyHealthOutOfTotal;
        private System.Windows.Forms.Label labelCharacterHealthOutOfTotal;
        private System.Windows.Forms.Label labelCharacterManaOutOfTotal;
        private System.Windows.Forms.Label labelCharacterMana;
        private System.Windows.Forms.Label labelCharacterHealth;
        private System.Windows.Forms.Label labelEnemyHealth;
        private System.Windows.Forms.Label labelCharacterGoldValue;
        private System.Windows.Forms.Label labelCharacterGold;
        private System.Windows.Forms.Button buttonNewEncounter;
        private System.Windows.Forms.Button buttonExitGame;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.ProgressBar progressBarCharacterExperience;
        private System.Windows.Forms.Label labelExperienceText;
    }
}