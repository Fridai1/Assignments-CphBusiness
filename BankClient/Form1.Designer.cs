namespace BankClient
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Deopsit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.AmountValue = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.FundsLabel = new System.Windows.Forms.Label();
            this.FundsValue = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(442, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 489);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Deopsit
            // 
            this.Deopsit.Location = new System.Drawing.Point(46, 126);
            this.Deopsit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deopsit.Name = "Deopsit";
            this.Deopsit.Size = new System.Drawing.Size(83, 38);
            this.Deopsit.TabIndex = 1;
            this.Deopsit.Text = "Deposit";
            this.Deopsit.UseVisualStyleBackColor = true;
            this.Deopsit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(132, 126);
            this.Withdraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(83, 38);
            this.Withdraw.TabIndex = 2;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // AmountValue
            // 
            this.AmountValue.Location = new System.Drawing.Point(46, 107);
            this.AmountValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountValue.Name = "AmountValue";
            this.AmountValue.Size = new System.Drawing.Size(126, 20);
            this.AmountValue.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(44, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "name";
            // 
            // FundsLabel
            // 
            this.FundsLabel.AutoSize = true;
            this.FundsLabel.Location = new System.Drawing.Point(44, 55);
            this.FundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FundsLabel.Name = "FundsLabel";
            this.FundsLabel.Size = new System.Drawing.Size(36, 13);
            this.FundsLabel.TabIndex = 5;
            this.FundsLabel.Text = "Funds";
            // 
            // FundsValue
            // 
            this.FundsValue.AutoSize = true;
            this.FundsValue.Location = new System.Drawing.Point(126, 55);
            this.FundsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FundsValue.Name = "FundsValue";
            this.FundsValue.Size = new System.Drawing.Size(27, 13);
            this.FundsValue.TabIndex = 6;
            this.FundsValue.Text = "N/A";
            // 
            // NameValue
            // 
            this.NameValue.AutoSize = true;
            this.NameValue.Location = new System.Drawing.Point(126, 27);
            this.NameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(27, 13);
            this.NameValue.TabIndex = 7;
            this.NameValue.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 518);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.FundsValue);
            this.Controls.Add(this.FundsLabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.AmountValue);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deopsit);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Deopsit;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.TextBox AmountValue;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label FundsLabel;
        private System.Windows.Forms.Label FundsValue;
        private System.Windows.Forms.Label NameValue;
    }
}

