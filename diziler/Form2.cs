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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*#region string bir dizideki elemanları listeleme
            //string[] sehirler = { "İstanbul", "Ankara", "Bolu", "Niğde", "Edirne", "Yalova", "İzmit" };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}
            #endregion */

            /* #region bir dizideki çift sayıları listeleyen program
             int[] sayilar = { 1, 2, 6, 8, 7, 9 };
             for (int i = 0; i < sayilar.Length; i++)
             {
                 if (sayilar[i]%2==0)
                 {
                     listBox1.Items.Add(sayilar[i]);
                     }
             }
             #endregion */

            /*#region ÖDEV: Girilen değerler arasındaki 10dan büyük ve çift sayıları ekrana yazdıran program
           
            int[] sayilar = { 14, 67, 70, 19, 24, 35, 42 ,7,4,2};
            for (int i = 0; i <sayilar.Length; i++)
            {
                if (sayilar[i]>10 && sayilar[i]%2==0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
            #endregion */

            #region 10 elemanlı rastgele oluşturulan dizide 10dan büyük ve çift olan sayıları ekrana yazdırma
            int[] sayilar = new int[10]; // 20 elemanlı dizi oluşturuldu.
            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                if (sayilar[i]>10 && sayilar[i]%2==0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }

            #endregion
        }
    }
}
