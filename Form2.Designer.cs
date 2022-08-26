namespace Bank_account_Creative
{
    partial class Form2
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(289, 147);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(103, 33);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(63, 147);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(90, 33);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(45, 120);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 21);
            this.txtInput.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(80, 104);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Enter amount:";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(279, 120);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(124, 20);
            this.txtInput2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter amount in bank account:";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(114, 29);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(150, 20);
            this.txtAcc.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcc;
    }
}