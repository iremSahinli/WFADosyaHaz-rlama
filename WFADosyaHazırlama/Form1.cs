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

namespace WFADosyaHazırlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKlasorOlustur.Enabled = false;
        }

        private void lnkDosyayoluSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnKlasorOlustur.Enabled = true;
            txtKayitYeri.Text = SelectFolder();
        }

        string SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return fbd.SelectedPath;


            }
            else
            {
                return null;
            }

        }
        void MesajKutusu(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKlasorAdi.Text))
            {
                MesajKutusu("Lütfen Bir Klasör Adı Giriniz.");
                return;
            }
            Directory.CreateDirectory($"{txtKayitYeri.Text}/{txtKlasorAdi.Text}");
            MesajKutusu("Klasör Başarıyla Oluşturuldu.");
            txtKlasorAdi.Text = string.Empty;
            txtKayitYeri.Text = string.Empty;
            btnKlasorOlustur.Enabled = false;

        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string selectePath = SelectFolder();
                string fileName = Guid.NewGuid().ToString().ToLower();
                FileStream fs = File.Create($"{selectePath}/{fileName}.txt");
                fs.Close();
                File.WriteAllText($"{selectePath}/{fileName}.txt", txtYazi.Text);
                MesajKutusu("Yazdırma İşlemi Başarıyla Gerçekleşti.");
            }
            catch (Exception ex)
            {

                MesajKutusu(ex.Message);

            }
            finally
            {
                txtYazi.Text = string.Empty;
            }



        }

        private void lnkKlasorSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string selectedpath = SelectFolder();

            string[] files = Directory.GetFiles(selectedpath);
            lstDosyalar.Items.AddRange(files);
        }
    }


    }

