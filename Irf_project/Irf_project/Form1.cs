using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            hidethings();

            
        }

        private void hidethings()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            textBox1.Hide();
            dataGridView1.Hide();
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog ofd = new OpenFileDialog();

            // Opcionális rész
           
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv"; 
            ofd.AddExtension = true;
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
                    dl.felhomeret = Convert.ToDouble(sor[4]);

                    homerseklet.Add(dl);
                }
            }



            label6.Hide();
            button2.Show();
            button3.Show();
            button4.Show();
            button6.Show();
            label1.Show();
            textBox1.Show();
            label2.Text = "CSV kiválasztva, nyomd meg a Megjelenítés gombot!";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.DataSource = homerseklet;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { //dynamic aktualis = dataGridView1.CurrentCell;

                var torlendo = (from x in homerseklet
                                where x.datum.Contains(textBox1.Text)
                                select x).FirstOrDefault();

                homerseklet.Remove(torlendo);

                dataGridView1.Refresh();
            }
            catch (Exception c)
            {

                MessageBox.Show(c.Message);
            }
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
       

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{8}$");
            if (regex.IsMatch(textBox1.Text))
            {
                e.Cancel = false;


                if (!String.IsNullOrWhiteSpace(textBox1.Text))
                    textBox1.BackColor = Color.LightGreen;
                else
                    textBox1.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textBox1.BackColor = Color.MediumVioletRed;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label5.Show();
            dataGridView1.Hide();
            double atlagFok = homerseklet.Average(t => t.kozepfok);
            double maxFok = homerseklet.Max(t => t.maxfok);
            double minFok = homerseklet.Min(t => t.minfok);
            double felhomeret = homerseklet.Average(t => t.felhomeret);
            
            label3.Text = "Maximum hőmérséklet: (C) " + Math.Round(maxFok).ToString();
            label4.Text = "Minimum hőmérséklet: (C) " + Math.Round(minFok).ToString();
            label5.Text = "Felhőtakarót: (%) " + Math.Round(felhomeret).ToString();
            pictureBox1.Show();
            pictureBox2.Show();

            if (atlagFok>10)
            {
                pictureBox1.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/meleg.png");
            }
            else
            {
                pictureBox1.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/hideg.png");
            }

            if (felhomeret > 70)
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/felho.png");
            }
            else if(felhomeret < 40)
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/nap.png");
            }
            else
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/naposfelhos.png");
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
