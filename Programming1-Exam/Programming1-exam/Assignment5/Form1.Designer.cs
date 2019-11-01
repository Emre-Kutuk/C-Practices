namespace Assignment5
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
            this.bttn2nd = new System.Windows.Forms.RadioButton();
            this.bttn1st = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtRail = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn2nd
            // 
            this.bttn2nd.AutoSize = true;
            this.bttn2nd.Location = new System.Drawing.Point(150, 76);
            this.bttn2nd.Name = "bttn2nd";
            this.bttn2nd.Size = new System.Drawing.Size(71, 17);
            this.bttn2nd.TabIndex = 0;
            this.bttn2nd.TabStop = true;
            this.bttn2nd.Text = "2nd Class";
            this.bttn2nd.UseVisualStyleBackColor = true;
            this.bttn2nd.CheckedChanged += new System.EventHandler(this.Bttn2nd_CheckedChanged);
            // 
            // bttn1st
            // 
            this.bttn1st.AutoSize = true;
            this.bttn1st.Location = new System.Drawing.Point(256, 76);
            this.bttn1st.Name = "bttn1st";
            this.bttn1st.Size = new System.Drawing.Size(67, 17);
            this.bttn1st.TabIndex = 1;
            this.bttn1st.TabStop = true;
            this.bttn1st.Text = "1st Class";
            this.bttn1st.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nr of Tickets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Railrunner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(150, 130);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(100, 20);
            this.txtTickets.TabIndex = 6;
            // 
            // txtRail
            // 
            this.txtRail.Location = new System.Drawing.Point(150, 182);
            this.txtRail.Name = "txtRail";
            this.txtRail.Size = new System.Drawing.Size(100, 20);
            this.txtRail.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(147, 368);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtRail);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn1st);
            this.Controls.Add(this.bttn2nd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bttn2nd;
        private System.Windows.Forms.RadioButton bttn1st;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtRail;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button button1;
    }
}

