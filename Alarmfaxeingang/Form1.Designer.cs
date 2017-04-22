namespace Alarmfaxeingang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtTicks = new System.Windows.Forms.TextBox();
            this.txtVerlauf = new System.Windows.Forms.TextBox();
            this.buttonMinimieren = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtEingang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZiel = new System.Windows.Forms.TextBox();
            this.buttonEingang = new System.Windows.Forms.Button();
            this.buttonZiel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonArchiv = new System.Windows.Forms.Button();
            this.txtArchiv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtTicks
            // 
            this.txtTicks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicks.Location = new System.Drawing.Point(12, 12);
            this.txtTicks.Name = "txtTicks";
            this.txtTicks.ReadOnly = true;
            this.txtTicks.Size = new System.Drawing.Size(360, 20);
            this.txtTicks.TabIndex = 0;
            // 
            // txtVerlauf
            // 
            this.txtVerlauf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerlauf.Location = new System.Drawing.Point(12, 116);
            this.txtVerlauf.Multiline = true;
            this.txtVerlauf.Name = "txtVerlauf";
            this.txtVerlauf.Size = new System.Drawing.Size(360, 203);
            this.txtVerlauf.TabIndex = 1;
            // 
            // buttonMinimieren
            // 
            this.buttonMinimieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimieren.Location = new System.Drawing.Point(155, 325);
            this.buttonMinimieren.Name = "buttonMinimieren";
            this.buttonMinimieren.Size = new System.Drawing.Size(75, 23);
            this.buttonMinimieren.TabIndex = 2;
            this.buttonMinimieren.Text = "Minimieren";
            this.buttonMinimieren.UseVisualStyleBackColor = true;
            this.buttonMinimieren.Click += new System.EventHandler(this.buttonMinimieren_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // txtEingang
            // 
            this.txtEingang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEingang.Location = new System.Drawing.Point(64, 38);
            this.txtEingang.Name = "txtEingang";
            this.txtEingang.Size = new System.Drawing.Size(254, 20);
            this.txtEingang.TabIndex = 3;
            this.txtEingang.Text = "C:\\Fax\\PDF_Eingang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eingang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ziel";
            // 
            // txtZiel
            // 
            this.txtZiel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZiel.Location = new System.Drawing.Point(64, 64);
            this.txtZiel.Name = "txtZiel";
            this.txtZiel.Size = new System.Drawing.Size(254, 20);
            this.txtZiel.TabIndex = 6;
            this.txtZiel.Text = "C:\\Fax\\TIF_Eingang";
            // 
            // buttonEingang
            // 
            this.buttonEingang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEingang.Location = new System.Drawing.Point(324, 38);
            this.buttonEingang.Name = "buttonEingang";
            this.buttonEingang.Size = new System.Drawing.Size(48, 20);
            this.buttonEingang.TabIndex = 7;
            this.buttonEingang.Text = "Öffnen";
            this.buttonEingang.UseVisualStyleBackColor = true;
            this.buttonEingang.Click += new System.EventHandler(this.buttonEingang_Click);
            // 
            // buttonZiel
            // 
            this.buttonZiel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZiel.Location = new System.Drawing.Point(324, 63);
            this.buttonZiel.Name = "buttonZiel";
            this.buttonZiel.Size = new System.Drawing.Size(48, 20);
            this.buttonZiel.TabIndex = 8;
            this.buttonZiel.Text = "Öffnen";
            this.buttonZiel.UseVisualStyleBackColor = true;
            this.buttonZiel.Click += new System.EventHandler(this.buttonZiel_Click);
            // 
            // buttonArchiv
            // 
            this.buttonArchiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArchiv.Location = new System.Drawing.Point(324, 89);
            this.buttonArchiv.Name = "buttonArchiv";
            this.buttonArchiv.Size = new System.Drawing.Size(48, 20);
            this.buttonArchiv.TabIndex = 11;
            this.buttonArchiv.Text = "Öffnen";
            this.buttonArchiv.UseVisualStyleBackColor = true;
            this.buttonArchiv.Click += new System.EventHandler(this.buttonArchiv_Click);
            // 
            // txtArchiv
            // 
            this.txtArchiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchiv.Location = new System.Drawing.Point(64, 90);
            this.txtArchiv.Name = "txtArchiv";
            this.txtArchiv.Size = new System.Drawing.Size(254, 20);
            this.txtArchiv.TabIndex = 10;
            this.txtArchiv.Text = "C:\\Fax\\PDF_Archiv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Archiv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonArchiv);
            this.Controls.Add(this.txtArchiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZiel);
            this.Controls.Add(this.buttonEingang);
            this.Controls.Add(this.txtZiel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEingang);
            this.Controls.Add(this.buttonMinimieren);
            this.Controls.Add(this.txtVerlauf);
            this.Controls.Add(this.txtTicks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faxeingang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtTicks;
        private System.Windows.Forms.TextBox txtVerlauf;
        private System.Windows.Forms.Button buttonMinimieren;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtEingang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZiel;
        private System.Windows.Forms.Button buttonEingang;
        private System.Windows.Forms.Button buttonZiel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonArchiv;
        private System.Windows.Forms.TextBox txtArchiv;
        private System.Windows.Forms.Label label3;
    }
}

