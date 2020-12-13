using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irf_project
{
    public partial class Form1 : Form
    {
        List<dataLista> homerseklet = new List<dataLista>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog ofd = new OpenFileDialog();

            // Opcionális rész
           
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv"; // A kiválasztható fájlformátumokat adjuk meg ezzel a sorral. Jelen esetben csak a csv-t fogadjuk el
            ofd.DefaultExt = "csv"; // A csv lesz az alapértelmezetten kiválasztott kiterjesztés
            ofd.AddExtension = true; // Ha ez igaz, akkor hozzáírja a megadott fájlnévhez a kiválasztott kiterjesztést, de érzékeli, ha a felhasználó azt is beírta és nem fogja duplán hozzáírni

            if (ofd.ShowDialog() != DialogResult.OK) return;

            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {

                while (!sr.EndOfStream)
                {

                    string [] sor = sr.ReadLine().Split(';');

                    dataLista dl = new dataLista();

                    dl.datum = sor[0].Remove(sor[0].Length-5);
                    dl.maxfok = Convert.ToDouble(sor[1]);
                    dl.minfok = Convert.ToDouble(sor[2]);
                    dl.kozepfok = Convert.ToDouble(sor[3]);
                    dl.felhotakaro = Convert.ToDouble(sor[4]);

                    homerseklet.Add(dl);
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = homerseklet;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //dynamic aktualis = dataGridView1.CurrentCell;
            var torlendo = (from x in homerseklet
                           where x.datum.Contains(textBox1.Text)
                           select x).FirstOrDefault();

            homerseklet.Remove(torlendo);

            dataGridView1.Refresh();
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
