namespace RAM_use
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerRAM = new System.Windows.Forms.Timer(this.components);
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.labelR = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcoRAM = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerWarning = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRAM
            // 
            this.timerRAM.Interval = 1000;
            this.timerRAM.Tick += new System.EventHandler(this.timerRAM_Tick);
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.progressBarRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(84)))));
            this.progressBarRAM.Location = new System.Drawing.Point(-2, -11);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(296, 42);
            this.progressBarRAM.TabIndex = 0;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(84)))));
            this.labelR.Location = new System.Drawing.Point(3, 7);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(31, 13);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "RAM";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(84)))));
            this.labelPercent.Location = new System.Drawing.Point(32, 5);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(37, 16);
            this.labelPercent.TabIndex = 2;
            this.labelPercent.Text = "00%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarRAM);
            this.panel1.Location = new System.Drawing.Point(68, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 15);
            this.panel1.TabIndex = 3;
            // 
            // notifyIcoRAM
            // 
            this.notifyIcoRAM.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcoRAM.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcoRAM.Icon")));
            this.notifyIcoRAM.Text = "RAM_use";
            this.notifyIcoRAM.Visible = true;
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(127, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.settingsToolStripMenuItem.Text = "Ustawienia";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timerWarning
            // 
            this.timerWarning.Interval = 300000;
            this.timerWarning.Tick += new System.EventHandler(this.timerWarning_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(369, 27);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelR);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::RAM_use.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::RAM_use.Properties.Settings.Default.Location;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "RAM_use";
            this.TopMost = true;
            
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRAM;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcoRAM;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer timerWarning;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

