using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Versuche
{
    public partial class frmProp : Form
    {
        private int runden = 100;
        private int start = 1;

        public int Runden
        {
            get
            {
                try
                {
                    return int.Parse(txtDurch.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bitte nur Zahlen Eingeben");
                    return 100;
                }
                
            }
        }

        public int Start
        {
            get
            {
                if (rbtZufall.Checked) return 1;
                if (rbtSpigel.Checked) return 2;
                if (rbtRPent.Checked) return 4;
                if (rbtKanone.Checked) return 3;
                return 0;
            }
        }

        public frmProp()
        {
            InitializeComponent();

            this.btnOk.DialogResult = DialogResult.OK;
            this.btnAbbr.DialogResult = DialogResult.Cancel;
        }
    }
}
