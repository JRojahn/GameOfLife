using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_Versuche
{
    class Zelle
    {
        static int count;
        public int Nr; 
        public Color Farbe;
        public int Width = 8;
        public int Height = 8;
        public int X;
        public int Y;
        public bool istTod;
        public int anzNachbar;

        public Zelle(int x, int y, Color farbe)
        {
            X = x;
            Y = y;
            Farbe = farbe;
            istTod = true;
            Nr = count;
            count++;
        }

        public void zelleZeichnen(Graphics g, SolidBrush pinsel, Color BackColor)
        {
            pinsel.Color = (istTod) ? BackColor : Color.Red;
            g.FillRectangle(pinsel, X, Y, Width, Height);
        }

        public void zelleZeichnenRand(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), X, Y, Width, Height);
        }

        public void Nachbar(List<Zelle>lz)
        {
            int count = 0;

            if (Nr - 79 > 0 && !lz[Nr - 79].istTod)
            {
                count++;
            }
            if (Nr - 1 > 0 && !lz[Nr - 1].istTod)
            {
                count++;
            }
            if (Nr + 79 < (lz.Count - 1) && !lz[Nr + 79].istTod)
            {
                count++;
            }
            if (Nr - 80 > 0 && !lz[Nr - 80].istTod)
            {
                count++;
            }
            if (Nr + 80 < (lz.Count - 1) && !lz[Nr + 80].istTod)
            {
                count++;
            }
            if (Nr - 81 > 0 && !lz[Nr - 81].istTod)
            {
                count++;
            }
            if (Nr + 1 < (lz.Count - 1) && !lz[Nr + 1].istTod)
            {
                count++;
            }
            if (Nr + 81 < (lz.Count - 1) && !lz[Nr + 81].istTod)
            {
                count++;
            }
            
            anzNachbar = count;
        }
    }
}
