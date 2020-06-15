namespace Exercise_5
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
            this.bttn5km = new System.Windows.Forms.RadioButton();
            this.bttn10km = new System.Windows.Forms.RadioButton();
            this.bttn21km = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHr = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtSc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn5km
            // 
            this.bttn5km.AutoSize = true;
            this.bttn5km.Location = new System.Drawing.Point(28, 98);
            this.bttn5km.Name = "bttn5km";
            this.bttn5km.Size = new System.Drawing.Size(48, 17);
            this.bttn5km.TabIndex = 0;
            this.bttn5km.TabStop = true;
            this.bttn5km.Text = "5 km";
            this.bttn5km.UseVisualStyleBackColor = true;
            // 
            // bttn10km
            // 
            this.bttn10km.AutoSize = true;
            this.bttn10km.Location = new System.Drawing.Point(202, 98);
            this.bttn10km.Name = "bttn10km";
            this.bttn10km.Size = new System.Drawing.Size(54, 17);
            this.bttn10km.TabIndex = 1;
            this.bttn10km.TabStop = true;
            this.bttn10km.Text = "10 km";
            this.bttn10km.UseVisualStyleBackColor = true;
            // 
            // bttn21km
            // 
            this.bttn21km.AutoSize = true;
            this.bttn21km.Location = new System.Drawing.Point(378, 98);
            this.bttn21km.Name = "bttn21km";
            this.bttn21km.Size = new System.Drawing.Size(54, 17);
            this.bttn21km.TabIndex = 2;
            this.bttn21km.TabStop = true;
            this.bttn21km.Text = "21 km";
            this.bttn21km.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "hh:mm:ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed (km/hr)";
            // 
            // txtHr
            // 
            this.txtHr.Location = new System.Drawing.Point(181, 174);
            this.txtHr.Name = "txtHr";
            this.txtHr.Size = new System.Drawing.Size(44, 20);
            this.txtHr.TabIndex = 5;
            // 
            // txtMn
            // 
            this.txtMn.Location = new System.Drawing.Point(253, 174);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(44, 20);
            this.txtMn.TabIndex = 6;
            // 
            // txtSc
            // 
            this.txtSc.Location = new System.Drawing.Point(317, 174);
            this.txtSc.Name = "txtSc";
            this.txtSc.Size = new System.Drawing.Size(44, 20);
            this.txtSc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(306, 354);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(61, 13);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "_________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSc);
            this.Controls.Add(this.txtMn);
            this.Controls.Add(this.txtHr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn21km);
            this.Controls.Add(this.bttn10km);
            this.Controls.Add(this.bttn5km);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bttn5km;
        private System.Windows.Forms.RadioButton bttn10km;
        private System.Windows.Forms.RadioButton bttn21km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHr;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.TextBox txtSc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSpeed;
    }
}

