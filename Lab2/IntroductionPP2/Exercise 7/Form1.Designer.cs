namespace Exercise_7
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.txtPriceKm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPriceNoVat = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblPriceYesVat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price excl VAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price incl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price / KM";
            // 
            // txtStartKm
            // 
            this.txtStartKm.Location = new System.Drawing.Point(349, 152);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(100, 20);
            this.txtStartKm.TabIndex = 6;
            // 
            // txtEndKm
            // 
            this.txtEndKm.Location = new System.Drawing.Point(349, 188);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(100, 20);
            this.txtEndKm.TabIndex = 7;
            // 
            // txtPriceKm
            // 
            this.txtPriceKm.Location = new System.Drawing.Point(349, 223);
            this.txtPriceKm.Name = "txtPriceKm";
            this.txtPriceKm.Size = new System.Drawing.Size(100, 20);
            this.txtPriceKm.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Erase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblPriceNoVat
            // 
            this.lblPriceNoVat.AutoSize = true;
            this.lblPriceNoVat.Location = new System.Drawing.Point(229, 382);
            this.lblPriceNoVat.Name = "lblPriceNoVat";
            this.lblPriceNoVat.Size = new System.Drawing.Size(22, 13);
            this.lblPriceNoVat.TabIndex = 11;
            this.lblPriceNoVat.Text = ".. ..";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(373, 382);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(22, 13);
            this.lblVat.TabIndex = 12;
            this.lblVat.Text = ".. ..";
            // 
            // lblPriceYesVat
            // 
            this.lblPriceYesVat.AutoSize = true;
            this.lblPriceYesVat.Location = new System.Drawing.Point(518, 382);
            this.lblPriceYesVat.Name = "lblPriceYesVat";
            this.lblPriceYesVat.Size = new System.Drawing.Size(22, 13);
            this.lblPriceYesVat.TabIndex = 13;
            this.lblPriceYesVat.Text = ".. ..";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(734, 13);
            this.label10.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 529);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPriceYesVat);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblPriceNoVat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPriceKm);
            this.Controls.Add(this.txtEndKm);
            this.Controls.Add(this.txtStartKm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.TextBox txtPriceKm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPriceNoVat;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblPriceYesVat;
        private System.Windows.Forms.Label label10;
    }
}

