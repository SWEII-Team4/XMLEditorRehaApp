namespace XML_Editor
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
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.tbBild = new System.Windows.Forms.TextBox();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblBild = new System.Windows.Forms.Label();
            this.lblBeschreibung = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.ibBild = new System.Windows.Forms.PictureBox();
            this.lblTxt = new System.Windows.Forms.Label();
            this.btnLaden = new System.Windows.Forms.Button();
            this.ofdDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ibBild)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(575, 371);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 0;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(87, 274);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(333, 108);
            this.tbText.TabIndex = 1;
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Location = new System.Drawing.Point(87, 162);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.Size = new System.Drawing.Size(323, 56);
            this.tbBeschreibung.TabIndex = 1;
            // 
            // tbBild
            // 
            this.tbBild.Location = new System.Drawing.Point(87, 237);
            this.tbBild.Name = "tbBild";
            this.tbBild.Size = new System.Drawing.Size(284, 20);
            this.tbBild.TabIndex = 1;
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(86, 121);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(323, 20);
            this.tbTitel.TabIndex = 2;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(53, 128);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Titel";
            // 
            // lblBild
            // 
            this.lblBild.AutoSize = true;
            this.lblBild.Location = new System.Drawing.Point(57, 237);
            this.lblBild.Name = "lblBild";
            this.lblBild.Size = new System.Drawing.Size(24, 13);
            this.lblBild.TabIndex = 5;
            this.lblBild.Text = "Bild";
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Location = new System.Drawing.Point(9, 162);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(72, 13);
            this.lblBeschreibung.TabIndex = 6;
            this.lblBeschreibung.Text = "Beschreibung";
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 23);
            this.lblText.TabIndex = 0;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(388, 237);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(32, 20);
            this.btnOpenImage.TabIndex = 8;
            this.btnOpenImage.Text = "...";
            this.btnOpenImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // ibBild
            // 
            this.ibBild.Image = ((System.Drawing.Image)(resources.GetObject("ibBild.Image")));
            this.ibBild.InitialImage = ((System.Drawing.Image)(resources.GetObject("ibBild.InitialImage")));
            this.ibBild.Location = new System.Drawing.Point(447, 121);
            this.ibBild.Name = "ibBild";
            this.ibBild.Size = new System.Drawing.Size(203, 222);
            this.ibBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibBild.TabIndex = 10;
            this.ibBild.TabStop = false;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(45, 274);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(28, 13);
            this.lblTxt.TabIndex = 11;
            this.lblTxt.Text = "Text";
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(494, 371);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(75, 23);
            this.btnLaden.TabIndex = 12;
            this.btnLaden.Text = "(neu)Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // ofdDialog
            // 
            this.ofdDialog.InitialDirectory = "C:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.ibBild);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.lblBeschreibung);
            this.Controls.Add(this.lblBild);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.tbBild);
            this.Controls.Add(this.tbBeschreibung);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSpeichern);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "XML Editor 4 RehaApp (by Team 4)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.TextBox tbBild;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblBild;
        private System.Windows.Forms.Label lblBeschreibung;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox ibBild;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.OpenFileDialog ofdDialog;
    }
}

