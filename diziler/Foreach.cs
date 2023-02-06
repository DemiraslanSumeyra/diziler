using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Foreach : Form
    {
        public Foreach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* #region String bir dizide foreach kullanımı

             string[] kisiler = { "Alaattin", "Sevgi", "Hüseyin", "Şükran", "Sabahat", "Murat" };
             foreach (string k in kisiler)
             {
                 listBox1.Items.Add(k);
             }

             #endregion */


           /* #region int bir dizide foreach kullanımı
            int toplam = 0;
            int[] sinavlar = { 45, 70, 80, 90, 100 };
            foreach (int s in sinavlar)
            {
                listBox1.Items.Add(s);
                toplam = toplam + s;
            }
            lbl_toplam.Text = toplam.ToString();
            int ortalama=toplam/ sinavlar.Length;
            lbl_ortalama.Text = ortalama.ToString();
            #endregion */

            #region 10 elemanlı bir tam sayı dizisinde 4e tam bölünen sayıları, 4e tam bölünen kaç adet sayı olduğunu ve 4e tam bölünen sayıların toplamını bulan program 
            int toplam = 0;
            int adet = 0;
            int[] sayilar = new int[10];
            Random rnd= new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
            }
            foreach (int x in sayilar)
            {
                if (x%4==0)
                {
                    listBox1.Items.Add(x);
                    adet++;
                    toplam = toplam + x;
                }
                lbl_adet.Text = adet.ToString();
                lbl_toplam.Text = toplam.ToString();
            }
            #endregion
        }
    }
}
