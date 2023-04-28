namespace WindowsFormsApp1
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
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(103, 63);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(475, 20);
            this.Username_Textbox.TabIndex = 0;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(103, 99);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(475, 20);
            this.Password_Textbox.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(305, 171);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "button1";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Location = new System.Drawing.Point(302, 135);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(0, 13);
            this.Error_label.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Error_label;
    }
}

