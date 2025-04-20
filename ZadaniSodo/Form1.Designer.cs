namespace ZadaniSodo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label clicksLabel;
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numberButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.clicksLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // numberButton
            this.numberButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numberButton.Location = new System.Drawing.Point(100, 30);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(100, 50);
            this.numberButton.TabIndex = 0;
            this.numberButton.Text = "0";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.Click += new System.EventHandler(this.numberButton_Click);

            // scoreLabel
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(100, 100);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(67, 15);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Točke: 0";

            // clicksLabel
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.Location = new System.Drawing.Point(100, 125);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(76, 15);
            this.clicksLabel.TabIndex = 2;
            this.clicksLabel.Text = "Kliki: 0";

            // timer
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.numberButton);
            this.Name = "Form1";
            this.Text = "Številčni Gumb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

