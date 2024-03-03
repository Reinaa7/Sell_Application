using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sinemaBüfeSatışUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kasaTutar = 0;
        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            double bilet, cips, su, cay, kahve, Toplam, ParaÜstü,verilenTutar;
            

            bilet = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox3.Text);
            cay = Convert.ToInt16(textBox5.Text);
            cips = Convert.ToInt16(textBox2.Text);
            kahve = Convert.ToInt16(textBox4.Text);
           

            Toplam = bilet * 100 + su * 10 + cips * 40 + cay * 35 + kahve * 60;

            kasaTutar = kasaTutar + Toplam;

            label18.Text = kasaTutar.ToString() + "TL";


            verilenTutar = Convert.ToInt16(textBox6.Text);

            label18.Text = kasaTutar.ToString() + "TL";

            ParaÜstü = verilenTutar - Toplam;


            label19.Text = ParaÜstü.ToString() + "TL ";







        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Clear();
             textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            label18.Text = " 00 TL";

            label19.Text = " 00 TL ";




        }

        
    }
}
