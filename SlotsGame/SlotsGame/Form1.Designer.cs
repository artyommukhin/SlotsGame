using System.Windows.Forms;

namespace SlotsGame
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MoneyInput = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.AddMoneyButton = new System.Windows.Forms.Button();
            this.BalanceCount = new System.Windows.Forms.Label();
            this.WagerInput = new System.Windows.Forms.TextBox();
            this.TotalWagered = new System.Windows.Forms.Label();
            this.TotalWageredInfo = new System.Windows.Forms.Label();
            this.Wager = new System.Windows.Forms.Label();
            this.TotalEarns = new System.Windows.Forms.Label();
            this.TotalEarnsInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Location = new System.Drawing.Point(118, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox3.Location = new System.Drawing.Point(224, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 97);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(120, 331);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 70);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Spin";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 165);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(312, 61);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Play!";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneyInput
            // 
            this.MoneyInput.Location = new System.Drawing.Point(248, 352);
            this.MoneyInput.Name = "MoneyInput";
            this.MoneyInput.Size = new System.Drawing.Size(75, 20);
            this.MoneyInput.TabIndex = 5;
            this.MoneyInput.Text = "100";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance.Location = new System.Drawing.Point(115, 244);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(63, 17);
            this.Balance.TabIndex = 6;
            this.Balance.Text = "Balance:";
            // 
            // AddMoneyButton
            // 
            this.AddMoneyButton.Location = new System.Drawing.Point(248, 378);
            this.AddMoneyButton.Name = "AddMoneyButton";
            this.AddMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.AddMoneyButton.TabIndex = 7;
            this.AddMoneyButton.Text = "Add money";
            this.AddMoneyButton.UseVisualStyleBackColor = true;
            this.AddMoneyButton.Click += new System.EventHandler(this.AddMoneyButton_Click);
            // 
            // BalanceCount
            // 
            this.BalanceCount.AutoSize = true;
            this.BalanceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceCount.Location = new System.Drawing.Point(184, 235);
            this.BalanceCount.Name = "BalanceCount";
            this.BalanceCount.Size = new System.Drawing.Size(36, 39);
            this.BalanceCount.TabIndex = 8;
            this.BalanceCount.Text = "0";
            // 
            // WagerInput
            // 
            this.WagerInput.Location = new System.Drawing.Point(12, 352);
            this.WagerInput.Name = "WagerInput";
            this.WagerInput.Size = new System.Drawing.Size(75, 20);
            this.WagerInput.TabIndex = 9;
            this.WagerInput.Text = "100";
            // 
            // TotalWagered
            // 
            this.TotalWagered.AutoSize = true;
            this.TotalWagered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalWagered.Location = new System.Drawing.Point(12, 9);
            this.TotalWagered.Name = "TotalWagered";
            this.TotalWagered.Size = new System.Drawing.Size(102, 17);
            this.TotalWagered.TabIndex = 10;
            this.TotalWagered.Text = "Total wagered:";
            // 
            // TotalWageredInfo
            // 
            this.TotalWageredInfo.AutoSize = true;
            this.TotalWageredInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalWageredInfo.Location = new System.Drawing.Point(12, 31);
            this.TotalWageredInfo.Name = "TotalWageredInfo";
            this.TotalWageredInfo.Size = new System.Drawing.Size(16, 17);
            this.TotalWageredInfo.TabIndex = 11;
            this.TotalWageredInfo.Text = "0";
            // 
            // Wager
            // 
            this.Wager.AutoSize = true;
            this.Wager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wager.Location = new System.Drawing.Point(9, 328);
            this.Wager.Name = "Wager";
            this.Wager.Size = new System.Drawing.Size(80, 17);
            this.Wager.TabIndex = 12;
            this.Wager.Text = "Your wager";
            // 
            // TotalEarns
            // 
            this.TotalEarns.AutoSize = true;
            this.TotalEarns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalEarns.Location = new System.Drawing.Point(221, 9);
            this.TotalEarns.Name = "TotalEarns";
            this.TotalEarns.Size = new System.Drawing.Size(93, 17);
            this.TotalEarns.TabIndex = 13;
            this.TotalEarns.Text = "Total earned:";
            // 
            // TotalEarnsInfo
            // 
            this.TotalEarnsInfo.AutoEllipsis = true;
            this.TotalEarnsInfo.AutoSize = true;
            this.TotalEarnsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalEarnsInfo.Location = new System.Drawing.Point(221, 31);
            this.TotalEarnsInfo.Name = "TotalEarnsInfo";
            this.TotalEarnsInfo.Size = new System.Drawing.Size(16, 17);
            this.TotalEarnsInfo.TabIndex = 14;
            this.TotalEarnsInfo.Text = "0";
            this.TotalEarnsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 411);
            this.Controls.Add(this.TotalEarnsInfo);
            this.Controls.Add(this.TotalEarns);
            this.Controls.Add(this.Wager);
            this.Controls.Add(this.TotalWageredInfo);
            this.Controls.Add(this.TotalWagered);
            this.Controls.Add(this.WagerInput);
            this.Controls.Add(this.BalanceCount);
            this.Controls.Add(this.AddMoneyButton);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.MoneyInput);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1 = new PictureBox();
        private System.Windows.Forms.PictureBox pictureBox2 = new PictureBox();
        private System.Windows.Forms.PictureBox pictureBox3 = new PictureBox();
        private Button PlayButton;
        private Label ResultLabel;
        private TextBox MoneyInput;
        private Label Balance;
        private Button AddMoneyButton;
        private Label BalanceCount;
        private TextBox WagerInput;
        private Label TotalWagered;
        private Label TotalWageredInfo;
        private Label Wager;
        private Label TotalEarns;
        private Label TotalEarnsInfo;
    }
}

