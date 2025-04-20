namespace StevecKlikov
{
    partial class Form1
    {
        /// <summary>
        /// Potrebne komponente.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Čiščenje virov, ki jih uporablja komponenta.
        /// </summary>
        /// <param name="disposing">true, če je treba upravljane vire odstraniti; sicer false.</param>
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
        /// Potrebna metoda za podporo Designerja – je ne spreminjaj ročno s kodo!
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCounter.Location = new System.Drawing.Point(34, 32);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(123, 27);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "Število klikov: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 160);
            this.Controls.Add(this.labelCounter);
            this.Name = "Form1";
            this.Text = "Števec klikov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
    }
}

