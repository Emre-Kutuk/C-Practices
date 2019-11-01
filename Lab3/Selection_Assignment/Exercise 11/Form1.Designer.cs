namespace Exercise_11
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
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblDif = new System.Windows.Forms.Label();
            this.txtNr1 = new System.Windows.Forms.TextBox();
            this.txtNr2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Highest Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Difference";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(341, 205);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(37, 13);
            this.lblHighest.TabIndex = 5;
            this.lblHighest.Text = "_____";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(341, 247);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(37, 13);
            this.lblAvg.TabIndex = 6;
            this.lblAvg.Text = "_____";
            // 
            // lblDif
            // 
            this.lblDif.AutoSize = true;
            this.lblDif.Location = new System.Drawing.Point(341, 288);
            this.lblDif.Name = "lblDif";
            this.lblDif.Size = new System.Drawing.Size(37, 13);
            this.lblDif.TabIndex = 7;
            this.lblDif.Text = "_____";
            // 
            // txtNr1
            // 
            this.txtNr1.Location = new System.Drawing.Point(276, 57);
            this.txtNr1.Name = "txtNr1";
            this.txtNr1.Size = new System.Drawing.Size(100, 20);
            this.txtNr1.TabIndex = 8;
            // 
            // txtNr2
            // 
            this.txtNr2.Location = new System.Drawing.Point(276, 106);
            this.txtNr2.Name = "txtNr2";
            this.txtNr2.Size = new System.Drawing.Size(100, 20);
            this.txtNr2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNr2);
            this.Controls.Add(this.txtNr1);
            this.Controls.Add(this.lblDif);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblDif;
        private System.Windows.Forms.TextBox txtNr1;
        private System.Windows.Forms.TextBox txtNr2;
        private System.Windows.Forms.Button button1;
    }
}

