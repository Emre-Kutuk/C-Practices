namespace Exercise_9
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDur = new System.Windows.Forms.TextBox();
            this.BttnFootball = new System.Windows.Forms.RadioButton();
            this.BttnHandball = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Membership Duration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate Fee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fee to be Paid";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(335, 389);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "________";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(293, 149);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 6;
            // 
            // txtDur
            // 
            this.txtDur.Location = new System.Drawing.Point(293, 211);
            this.txtDur.Name = "txtDur";
            this.txtDur.Size = new System.Drawing.Size(100, 20);
            this.txtDur.TabIndex = 7;
            this.txtDur.TextChanged += new System.EventHandler(this.TxtDur_TextChanged);
            // 
            // BttnFootball
            // 
            this.BttnFootball.AutoSize = true;
            this.BttnFootball.Location = new System.Drawing.Point(308, 56);
            this.BttnFootball.Name = "BttnFootball";
            this.BttnFootball.Size = new System.Drawing.Size(62, 17);
            this.BttnFootball.TabIndex = 8;
            this.BttnFootball.TabStop = true;
            this.BttnFootball.Text = "Football";
            this.BttnFootball.UseVisualStyleBackColor = true;
            this.BttnFootball.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // BttnHandball
            // 
            this.BttnHandball.AutoSize = true;
            this.BttnHandball.Location = new System.Drawing.Point(308, 79);
            this.BttnHandball.Name = "BttnHandball";
            this.BttnHandball.Size = new System.Drawing.Size(67, 17);
            this.BttnHandball.TabIndex = 9;
            this.BttnHandball.TabStop = true;
            this.BttnHandball.Text = "Handball";
            this.BttnHandball.UseVisualStyleBackColor = true;
            this.BttnHandball.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttnHandball);
            this.Controls.Add(this.BttnFootball);
            this.Controls.Add(this.txtDur);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDur;
        private System.Windows.Forms.RadioButton BttnFootball;
        private System.Windows.Forms.RadioButton BttnHandball;
    }
}

