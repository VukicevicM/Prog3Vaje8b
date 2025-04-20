namespace MetanjeKocke
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Button btnRoll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDice = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblDice
            // 
            this.lblDice.BackColor = System.Drawing.Color.White;
            this.lblDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblDice.Size = new System.Drawing.Size(100, 100);
            this.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDice.Name = "lblDice";
            this.lblDice.TabIndex = 0;
            this.lblDice.Visible = false;

            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRoll.Size = new System.Drawing.Size(120, 50);
            this.btnRoll.Text = "Vrzi kocko";
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.TabIndex = 1;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Metanje Kocke";

            // Manually center the button
            this.Load += (sender, e) =>
            {
                btnRoll.Location = new System.Drawing.Point(
                    (this.ClientSize.Width - btnRoll.Width) / 2,
                    this.ClientSize.Height - btnRoll.Height - 20
                );
            };

            this.ResumeLayout(false);
        }
    }
}

