using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irf_project
{
    class Hideg : Ikon
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Képek/hideg.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));

            g.Dispose();
        }
    }
}
