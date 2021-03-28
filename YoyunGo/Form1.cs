using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoyunGo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int toplam=0;

        public int seviye=1;

        private void Form1_Load(object sender, EventArgs e)
        {
            getir(seviye);
        }

        private void getir(int basamak)
        {
            int sayi = 0;
            switch (basamak)
            {

                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(seviye + ". seviyedesiniz.");
                    for (int i = 1; i < 11; i++)
                    {
                        Random random = new Random();
                        sayi = random.Next(10);
                        toplam = toplam + sayi;                        
                        listBox1.Items.Add(i + ". sayı =  " + sayi);
                    }
                    break;
                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(seviye + ". seviyedesiniz.");
                    for (int i = 1; i < 11; i++)
                    {
                        Random random = new Random();
                        sayi = random.Next(10,100);
                        toplam = toplam + sayi;
                        listBox1.Items.Add(i + ". sayı =  " + sayi);
                    }
                    break;
                case 3:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(seviye + ". seviyedesiniz.");
                    for (int i = 1; i < 11; i++)
                    {
                        Random random = new Random();
                        sayi = random.Next(100,1000);
                        toplam = toplam + sayi;
                        listBox1.Items.Add(i + ". sayı =  " + sayi);
                    }
                    break;
                case 4:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(seviye + ". seviyedesiniz.");
                    for (int i = 1; i < 6; i++)
                    {
                        Random random = new Random();
                        sayi = random.Next(1000,10000);
                        toplam = toplam + sayi;
                        listBox1.Items.Add(i + ". sayı =  " + sayi);
                    }
                    break;
                case 5:
                    listBox1.Items.Clear();
                    listBox1.Items.Add(seviye + ". seviyedesiniz.");
                    for (int i = 1; i < 6; i++)
                    {
                        Random random = new Random();
                        sayi = random.Next(10000,100000);
                        toplam = toplam + sayi;
                        listBox1.Items.Add(i + ". sayı =  " + sayi);
                    }
                    break;
            }            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            int tahmin;
            try
            {
                tahmin = int.Parse(textBox1.Text);
                if (toplam == tahmin)
                {
                    label2.Text = "Tebrikler doğru tahmin. "+seviye+". seviyeyi başarıyla geçtiniz.";
                    label2.ForeColor = Color.DarkGreen;
                    toplam = 0;
                    seviye++;
                    getir(seviye);
                }
                else if (toplam > tahmin)
                {
                    label2.Text = "toplam daha büyük";
                    label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.Text = "toplam daha küçük";
                    label2.ForeColor = Color.Blue;
                }
                label2.Visible = true;
            }
            catch (Exception h)
            {
                MessageBox.Show("Lütfen sayı değeri giriniz.");
            }
            
            

        }


    }
}
