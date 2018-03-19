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
            this.EnterBalance = new System.Windows.Forms.TextBox();
            this.Cash = new System.Windows.Forms.Label();
            this.EnterMoney = new System.Windows.Forms.Button();
            this.Cash2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(118, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(224, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(224, 238);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Spin";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(221, 82);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(32, 17);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "123";
            this.ResultLabel.Click += new System.EventHandler(this.ResultText_Click);
            // 
            // EnterBalance
            // 
            this.EnterBalance.Location = new System.Drawing.Point(12, 169);
            this.EnterBalance.Name = "EnterBalance";
            this.EnterBalance.Size = new System.Drawing.Size(100, 20);
            this.EnterBalance.TabIndex = 5;
            this.EnterBalance.Text = "100";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cash.Location = new System.Drawing.Point(12, 82);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(150, 39);
            this.Cash.TabIndex = 6;
            this.Cash.Text = "Balance:";
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // EnterMoney
            // 
            this.EnterMoney.Location = new System.Drawing.Point(12, 195);
            this.EnterMoney.Name = "EnterMoney";
            this.EnterMoney.Size = new System.Drawing.Size(75, 23);
            this.EnterMoney.TabIndex = 7;
            this.EnterMoney.Text = "Enter";
            this.EnterMoney.UseVisualStyleBackColor = true;
            this.EnterMoney.Click += new System.EventHandler(this.EnterMoney_Click);
            // 
            // Cash2
            // 
            this.Cash2.AutoSize = true;
            this.Cash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cash2.Location = new System.Drawing.Point(156, 82);
            this.Cash2.Name = "Cash2";
            this.Cash2.Size = new System.Drawing.Size(0, 39);
            this.Cash2.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 320);
            this.Controls.Add(this.Cash2);
            this.Controls.Add(this.EnterMoney);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.EnterBalance);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slots";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
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
        private TextBox EnterBalance;
        private Label Cash;
        private Button EnterMoney;
        private Label Cash2;
    }
}

