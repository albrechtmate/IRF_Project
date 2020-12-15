using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irf_project
{
    class GombTorles : Button
    {
        public GombTorles()
        {
            Width = 150;
            Height = Width;
            
            this.BackgroundImage = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/torles.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
