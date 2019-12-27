namespace TestProject
{
    partial class ChooseClass
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
            this.labelChoose = new System.Windows.Forms.Label();
            this.buttonChooseBarbarian = new System.Windows.Forms.Button();
            this.buttonChooseRogue = new System.Windows.Forms.Button();
            this.buttonChooseMage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labelChoose, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonChooseBarbarian, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonChooseRogue, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonChooseMage, 4, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelChoose
            // 
            this.labelChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChoose.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelChoose, 6);
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(223, 45);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(353, 45);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Choose a class";
            // 
            // buttonChooseBarbarian
            // 
            this.buttonChooseBarbarian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonChooseBarbarian, 2);
            this.buttonChooseBarbarian.Location = new System.Drawing.Point(339, 184);
            this.buttonChooseBarbarian.Name = "buttonChooseBarbarian";
            this.buttonChooseBarbarian.Size = new System.Drawing.Size(121, 36);
            this.buttonChooseBarbarian.TabIndex = 1;
            this.buttonChooseBarbarian.Text = "Barbarian";
            this.buttonChooseBarbarian.UseVisualStyleBackColor = true;
            this.buttonChooseBarbarian.Click += new System.EventHandler(this.buttonChooseWarrior_Click);
            // 
            // buttonChooseRogue
            // 
            this.buttonChooseRogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonChooseRogue, 2);
            this.buttonChooseRogue.Location = new System.Drawing.Point(339, 274);
            this.buttonChooseRogue.Name = "buttonChooseRogue";
            this.buttonChooseRogue.Size = new System.Drawing.Size(121, 36);
            this.buttonChooseRogue.TabIndex = 2;
            this.buttonChooseRogue.Text = "Rogue";
            this.buttonChooseRogue.UseVisualStyleBackColor = true;
            this.buttonChooseRogue.Click += new System.EventHandler(this.buttonChooseRogue_Click);
            // 
            // buttonChooseMage
            // 
            this.buttonChooseMage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonChooseMage, 2);
            this.buttonChooseMage.Location = new System.Drawing.Point(339, 364);
            this.buttonChooseMage.Name = "buttonChooseMage";
            this.buttonChooseMage.Size = new System.Drawing.Size(121, 36);
            this.buttonChooseMage.TabIndex = 3;
            this.buttonChooseMage.Text = "Mage";
            this.buttonChooseMage.UseVisualStyleBackColor = true;
            this.buttonChooseMage.Click += new System.EventHandler(this.buttonChooseMage_Click);
            // 
            // ChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChooseClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseClass";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Button buttonChooseBarbarian;
        private System.Windows.Forms.Button buttonChooseRogue;
        private System.Windows.Forms.Button buttonChooseMage;
    }
}