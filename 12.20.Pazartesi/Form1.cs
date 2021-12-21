using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._20.Pazartesi
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //string[] dosyalar;
        List<string> dosyalar;
        int sayac = 0;
        int ToplamResim;
        private void button1_Click(object sender, EventArgs e)
        {
            dosyalar = new List<string>();
            folderBrowserDialog1.ShowDialog();
            //dosyalar = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            foreach (string dosya in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
            {
                FileInfo file = new FileInfo(dosya);
                if (file.Extension == ".jpg" || file.Extension == ".JPEG")
                    dosyalar.Add(dosya);
            }
            timer1.Enabled = true;
            ToplamResim = dosyalar.Count;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = dosyalar[sayac];
            label1.Text = (sayac + 1) + "/" + ToplamResim;
            sayac++;
            if (sayac >= ToplamResim)
            {
                sayac = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
