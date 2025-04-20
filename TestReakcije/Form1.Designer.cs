namespace TestReakcije
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReactionTime;
        private System.Windows.Forms.Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblReactionTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblReactionTime
            // 
            this.lblReactionTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReactionTime.AutoSize = true;
            this.lblReactionTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblReactionTime.Location = new System.Drawing.Point(100, 100); // Adjust center in runtime
            this.lblReactionTime.Name = "lblReactionTime";
            this.lblReactionTime.Size = new System.Drawing.Size(300, 54);
            this.lblReactionTime.TabIndex = 0;
            this.lblReactionTime.Text = "Čas reakcije:";
            this.lblReactionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(170, 180); // Adjust center in runtime
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Še enkrat?";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblReactionTime);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Test Časa Reakcije";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

