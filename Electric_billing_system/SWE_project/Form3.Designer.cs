namespace SWE_project
{
    partial class ConsumptionPerMonth
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
            this.ConsumptionPerMonth_TextBox = new System.Windows.Forms.TextBox();
            this.ConsumptionPerMonth_Label = new System.Windows.Forms.Label();
            this.ShowConsumption_Button = new System.Windows.Forms.Button();
            this.ChooseMonth_Label = new System.Windows.Forms.Label();
            this.PreviousConsumption_textbox = new System.Windows.Forms.TextBox();
            this.MeterID_textBox = new System.Windows.Forms.TextBox();
            this.MeterID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsumptionPerMonth_TextBox
            // 
            this.ConsumptionPerMonth_TextBox.Location = new System.Drawing.Point(721, 262);
            this.ConsumptionPerMonth_TextBox.Name = "ConsumptionPerMonth_TextBox";
            this.ConsumptionPerMonth_TextBox.Size = new System.Drawing.Size(247, 26);
            this.ConsumptionPerMonth_TextBox.TabIndex = 1;
            // 
            // ConsumptionPerMonth_Label
            // 
            this.ConsumptionPerMonth_Label.AutoSize = true;
            this.ConsumptionPerMonth_Label.Location = new System.Drawing.Point(717, 227);
            this.ConsumptionPerMonth_Label.Name = "ConsumptionPerMonth_Label";
            this.ConsumptionPerMonth_Label.Size = new System.Drawing.Size(168, 20);
            this.ConsumptionPerMonth_Label.TabIndex = 3;
            this.ConsumptionPerMonth_Label.Text = "Current Consumption :";
            // 
            // ShowConsumption_Button
            // 
            this.ShowConsumption_Button.Location = new System.Drawing.Point(471, 385);
            this.ShowConsumption_Button.Name = "ShowConsumption_Button";
            this.ShowConsumption_Button.Size = new System.Drawing.Size(152, 38);
            this.ShowConsumption_Button.TabIndex = 4;
            this.ShowConsumption_Button.Text = "Show";
            this.ShowConsumption_Button.UseVisualStyleBackColor = true;
            this.ShowConsumption_Button.Click += new System.EventHandler(this.ShowConsumption_Button_Click);
            // 
            // ChooseMonth_Label
            // 
            this.ChooseMonth_Label.AutoSize = true;
            this.ChooseMonth_Label.Location = new System.Drawing.Point(717, 142);
            this.ChooseMonth_Label.Name = "ChooseMonth_Label";
            this.ChooseMonth_Label.Size = new System.Drawing.Size(175, 20);
            this.ChooseMonth_Label.TabIndex = 2;
            this.ChooseMonth_Label.Text = "Previous Consumption :";
            // 
            // PreviousConsumption_textbox
            // 
            this.PreviousConsumption_textbox.Location = new System.Drawing.Point(721, 177);
            this.PreviousConsumption_textbox.Name = "PreviousConsumption_textbox";
            this.PreviousConsumption_textbox.Size = new System.Drawing.Size(247, 26);
            this.PreviousConsumption_textbox.TabIndex = 5;
            // 
            // MeterID_textBox
            // 
            this.MeterID_textBox.Location = new System.Drawing.Point(136, 177);
            this.MeterID_textBox.Name = "MeterID_textBox";
            this.MeterID_textBox.Size = new System.Drawing.Size(247, 26);
            this.MeterID_textBox.TabIndex = 7;
            // 
            // MeterID_label
            // 
            this.MeterID_label.AutoSize = true;
            this.MeterID_label.Location = new System.Drawing.Point(132, 142);
            this.MeterID_label.Name = "MeterID_label";
            this.MeterID_label.Size = new System.Drawing.Size(71, 20);
            this.MeterID_label.TabIndex = 6;
            this.MeterID_label.Text = "Meter ID";
            // 
            // ConsumptionPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 618);
            this.Controls.Add(this.MeterID_textBox);
            this.Controls.Add(this.MeterID_label);
            this.Controls.Add(this.PreviousConsumption_textbox);
            this.Controls.Add(this.ShowConsumption_Button);
            this.Controls.Add(this.ConsumptionPerMonth_Label);
            this.Controls.Add(this.ChooseMonth_Label);
            this.Controls.Add(this.ConsumptionPerMonth_TextBox);
            this.Name = "ConsumptionPerMonth";
            this.Text = "Consumption Per Month";
            this.Load += new System.EventHandler(this.ConsumptionPerMonth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ConsumptionPerMonth_TextBox;
        private System.Windows.Forms.Label ConsumptionPerMonth_Label;
        private System.Windows.Forms.Button ShowConsumption_Button;
        private System.Windows.Forms.Label ChooseMonth_Label;
        private System.Windows.Forms.TextBox PreviousConsumption_textbox;
        private System.Windows.Forms.TextBox MeterID_textBox;
        private System.Windows.Forms.Label MeterID_label;
    }
}