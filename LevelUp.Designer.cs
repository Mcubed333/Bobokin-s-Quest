namespace TestProject
{
    partial class LevelUp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLevelUp = new System.Windows.Forms.Label();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.radioButtonStrength = new System.Windows.Forms.RadioButton();
            this.radioButtonDexterity = new System.Windows.Forms.RadioButton();
            this.radioButtonIntellect = new System.Windows.Forms.RadioButton();
            this.radioButtonVitality = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelLevelUp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStats, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonConfirm, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelError, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.110301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407408F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelLevelUp
            // 
            this.labelLevelUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevelUp.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelLevelUp, 4);
            this.labelLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelUp.Location = new System.Drawing.Point(3, 33);
            this.labelLevelUp.Name = "labelLevelUp";
            this.labelLevelUp.Size = new System.Drawing.Size(465, 70);
            this.labelLevelUp.TabIndex = 0;
            this.labelLevelUp.Text = "Choose a stat to level up";
            this.labelLevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxStats, 2);
            this.groupBoxStats.Controls.Add(this.radioButtonVitality);
            this.groupBoxStats.Controls.Add(this.radioButtonStrength);
            this.groupBoxStats.Controls.Add(this.radioButtonDexterity);
            this.groupBoxStats.Controls.Add(this.radioButtonIntellect);
            this.groupBoxStats.Location = new System.Drawing.Point(120, 106);
            this.groupBoxStats.Name = "groupBoxStats";
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxStats, 3);
            this.groupBoxStats.Size = new System.Drawing.Size(228, 204);
            this.groupBoxStats.TabIndex = 1;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // radioButtonStrength
            // 
            this.radioButtonStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStrength.AutoSize = true;
            this.radioButtonStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStrength.Location = new System.Drawing.Point(74, 77);
            this.radioButtonStrength.Name = "radioButtonStrength";
            this.radioButtonStrength.Size = new System.Drawing.Size(75, 20);
            this.radioButtonStrength.TabIndex = 2;
            this.radioButtonStrength.TabStop = true;
            this.radioButtonStrength.Text = "Strength";
            this.radioButtonStrength.UseVisualStyleBackColor = true;
            // 
            // radioButtonDexterity
            // 
            this.radioButtonDexterity.AutoSize = true;
            this.radioButtonDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDexterity.Location = new System.Drawing.Point(71, 175);
            this.radioButtonDexterity.Name = "radioButtonDexterity";
            this.radioButtonDexterity.Size = new System.Drawing.Size(78, 20);
            this.radioButtonDexterity.TabIndex = 1;
            this.radioButtonDexterity.TabStop = true;
            this.radioButtonDexterity.Text = "Dexterity";
            this.radioButtonDexterity.UseVisualStyleBackColor = true;
            // 
            // radioButtonIntellect
            // 
            this.radioButtonIntellect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonIntellect.AutoSize = true;
            this.radioButtonIntellect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIntellect.Location = new System.Drawing.Point(74, 128);
            this.radioButtonIntellect.Name = "radioButtonIntellect";
            this.radioButtonIntellect.Size = new System.Drawing.Size(71, 20);
            this.radioButtonIntellect.TabIndex = 0;
            this.radioButtonIntellect.TabStop = true;
            this.radioButtonIntellect.Text = "Intellect";
            this.radioButtonIntellect.UseVisualStyleBackColor = true;
            // 
            // radioButtonVitality
            // 
            this.radioButtonVitality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonVitality.AutoSize = true;
            this.radioButtonVitality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVitality.Location = new System.Drawing.Point(74, 24);
            this.radioButtonVitality.Name = "radioButtonVitality";
            this.radioButtonVitality.Size = new System.Drawing.Size(65, 20);
            this.radioButtonVitality.TabIndex = 3;
            this.radioButtonVitality.TabStop = true;
            this.radioButtonVitality.Text = "Vitality";
            this.radioButtonVitality.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.Location = new System.Drawing.Point(255, 363);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 37);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Ok";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelError, 4);
            this.labelError.Location = new System.Drawing.Point(224, 322);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(23, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "null";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LevelUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelUp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelLevelUp;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.RadioButton radioButtonStrength;
        private System.Windows.Forms.RadioButton radioButtonDexterity;
        private System.Windows.Forms.RadioButton radioButtonIntellect;
        private System.Windows.Forms.RadioButton radioButtonVitality;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelError;
    }
}