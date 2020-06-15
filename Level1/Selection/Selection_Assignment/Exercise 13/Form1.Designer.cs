namespace Exercise_13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRentDays = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtLiter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chckRefuel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rental days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of kms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of liters tanked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rental Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(363, 340);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "_____";
            // 
            // txtRentDays
            // 
            this.txtRentDays.Location = new System.Drawing.Point(366, 74);
            this.txtRentDays.Name = "txtRentDays";
            this.txtRentDays.Size = new System.Drawing.Size(100, 20);
            this.txtRentDays.TabIndex = 5;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(366, 129);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 6;
            // 
            // txtLiter
            // 
            this.txtLiter.Location = new System.Drawing.Point(366, 233);
            this.txtLiter.Name = "txtLiter";
            this.txtLiter.Size = new System.Drawing.Size(100, 20);
            this.txtLiter.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Rental Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chckRefuel
            // 
            this.chckRefuel.AutoSize = true;
            this.chckRefuel.Location = new System.Drawing.Point(117, 182);
            this.chckRefuel.Name = "chckRefuel";
            this.chckRefuel.Size = new System.Drawing.Size(156, 17);
            this.chckRefuel.TabIndex = 9;
            this.chckRefuel.Text = "Refuel on accounf of renter";
            this.chckRefuel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 440);
            this.Controls.Add(this.chckRefuel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLiter);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtRentDays);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRentDays;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtLiter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chckRefuel;
    }
}

