namespace GameOfLife_Versuche
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRunden = new System.Windows.Forms.Label();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.txtCustomRunden = new System.Windows.Forms.TextBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRunden);
            this.panel1.Controls.Add(this.btnAbbruch);
            this.panel1.Controls.Add(this.txtCustomRunden);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblRunden
            // 
            this.lblRunden.AutoSize = true;
            this.lblRunden.Location = new System.Drawing.Point(406, 15);
            this.lblRunden.Name = "lblRunden";
            this.lblRunden.Size = new System.Drawing.Size(83, 13);
            this.lblRunden.TabIndex = 5;
            this.lblRunden.Text = "Anzahl Runden:";
            this.lblRunden.Visible = false;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Location = new System.Drawing.Point(265, 5);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(75, 32);
            this.btnAbbruch.TabIndex = 4;
            this.btnAbbruch.Text = "Abbrechen";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            this.btnAbbruch.Visible = false;
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // txtCustomRunden
            // 
            this.txtCustomRunden.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomRunden.Enabled = false;
            this.txtCustomRunden.Location = new System.Drawing.Point(492, 12);
            this.txtCustomRunden.Name = "txtCustomRunden";
            this.txtCustomRunden.Size = new System.Drawing.Size(55, 20);
            this.txtCustomRunden.TabIndex = 3;
            this.txtCustomRunden.Text = "100";
            this.txtCustomRunden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomRunden.Visible = false;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(553, 5);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(75, 32);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnProp
            // 
            this.btnProp.Location = new System.Drawing.Point(93, 5);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(75, 32);
            this.btnProp.TabIndex = 1;
            this.btnProp.Text = "Einstellung";
            this.btnProp.UseVisualStyleBackColor = true;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picMain
            // 
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(640, 640);
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            this.picMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 680);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Conway`s Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox txtCustomRunden;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnAbbruch;
        private System.Windows.Forms.Label lblRunden;
    }
}

