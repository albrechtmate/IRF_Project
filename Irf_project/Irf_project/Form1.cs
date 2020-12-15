using Microsoft.Office.Interop.Excel;
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
        BindingList<dataLista> homerseklet = new BindingList<dataLista>();
        double atlagFok;
        double maxFok;
        double minFok;
        double felhom;
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

                    string[] sor = sr.ReadLine().Split(';');

                    dataLista dl = new dataLista();

                    dl.datum = sor[0].Remove(sor[0].Length - 5);
                    dl.maxfok = Convert.ToDouble(sor[1]);
                    dl.minfok = Convert.ToDouble(sor[2]);
                    dl.kozepfok = Convert.ToDouble(sor[3]);
                    dl.felhomeret = Convert.ToDouble(sor[4]);

                    homerseklet.Add(dl);
                }
            }



            label6.Hide();
           
            label2.Text = "CSV kiválasztva, nyomd meg a Megjelenítés gombot!";

            MegjelGomb megjelGomb = new MegjelGomb();
            this.Controls.Add(megjelGomb);
            megjelGomb.Top = this.Height - 200;
            megjelGomb.Left = 0;
            megjelGomb.Click += megjelGomb_Click;


        }


        private void megjelGomb_Click(object sender, EventArgs e)
        {
            label1.Show();
            textBox1.Show();
            dataGridView1.Show();
            dataGridView1.DataSource = homerseklet;
            GombExport exGomb = new GombExport();
            this.Controls.Add(exGomb);
            exGomb.Top = this.Height - 200;
            exGomb.Left = 400;
            exGomb.Click += exGomb_Click;

            GombPaint paintGomb = new GombPaint();
            this.Controls.Add(paintGomb);

            paintGomb.Left = 600;
            paintGomb.Top = this.Height - 200;
            paintGomb.Click += paintGomb_Click;

            GombTorles torlesGomb = new GombTorles();
            this.Controls.Add(torlesGomb);
            torlesGomb.Top = this.Height - 200;
            torlesGomb.Left = 800;
            torlesGomb.Click += torlesGomb_Click;
        }

        private void torlesGomb_Click(object sender, EventArgs e)
        {
            var torlendo = (from x in homerseklet
                            where x.datum.Contains(textBox1.Text)
                            select x).FirstOrDefault();

            homerseklet.Remove(torlendo);

            dataGridView1.Refresh();
        }

        private void paintGomb_Click(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label5.Show();
            dataGridView1.Hide();
            atlagFok = homerseklet.Average(t => t.kozepfok);
            maxFok = homerseklet.Max(t => t.maxfok);
            minFok = homerseklet.Min(t => t.minfok);
            felhom = homerseklet.Average(t => t.felhomeret);

            label3.Text = "Maximum hőmérséklet: (C) " + Math.Round(maxFok).ToString();
            label4.Text = "Minimum hőmérséklet: (C) " + Math.Round(minFok).ToString();
            label5.Text = "Felhőtakarót: (%) " + Math.Round(felhom).ToString();
            pictureBox1.Show();
            pictureBox2.Show();

            if (atlagFok > 10)
            {
                pictureBox1.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/meleg.png");
            }
            else
            {
                pictureBox1.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/hideg.png");
            }

            if (felhom > 70)
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/felho.png");
            }
            else if (felhom < 40)
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/nap.png");
            }
            else
            {
                pictureBox2.Image = new Bitmap("C:/Users/Matu/source/repos/IRF_Project/Irf_project/Irf_project/Képek/naposfelhos.png");
            }

        }

        private void exGomb_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;

                    ws.Cells[1, 1] = "Dátum";
                    ws.Cells[1, 2] = "Napi maximum Fok";
                    ws.Cells[1, 3] = "Napi minimum Fok";
                    ws.Cells[1, 4] = "Napi középhőmérséklet";
                    ws.Cells[1, 5] = "Felhőtakaró";

                    ws.Cells[1, 6] = "Heti max Fok";
                    ws.Cells[1, 7] = "Heti min Fok";
                    ws.Cells[1, 8] = "Heti átlag hőmérséklet";

                    ws.Cells[2, 6] = maxFok;
                    ws.Cells[2, 7] = minFok;
                    ws.Cells[2, 8] = atlagFok;


                    int i = 2;

                    foreach (dataLista item in homerseklet)
                    {
                        ws.Cells[i, 1] = item.datum;
                        ws.Cells[i, 2] = item.maxfok;
                        ws.Cells[i, 3] = item.minfok;
                        ws.Cells[i, 4] = item.kozepfok;
                        ws.Cells[i, 5] = item.felhomeret;

                        i++;
                    }

                    wb.SaveAs(sfd.FileName,
                              XlFileFormat.xlWorkbookDefault,
                              Type.Missing,
                              Type.Missing,
                              true,
                              false,
                              XlSaveAsAccessMode.xlNoChange,
                              XlSaveConflictResolution.xlLocalSessionChanges,
                              Type.Missing,
                              Type.Missing);
                    app.Quit();
                    MessageBox.Show("Excel kész!");



                }
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;

                    ws.Cells[1, 1] = "Dátum";
                    ws.Cells[1, 2] = "Napi maximum Fok";
                    ws.Cells[1, 3] = "Napi minimum Fok";
                    ws.Cells[1, 4] = "Napi középhőmérséklet";
                    ws.Cells[1, 5] = "Felhőtakaró";

                    ws.Cells[1, 6] = "Heti max Fok";
                    ws.Cells[1, 7] = "Heti min Fok";
                    ws.Cells[1, 8] = "Heti átlag hőmérséklet";

                    ws.Cells[2, 6] = maxFok;
                    ws.Cells[2, 7] = minFok;
                    ws.Cells[2, 8] = atlagFok;


                    int i = 2;

                    foreach (dataLista item in homerseklet)
                    {
                        ws.Cells[i, 1] = item.datum;
                        ws.Cells[i, 2] = item.maxfok;
                        ws.Cells[i, 3] = item.minfok;
                        ws.Cells[i, 4] = item.kozepfok;
                        ws.Cells[i, 5] = item.felhomeret;

                        i++;
                    }

                    wb.SaveAs(sfd.FileName,
                              XlFileFormat.xlWorkbookDefault,
                              Type.Missing,
                              Type.Missing,
                              true,
                              false,
                              XlSaveAsAccessMode.xlNoChange,
                              XlSaveConflictResolution.xlLocalSessionChanges,
                              Type.Missing,
                              Type.Missing);
                    app.Quit();
                    MessageBox.Show("Excel kész!");



                }
            }
        }

    }
}
