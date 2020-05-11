namespace Assignment_1
{
    partial class ControlPanel
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
            this.btnNewForm = new System.Windows.Forms.Button();
            this.btnNextStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewForm
            // 
            this.btnNewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewForm.Location = new System.Drawing.Point(12, 155);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(121, 43);
            this.btnNewForm.TabIndex = 0;
            this.btnNewForm.Text = "New Display";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // btnNextStation
            // 
            this.btnNextStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStation.Location = new System.Drawing.Point(103, 50);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(156, 64);
            this.btnNextStation.TabIndex = 1;
            this.btnNextStation.Text = "Next Station";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.btnNextStation_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 210);
            this.Controls.Add(this.btnNextStation);
            this.Controls.Add(this.btnNewForm);
            this.Name = "ControlPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewForm;
        private System.Windows.Forms.Button btnNextStation;
    }
}

