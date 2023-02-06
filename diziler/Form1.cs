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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string dizi tanımlama 
            string[] kisiler = { "İlker", "Sümeyra", "Rüya", "Rüzgar" };
            label1.Text = kisiler[2];
            */

            /* int dizi tanimlama
            int[] sayilar = {4,3,7,5,9,10};
            label1.Text = sayilar[3].ToString();
            */

            /*#region ÖDEV1: ondalıklı 5 değerden oluşan bir dizi 
            //double[] ondalikli = { 1.2, 4.5, 7.5, 4.3, 7.6 };
            //label1.Text = ondalikli[2].ToString();
            #endregion */

            #region ÖDEV2: 10 harften oluşan bir dizi
            char[] harf = { 'a', 'c', 'i', 's', 'r', 'd', 'ş', 'h', 'b', 'e' };
            label1.Text=harf[0].ToString();
            #endregion
        }
    }
}
