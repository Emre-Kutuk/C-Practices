namespace Exercise_6
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(280, 91);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(277, 327);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "_____";
            this.lblResult.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(90, 181);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(290, 23);
            this.btnReference.TabIndex = 4;
            this.btnReference.Text = "Square by Reference";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.BtnReference_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(90, 210);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(290, 23);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Square by Reference Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(90, 239);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(290, 23);
            this.btnValue.TabIndex = 6;
            this.btnValue.Text = "Square by Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.BtnValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber);
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
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnValue;
    }
}

