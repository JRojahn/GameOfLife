using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Versuche
{
    public partial class frmMain : Form
    {
        BufferedGraphics g;
        BufferedGraphicsContext context;
        SolidBrush pinsel = new SolidBrush(Color.Red);
        List<Zelle> a = new List<Zelle>();
        private int anzRunden = 100;
        private int aufstellung = 1;
        private DialogResult result;
        private bool customMode;
        Worker del;
        Thread thread;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            g = context.Allocate(picMain.CreateGraphics(), new Rectangle(0, 0, picMain.Width, picMain.Height));

            //Zellen inizialisiern

            for (int i = 0; i < 80; i++)
            {
                for (int k = 0; k < 80; k++)
                {
                    a.Add(new Zelle(i * 8, k * 8, BackColor));
                }
            }
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            if (customMode)
            {
                Tools.clearScreen(a, g, BackColor);
                Tools.zeichnen(a, g, pinsel, BackColor);

                btnProp.Text = "Einstellung";
                btnStart.Text = "Start";

                customMode = false;

                txtCustomRunden.Visible = false;
                txtCustomRunden.Enabled = false;
            }
            else
            {
                frmProp propFenster = new frmProp();
                result = propFenster.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Tools.clearScreen(a, g, BackColor);

                    anzRunden = propFenster.Runden;
                    aufstellung = propFenster.Start;

                    if (aufstellung <= 1)
                    {
                        Tools.startbedingung_Zufall(a);
                    }
                    else if (aufstellung == 2)
                    {
                        Tools.startbedingung_Gespiegeltes_U(a);
                    }
                    else if (aufstellung == 3)
                    {
                        Tools.startbedingung_Kanone(a);
                    }
                    else if (aufstellung == 4)
                    {
                        Tools.startbedingung_R_Pentonium(a);
                    }
                    
                    Tools.zeichnen(a, g, pinsel, BackColor);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (customMode)
            {
                g.Graphics.Clear(BackColor);
                Tools.zeichnen(a, g, pinsel, BackColor);

                btnProp.Text = "Einstellung";
                btnStart.Text = "Start";

                customMode = false;

                result = DialogResult.OK;

                txtCustomRunden.Visible = false;
                txtCustomRunden.Enabled = false;
                lblRunden.Visible = false;

                try
                {
                    anzRunden = int.Parse(txtCustomRunden.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bitte nur Zahlen Eingeben");
                    anzRunden = 100;
                }
            }
            else if (result == DialogResult.OK)
            {
                del = new Worker(g, a, BackColor);
                del.anzRunden = anzRunden;
                thread = new Thread(del.DoWork);
                thread.Start();

                while (!thread.IsAlive) ;

                Thread.Sleep(1);

                btnAbbruch.Visible = true;
                btnStart.Visible = false;
                btnProp.Visible = false;
                btnCustom.Visible = false;
                
                result = DialogResult.Cancel;
            }
            else
            {
                btnProp_Click(sender, e);
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            customMode = true;
            Tools.clearScreen(a, g, BackColor);

            foreach (Zelle z in a)
            {
                z.zelleZeichnenRand(g.Graphics);
            }
            g.Render();
            
            btnStart.Text = "OK";
            btnProp.Text = "Abbrechen";

            txtCustomRunden.Visible = true;
            txtCustomRunden.Enabled = true;
            lblRunden.Visible = true;
        }
        
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (customMode)
            {
                int listIndex = (e.X / 8) * 80 + (e.Y / 8);

                if (a[listIndex].istTod)
                {
                    a[listIndex].istTod = false;
                    a[listIndex].zelleZeichnen(g.Graphics, pinsel, BackColor);
                    g.Render();
                }
                else
                {
                    a[listIndex].istTod = true;
                    a[listIndex].zelleZeichnen(g.Graphics, pinsel, BackColor);
                    a[listIndex].zelleZeichnenRand(g.Graphics);
                    g.Render();
                }
            }
        }

        private void btnAbbruch_Click(object sender, EventArgs e)
        {
            del.RequestStop();
            del.i = anzRunden;

            btnStart.Visible = true;
            btnProp.Visible = true;
            btnCustom.Visible = true;
            btnAbbruch.Visible = false;

            thread.Abort();

            Tools.clearScreen(a, g, BackColor);
        }
    }
}
