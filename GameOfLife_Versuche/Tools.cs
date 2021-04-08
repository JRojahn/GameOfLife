using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_Versuche
{
    class Tools
    {
        public static void zellenZustand(List<Zelle>a)
        {
            foreach (Zelle z in a)
            {
                z.Nachbar(a);
            }

            foreach (Zelle z in a)
            {
                if (z.istTod && z.anzNachbar == 3)
                {
                    z.istTod = false;
                }
                if ((!z.istTod) && ((z.anzNachbar != 2) && (z.anzNachbar != 3)))
                {
                    z.istTod = true;
                }
            }
        }

        public static void zeichnen(List<Zelle>a, BufferedGraphics g, SolidBrush pinsel, Color BackColor)
        {
            foreach (Zelle z in a)
            {
                if (!z.istTod)
                {
                    z.zelleZeichnen(g.Graphics, pinsel, BackColor);
                }
            }

            g.Render();
        }

        public static void clearScreen(List<Zelle> a, BufferedGraphics g, Color BackColor)
        {
            foreach (Zelle z in a)
            {
                z.istTod = true;
            }
            g.Graphics.Clear(BackColor);
            g.Render();
        }

        public static void startbedingung_Zufall(List<Zelle>a)
        {
            Random rnd = new Random();
            int zahl;

            for (int i = 0; i < 1000; i++)
            {
                zahl = rnd.Next(6200);
                a[zahl].istTod = false;
            }
        }

        public static void startbedingung_Gespiegeltes_U(List<Zelle> a)
        {
            a[3157].istTod = false;
            a[3158].istTod = false;
            a[3159].istTod = false;
            a[3237].istTod = false;
            a[3317].istTod = false;
            a[3318].istTod = false;
            a[3319].istTod = false;

            a[3161].istTod = false;
            a[3162].istTod = false;
            a[3163].istTod = false;
            a[3243].istTod = false;
            a[3323].istTod = false;
            a[3322].istTod = false;
            a[3321].istTod = false;
        }

        public static void startbedingung_Kanone(List<Zelle> a)
        {
            a[491].istTod = false;
            a[492].istTod = false;
            a[571].istTod = false;
            a[572].istTod = false;

            a[1371].istTod = false;
            a[1372].istTod = false;
            a[1373].istTod = false;
            a[1450].istTod = false;
            a[1454].istTod = false;
            a[1529].istTod = false;
            a[1535].istTod = false;
            a[1610].istTod = false;
            a[1691].istTod = false;
            a[1693].istTod = false;
            a[1692].istTod = false;
            a[1614].istTod = false;
            a[1771].istTod = false;
            a[1773].istTod = false;
            a[1772].istTod = false;

            a[2487].istTod = false;
            a[2488].istTod = false;
            a[2492].istTod = false;
            a[2493].istTod = false;
            a[2408].istTod = false;
            a[2409].istTod = false;
            a[2410].istTod = false;
            a[2411].istTod = false;
            a[2412].istTod = false;
            a[2328].istTod = false;
            a[2329].istTod = false;
            a[2331].istTod = false;
            a[2332].istTod = false;
            a[2248].istTod = false;
            a[2249].istTod = false;
            a[2251].istTod = false;
            a[2252].istTod = false;
            a[2169].istTod = false;
            a[2170].istTod = false;
            a[2171].istTod = false;

            a[3290].istTod = false;
            a[3289].istTod = false;
            a[3210].istTod = false;
            a[3209].istTod = false;

            a[3386].istTod = false;
            a[3466].istTod = false;
            a[3626].istTod = false;
            a[3706].istTod = false;
            a[3786].istTod = false;
            a[3866].istTod = false;
            a[4026].istTod = false;
            a[4106].istTod = false;
            a[3545].istTod = false;
            a[3547].istTod = false;
            a[3945].istTod = false;
            a[3947].istTod = false;
        }

        public static void startbedingung_R_Pentonium(List<Zelle> a)
        {
            a[3241].istTod = false;
            a[3239].istTod = false;
            a[3240].istTod = false;
            a[3160].istTod = false;
            a[3319].istTod = false;
        }
    }
}
