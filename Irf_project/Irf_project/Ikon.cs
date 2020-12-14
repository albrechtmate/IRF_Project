using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irf_project
{
    public abstract class Ikon : Button
    {
        public Ikon()
        {
            AutoSize = false;
            Width = 100;
            Height = Width;
        }

        private void Ikon_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);


    }
}
