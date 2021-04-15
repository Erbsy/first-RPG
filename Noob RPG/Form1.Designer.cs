namespace Noob_RPG
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblAnzeigeHPGegner = new System.Windows.Forms.Label();
            this.LblAnzeigeHPSpieler = new System.Windows.Forms.Label();
            this.CmdAngriff = new System.Windows.Forms.Button();
            this.LblAnzeigeGold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(96, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 272);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblAnzeigeHPGegner
            // 
            this.LblAnzeigeHPGegner.AutoSize = true;
            this.LblAnzeigeHPGegner.Location = new System.Drawing.Point(625, 76);
            this.LblAnzeigeHPGegner.Name = "LblAnzeigeHPGegner";
            this.LblAnzeigeHPGegner.Size = new System.Drawing.Size(0, 17);
            this.LblAnzeigeHPGegner.TabIndex = 2;
            this.LblAnzeigeHPGegner.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAnzeigeHPSpieler
            // 
            this.LblAnzeigeHPSpieler.AutoSize = true;
            this.LblAnzeigeHPSpieler.Location = new System.Drawing.Point(156, 35);
            this.LblAnzeigeHPSpieler.Name = "LblAnzeigeHPSpieler";
            this.LblAnzeigeHPSpieler.Size = new System.Drawing.Size(0, 17);
            this.LblAnzeigeHPSpieler.TabIndex = 3;
            // 
            // CmdAngriff
            // 
            this.CmdAngriff.Location = new System.Drawing.Point(377, 366);
            this.CmdAngriff.Name = "CmdAngriff";
            this.CmdAngriff.Size = new System.Drawing.Size(75, 23);
            this.CmdAngriff.TabIndex = 4;
            this.CmdAngriff.Text = "Angriff";
            this.CmdAngriff.UseVisualStyleBackColor = true;
            this.CmdAngriff.Click += new System.EventHandler(this.CmdAngriff_Click);
            // 
            // LblAnzeigeGold
            // 
            this.LblAnzeigeGold.AutoSize = true;
            this.LblAnzeigeGold.Location = new System.Drawing.Point(93, 372);
            this.LblAnzeigeGold.Name = "LblAnzeigeGold";
            this.LblAnzeigeGold.Size = new System.Drawing.Size(0, 17);
            this.LblAnzeigeGold.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeigeGold);
            this.Controls.Add(this.CmdAngriff);
            this.Controls.Add(this.LblAnzeigeHPSpieler);
            this.Controls.Add(this.LblAnzeigeHPGegner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblAnzeigeHPGegner;
        private System.Windows.Forms.Label LblAnzeigeHPSpieler;
        private System.Windows.Forms.Button CmdAngriff;
        private System.Windows.Forms.Label LblAnzeigeGold;
    }
}

