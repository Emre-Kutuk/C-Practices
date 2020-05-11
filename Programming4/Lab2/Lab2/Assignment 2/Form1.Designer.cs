namespace ConwayGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lbl_currentlf = new System.Windows.Forms.Label();
            this.btn_sl = new System.Windows.Forms.Button();
            this.btn_hl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(12, 702);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(141, 37);
            this.btnResetGame.TabIndex = 0;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl_currentlf
            // 
            this.lbl_currentlf.AutoSize = true;
            this.lbl_currentlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentlf.Location = new System.Drawing.Point(547, 720);
            this.lbl_currentlf.Name = "lbl_currentlf";
            this.lbl_currentlf.Size = new System.Drawing.Size(151, 13);
            this.lbl_currentlf.TabIndex = 1;
            this.lbl_currentlf.Text = "Current Life Form : _____";
            this.lbl_currentlf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_sl
            // 
            this.btn_sl.Location = new System.Drawing.Point(227, 710);
            this.btn_sl.Name = "btn_sl";
            this.btn_sl.Size = new System.Drawing.Size(75, 23);
            this.btn_sl.TabIndex = 2;
            this.btn_sl.Text = "Standart Life";
            this.btn_sl.UseVisualStyleBackColor = true;
            this.btn_sl.Click += new System.EventHandler(this.btn_sl_Click);
            // 
            // btn_hl
            // 
            this.btn_hl.Location = new System.Drawing.Point(334, 710);
            this.btn_hl.Name = "btn_hl";
            this.btn_hl.Size = new System.Drawing.Size(75, 23);
            this.btn_hl.TabIndex = 3;
            this.btn_hl.Text = "High Life";
            this.btn_hl.UseVisualStyleBackColor = true;
            this.btn_hl.Click += new System.EventHandler(this.btn_hl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 751);
            this.Controls.Add(this.btn_hl);
            this.Controls.Add(this.btn_sl);
            this.Controls.Add(this.lbl_currentlf);
            this.Controls.Add(this.btnResetGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Conway\'s Game Of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lbl_currentlf;
        private System.Windows.Forms.Button btn_sl;
        private System.Windows.Forms.Button btn_hl;
    }
}

