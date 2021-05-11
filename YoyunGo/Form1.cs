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
        public string cumle = "";
        public string cumle_1 = "ali ata bak"; 
        public string cumle_2 = "fenerbahçe taraftarları stada akın etti."; 
        public string cumle_3 = "ankaragücü seyircileri çıkan olaylar sonuçunda ceza aldı."; 
        public string cumle_4 = "Uzun bir aradan sonra ilk defa Ankara böyle güzel"; 
        public string cumle_5 = "Pandemi sürecinde yaşanan dalga sonucunda uzmanlar halkı sokağa çıkmaması konusunda uyardı."; 

        private void Form1_Load(object sender, EventArgs e)
        {
            getir(seviye);
            KelimeGetir(seviye);
        }

        private void List2yeKelimeEkle(string cumle, int seviye)
        {
            listBox2.Items.Clear();
            label4.Text = seviye + ". seviyedesiniz.";

            string[] words = cumle.Split(' ');
            int i = 1;
            foreach (var word in words)
            {
                listBox2.Items.Add("Kelime : "+ word);
                i++;
            }
            this.cumle = cumle;
        }

        private void KelimeGetir(int Seviye)
        {
            int sayi = 0;
            switch (Seviye)
            {

                case 1:                    

                    List2yeKelimeEkle(cumle_1, seviye);
                    break;
                case 2:

                    List2yeKelimeEkle(cumle_2, seviye);
                    break;
                case 3:

                    List2yeKelimeEkle(cumle_3, seviye);
                    break;
                case 4:

                    List2yeKelimeEkle(cumle_4, seviye);
                    break;
                case 5:

                    List2yeKelimeEkle(cumle_5, seviye);
                    break;
            }
            listBox2.Sorted = true;
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
            KelimeGetir(seviye);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            label3.Visible = false;
            try
            {
                
                if (cumle == textBox2.Text)
                {
                    label3.Text = "Tebrikler doğru tahmin. " + seviye + ". seviyeyi başarıyla geçtiniz.";
                    label3.ForeColor = Color.DarkGreen;
                    toplam = 0;
                    seviye++;
                    KelimeGetir(seviye);
                }
                else
                {
                    label3.Text = "Yanlış";
                    label3.ForeColor = Color.Blue;
                }
                label3.Visible = true;
            }
            catch (Exception h)
            {
                MessageBox.Show("Lütfen metin giriniz.");
            }

        }
    }
}
