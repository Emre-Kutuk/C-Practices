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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnCtoK = new System.Windows.Forms.RadioButton();
            this.bttnCtoF = new System.Windows.Forms.RadioButton();
            this.bttnFtoC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converted Degrees";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(400, 347);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "_____";
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(335, 66);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(100, 20);
            this.txtDegree.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bttnCtoK
            // 
            this.bttnCtoK.AutoSize = true;
            this.bttnCtoK.Location = new System.Drawing.Point(197, 118);
            this.bttnCtoK.Name = "bttnCtoK";
            this.bttnCtoK.Size = new System.Drawing.Size(102, 17);
            this.bttnCtoK.TabIndex = 8;
            this.bttnCtoK.TabStop = true;
            this.bttnCtoK.Text = "Celsius to Kelvin";
            this.bttnCtoK.UseVisualStyleBackColor = true;
            // 
            // bttnCtoF
            // 
            this.bttnCtoF.AutoSize = true;
            this.bttnCtoF.Location = new System.Drawing.Point(197, 160);
            this.bttnCtoF.Name = "bttnCtoF";
            this.bttnCtoF.Size = new System.Drawing.Size(124, 17);
            this.bttnCtoF.TabIndex = 9;
            this.bttnCtoF.TabStop = true;
            this.bttnCtoF.Text = "Celcius to Fahrenheit";
            this.bttnCtoF.UseVisualStyleBackColor = true;
            // 
            // bttnFtoC
            // 
            this.bttnFtoC.AutoSize = true;
            this.bttnFtoC.Location = new System.Drawing.Point(197, 202);
            this.bttnFtoC.Name = "bttnFtoC";
            this.bttnFtoC.Size = new System.Drawing.Size(124, 17);
            this.bttnFtoC.TabIndex = 10;
            this.bttnFtoC.TabStop = true;
            this.bttnFtoC.Text = "Fahrenheit to Celcius";
            this.bttnFtoC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.bttnFtoC);
            this.Controls.Add(this.bttnCtoF);
            this.Controls.Add(this.bttnCtoK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.lblResult);
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton bttnCtoK;
        private System.Windows.Forms.RadioButton bttnCtoF;
        private System.Windows.Forms.RadioButton bttnFtoC;
    }
}

