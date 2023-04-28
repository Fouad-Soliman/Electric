namespace WindowsFormsApp1
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
            this.Cash_rdio = new System.Windows.Forms.RadioButton();
            this.creditCard_rdio = new System.Windows.Forms.RadioButton();
            this.pay_button = new System.Windows.Forms.Button();
            this.meter_choice = new System.Windows.Forms.ComboBox();
            this.current = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cash_rdio
            // 
            this.Cash_rdio.AutoSize = true;
            this.Cash_rdio.Location = new System.Drawing.Point(57, 113);
            this.Cash_rdio.Name = "Cash_rdio";
            this.Cash_rdio.Size = new System.Drawing.Size(49, 17);
            this.Cash_rdio.TabIndex = 0;
            this.Cash_rdio.TabStop = true;
            this.Cash_rdio.Text = "Cash";
            this.Cash_rdio.UseVisualStyleBackColor = true;
            // 
            // creditCard_rdio
            // 
            this.creditCard_rdio.AutoSize = true;
            this.creditCard_rdio.Location = new System.Drawing.Point(57, 148);
            this.creditCard_rdio.Name = "creditCard_rdio";
            this.creditCard_rdio.Size = new System.Drawing.Size(109, 17);
            this.creditCard_rdio.TabIndex = 1;
            this.creditCard_rdio.TabStop = true;
            this.creditCard_rdio.Text = "pay by credit card";
            this.creditCard_rdio.UseVisualStyleBackColor = true;
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(78, 232);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(75, 23);
            this.pay_button.TabIndex = 2;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // meter_choice
            // 
            this.meter_choice.FormattingEnabled = true;
            this.meter_choice.Location = new System.Drawing.Point(90, 57);
            this.meter_choice.Name = "meter_choice";
            this.meter_choice.Size = new System.Drawing.Size(121, 21);
            this.meter_choice.TabIndex = 3;
            this.meter_choice.SelectedIndexChanged += new System.EventHandler(this.meter_choice_SelectedIndexChanged);
            // 
            // current
            // 
            this.current.Location = new System.Drawing.Point(597, 86);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(100, 20);
            this.current.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "current reading";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Meter ID";
            // 
            // fees
            // 
            this.fees.Location = new System.Drawing.Point(597, 123);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(100, 20);
            this.fees.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fees";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.current);
            this.Controls.Add(this.meter_choice);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.creditCard_rdio);
            this.Controls.Add(this.Cash_rdio);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Cash_rdio;
        private System.Windows.Forms.RadioButton creditCard_rdio;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.ComboBox meter_choice;
        private System.Windows.Forms.TextBox current;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.Label label1;
    }
}