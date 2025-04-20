namespace LeviInDesni
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnLevi = new System.Windows.Forms.Button();
            this.labelNapis = new System.Windows.Forms.Label();
            this.btnDesni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevi
            // 
            this.btnLevi.Location = new System.Drawing.Point(30, 30);
            this.btnLevi.Name = "btnLevi";
            this.btnLevi.Size = new System.Drawing.Size(75, 23);
            this.btnLevi.TabIndex = 0;
            this.btnLevi.Text = "Levi";
            this.btnLevi.UseVisualStyleBackColor = true;
            this.btnLevi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLevi_MouseDown);
            this.btnLevi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLevi_MouseUp);
            // 
            // labelNapis
            // 
            this.labelNapis.AutoSize = true;
            this.labelNapis.Location = new System.Drawing.Point(130, 35);
            this.labelNapis.Name = "labelNapis";
            this.labelNapis.Size = new System.Drawing.Size(0, 15);
            this.labelNapis.TabIndex = 1;
            // 
            // btnDesni
            // 
            this.btnDesni.Location = new System.Drawing.Point(230, 30);
            this.btnDesni.Name = "btnDesni";
            this.btnDesni.Size = new System.Drawing.Size(75, 23);
            this.btnDesni.TabIndex = 2;
            this.btnDesni.Text = "Desni";
            this.btnDesni.UseVisualStyleBackColor = true;
            this.btnDesni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDesni_MouseDown);
            this.btnDesni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDesni_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(334, 81);
            this.Controls.Add(this.btnDesni);
            this.Controls.Add(this.labelNapis);
            this.Controls.Add(this.btnLevi);
            this.Name = "Form1";
            this.Text = "Levi in desni";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLevi;
        private System.Windows.Forms.Label labelNapis;
        private System.Windows.Forms.Button btnDesni;
    }
}
