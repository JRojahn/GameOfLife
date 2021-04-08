namespace GameOfLife_Versuche
{
    partial class frmProp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProp));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtZufall = new System.Windows.Forms.RadioButton();
            this.rbtSpigel = new System.Windows.Forms.RadioButton();
            this.rbtKanone = new System.Windows.Forms.RadioButton();
            this.rbtRPent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDurch = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAbbr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startanordnung";
            // 
            // rbtZufall
            // 
            this.rbtZufall.AutoSize = true;
            this.rbtZufall.Checked = true;
            this.rbtZufall.Location = new System.Drawing.Point(12, 31);
            this.rbtZufall.Name = "rbtZufall";
            this.rbtZufall.Size = new System.Drawing.Size(59, 17);
            this.rbtZufall.TabIndex = 1;
            this.rbtZufall.TabStop = true;
            this.rbtZufall.Text = "Zufällig";
            this.rbtZufall.UseVisualStyleBackColor = true;
            // 
            // rbtSpigel
            // 
            this.rbtSpigel.AutoSize = true;
            this.rbtSpigel.Location = new System.Drawing.Point(12, 54);
            this.rbtSpigel.Name = "rbtSpigel";
            this.rbtSpigel.Size = new System.Drawing.Size(97, 17);
            this.rbtSpigel.TabIndex = 2;
            this.rbtSpigel.Text = "Gespiegeltes U";
            this.rbtSpigel.UseVisualStyleBackColor = true;
            // 
            // rbtKanone
            // 
            this.rbtKanone.AutoSize = true;
            this.rbtKanone.Location = new System.Drawing.Point(12, 77);
            this.rbtKanone.Name = "rbtKanone";
            this.rbtKanone.Size = new System.Drawing.Size(62, 17);
            this.rbtKanone.TabIndex = 3;
            this.rbtKanone.Text = "Kanone";
            this.rbtKanone.UseVisualStyleBackColor = true;
            // 
            // rbtRPent
            // 
            this.rbtRPent.AutoSize = true;
            this.rbtRPent.Location = new System.Drawing.Point(12, 100);
            this.rbtRPent.Name = "rbtRPent";
            this.rbtRPent.Size = new System.Drawing.Size(86, 17);
            this.rbtRPent.TabIndex = 4;
            this.rbtRPent.Text = "R-Pentonium";
            this.rbtRPent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durchläufe";
            // 
            // txtDurch
            // 
            this.txtDurch.Location = new System.Drawing.Point(154, 31);
            this.txtDurch.Name = "txtDurch";
            this.txtDurch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDurch.Size = new System.Drawing.Size(75, 20);
            this.txtDurch.TabIndex = 6;
            this.txtDurch.Text = "100";
            this.txtDurch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 127);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAbbr
            // 
            this.btnAbbr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbr.Location = new System.Drawing.Point(154, 127);
            this.btnAbbr.Name = "btnAbbr";
            this.btnAbbr.Size = new System.Drawing.Size(73, 23);
            this.btnAbbr.TabIndex = 8;
            this.btnAbbr.Text = "Abbrechen";
            this.btnAbbr.UseVisualStyleBackColor = true;
            // 
            // frmProp
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbr;
            this.ClientSize = new System.Drawing.Size(239, 162);
            this.Controls.Add(this.btnAbbr);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDurch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtRPent);
            this.Controls.Add(this.rbtKanone);
            this.Controls.Add(this.rbtSpigel);
            this.Controls.Add(this.rbtZufall);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtZufall;
        private System.Windows.Forms.RadioButton rbtSpigel;
        private System.Windows.Forms.RadioButton rbtKanone;
        private System.Windows.Forms.RadioButton rbtRPent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDurch;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAbbr;
    }
}