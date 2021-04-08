using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_Versuche
{
    class Worker
    {
        List<Zelle> a = new List<Zelle>();
        BufferedGraphics g;
        Color BackColor;
        SolidBrush pinsel = new SolidBrush(Color.Red);
        public int i = 0;
        public int anzRunden = 0;

        public Worker(BufferedGraphics g, List<Zelle> a, Color Backcolor)
        {
            this.a = a;
            this.g = g;
            this.BackColor = Backcolor;
        }

        // This method will be called when the thread is started.
        public void DoWork()
        {
            while (!_shouldStop)
            {
                Tools.zellenZustand(a);
                g.Graphics.Clear(BackColor);
                Tools.zeichnen(a, g, pinsel, BackColor);
                System.Threading.Thread.Sleep(50);

                i++;
                if (i == anzRunden)
                {
                    RequestStop();
                }
            }
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;
    }
}
