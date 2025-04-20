namespace VozecaPloscad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.toggleButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.Location = new System.Drawing.Point(12, 12);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(320, 60);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);

            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(12, 80);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(75, 23);
            this.toggleButton.TabIndex = 1;
            this.toggleButton.Text = "Gibanje";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.ToggleButton_Click);

            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.canvasPanel);
            this.Name = "Form1";
            this.Text = "Ploščad";

            this.ResumeLayout(false);
        }

        #endregion
    }
}