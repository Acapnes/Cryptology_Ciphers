using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        string[] alp = new string[] { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
        public static char[] trans_alfabe = { 'i', 'm', 't', 'j', 'y', 'o', 'a', 'v', 'ş', 'd', 'n', 'e', 'ç', 'b', 'r', 'g', 's', 'ü', 'f', 'c', 'l', 'ı', 'u', 'ö', 'ğ', 'p', 'k', 'z', 'h' };


        /// Caesar Encryption
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string acikMetin = textBox1.Text;
            char temp;
            foreach (char c in acikMetin.ToCharArray())
            {
                temp = c;
                for (int i = 0; i < 29; i++)
                {
                    if (c == alfabe[i])
                    {
                        temp = alfabe[(i + 3) % 29];
                    }
                }
                textBox2.Text += Convert.ToChar(temp).ToString();
            }
        }

        /// Caesar Decryption 
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string acikMetin = textBox2.Text;
            char temp;
            foreach (char c in acikMetin.ToCharArray())
            {
                temp = c;
                for (int i = 0; i < 29; i++)
                {
                    if (c == alfabe[i])
                    {
                        temp = alfabe[((i - 3) + 29) % 29];
                    }
                }
                textBox1.Text += Convert.ToChar(temp).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox5.Text = "";
                int anahtar = Convert.ToInt32(textBox3.Text);
                string acikMetin = textBox4.Text;
                char temp;
                foreach (char c in acikMetin.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)    
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[(i + anahtar) % 29];
                        }
                    }
                    textBox5.Text += Convert.ToChar(temp).ToString();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Anahtar Giriniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox4.Text = "";
                int anahtar = Convert.ToInt32(textBox3.Text);
                string acikMetin = textBox5.Text;
                char temp;
                foreach (char c in acikMetin.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[((i - anahtar) + 29) % 29];
                        }
                    }
                    textBox4.Text += Convert.ToChar(temp).ToString();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Anahtar Giriniz.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dogrusalAnahtar1.Text != "" && dogrusalAnahtar2.Text != "")
            {
                dogrusalSifreliVeri.Text = "";
                int anahtar1 = Convert.ToInt32(dogrusalAnahtar1.Text);
                int anahtar2 = Convert.ToInt32(dogrusalAnahtar2.Text);
                string acikMetin = dogrusalVeri.Text;
                char temp;
                foreach (char c in acikMetin.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[((i * anahtar1) + anahtar2) % 29];
                        }
                    }
                    dogrusalSifreliVeri.Text += Convert.ToChar(temp).ToString();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Anahtarları Giriniz.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dogrusalAnahtar1.Text != "" && dogrusalAnahtar2.Text != "")
            {
                dogrusalVeri.Text = "";
                int anahtar1 = Convert.ToInt32(dogrusalAnahtar1.Text);
                int anahtar2 = Convert.ToInt32(dogrusalAnahtar2.Text);
                string acikMetin = dogrusalSifreliVeri.Text;
                char temp;
                int mters = 0;
                foreach (char c in acikMetin.ToCharArray())
                {
                    temp = c;
                    for (int modters = 0; modters < 29; modters++)
                    {
                        if ((anahtar1 * modters) % 29 == 1)
                        {
                            mters = modters;
                            break;
                        }
                    }

                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            if (i - anahtar2 < 0)
                            {
                                temp = alfabe[((i - anahtar2) * mters) % 29];
                                i = i * -1;
                            }
                            else
                                temp = alfabe[((i - anahtar2) * mters) % 29];
                        }
                    }

                    dogrusalVeri.Text += Convert.ToChar(temp).ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Anahtarları Giriniz.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = dogrusalSifreliVeri.Text;
            int a1 = int.Parse(dogrusalAnahtar1.Text);
            int a2 = int.Parse(dogrusalAnahtar2.Text);
            int x = 0, matrix = 0;
            int resolvent = 0;
            string ciphertext = "";
            text = text.ToLower();
            for (int modre = 0; modre < 29; modre++)
            {
                if ((a1 * modre) % 29 == 1)
                {
                    matrix = modre;
                    break;
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                x = 0;
                string parameter_text = text.Substring(i, 1);
                for (int j = 0; j < alp.Length; j++)
                {
                    if (parameter_text == alp[j])
                    {
                        break;
                    }
                    else
                    {
                        x++;
                    }
                }
                if (parameter_text == " ")
                {
                    ciphertext += " ";
                    x = 0;
                }
                else
                {
                    if (matrix != 0)
                    {
                        if (x - a2 < 0) x += 29;
                        resolvent = (matrix * (x - a2)) % 29;
                        ciphertext += alp[resolvent];
                    }
                    else if (matrix == 0)
                    {
                        MessageBox.Show("number");
                        break;
                    }

                }
            }
            dogrusalVeri.Text = ciphertext;
        }

        private void trans_sifre_Click(object sender, EventArgs e)
        {
            trans_sifreliveri.Text = "";
            string veri = trans_veri.Text;
            char temp;
            if (veri != "")
            {
                foreach (char c in veri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = trans_alfabe[i];
                        }
                    }
                    trans_sifreliveri.Text += Convert.ToChar(temp).ToString();

                }
            }
        }

        private void trans_sifrecoz_Click(object sender, EventArgs e)
        {
            trans_veri.Text = "";
            string veri = trans_sifreliveri.Text;
            char temp;
            if (veri != "")
            {
                foreach (char c in veri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == trans_alfabe[i])
                        {
                            temp = alfabe[i];
                        }
                    }
                    trans_veri.Text += Convert.ToChar(temp).ToString();

                }
            }
        }

        private void perm_sifrele_Click(object sender, EventArgs e)
        {
            int whileindex = 0;
            int whileint = 0;
            perm_sifreliveri.Text = "";
            perm_dizi.Text = "";
            string veri = perm_veri.Text;
            Random random = new Random();
            int anahtarsayac = 0;
            bool same = false;
            int arrLength = int.Parse(perm_anahtar.Text);
            int[] dizi = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                same = false;
                anahtarsayac = random.Next(1, arrLength + 1);
                for (int j = 0; j < i + 1; j++)
                {
                    if (anahtarsayac == dizi[j])
                    {
                        i--;
                        same = true;
                        break;
                    }
                    else
                    {
                        same = false;
                    }
                }
                if (same == false)
                {
                    dizi[i] = anahtarsayac;
                }
            }
            for (int a = 0; a < arrLength; a++)
            {
                perm_dizi.Text += dizi[a].ToString();
            }

            if (perm_veri.Text != "")
            {
                if (perm_veri.TextLength % dizi.Length != 0)
                {
                    while (perm_veri.TextLength % dizi.Length != 0)
                    {
                        perm_veri.Text += "a";
                        veri = perm_veri.Text;
                    }
                }

                for (int m = 0; m < Math.Abs(perm_veri.TextLength / dizi.Length); m++)
                {
                    for (int n = 0; n < dizi.Length; n++)
                    {
                        if (m == 0)
                        {
                            perm_sifreliveri.Text += perm_veri.Text[dizi[n] - 1];
                        }
                        else if (m > 0)
                        {
                            perm_sifreliveri.Text += perm_veri.Text[(dizi[n] - 1) + dizi.Length];
                        }
                    }
                }
            }
        }

        private void perm_sifrecoz_Click(object sender, EventArgs e)
        {
            int textindexer = 0;
            int index = 0;
            perm_veri.Text = "";
            string veri = perm_sifreliveri.Text;
            int arrLength = int.Parse(perm_anahtar.Text);
            string[] dizi = new string[arrLength];
            while (dizi.Length == arrLength)
            {
                dizi[index] = perm_dizi.Text[index].ToString();
                index++;
                if (index == arrLength)
                    break;
            }

            if (perm_sifreliveri.Text != "")
            {
                if (perm_sifreliveri.TextLength % dizi.Length != 0)
                {
                    while (perm_sifreliveri.TextLength % dizi.Length != 0)
                    {
                        perm_sifreliveri.Text += "a";
                        veri = perm_sifreliveri.Text;
                    }
                }
                for (int m = 0; m < Math.Abs(perm_sifreliveri.TextLength / dizi.Length); m++)
                {
                    for (int n = 0; n < dizi.Length; n++)
                    {
                        if (m == 0)
                        {
                            perm_veri.Text += perm_sifreliveri.Text[Convert.ToInt32(dizi[n]) - 1];
                        }
                        else if (m > 0)
                        {

                            perm_veri.Text += perm_sifreliveri.Text[(Convert.ToInt32(dizi[n]) - 1) + dizi.Length];
                        }
                    }
                }
            }
        }

        private void rota_sifrele_Click(object sender, EventArgs e)
        {
            int index = 0;
            int anahtar = int.Parse(rota_anahtar.Text);
            string veri = rota_veri.Text;
            int satirsayisi = 0;

            if (rota_veri.Text != "")
            {

                while (rota_veri.TextLength % anahtar != 0)
                {
                    rota_veri.Text += "a";
                    veri = rota_veri.Text;
                    satirsayisi = (veri.Length / anahtar);
                }
                string[,] rota = new string[satirsayisi, anahtar];


                for (int i = 0; i < satirsayisi; i++)
                {
                    for (int j = 0; j < anahtar; j++)
                    {
                        rota[i, j] = rota_veri.Text[index].ToString();
                        index++;
                    }
                }

                /// [satırsayısı,0] - [satırsayısı - 1 ,0]  ...
                /// [0,0] - [0,1] ...
                /// [sütunsayısı,0] - [sütunsayısı, 0 +1 ]
                /// [sütunsayısı,satırsayısı] - [sütunsayısı - 1, satırsayısı - index(]
                /// [satırsayısı, ındex(1)] - [satırsayısı - 1, index(1)]
                /// 

                for (int a = 0; a < satirsayisi; a++)
                {
                    rota_sifreliveri.Text += rota[(satirsayisi - a) - 1, 0];
                }

                for (int b = 0; b < anahtar; b++)
                {
                    rota_sifreliveri.Text += rota[0, b];
                }

                for (int c = 1; c < satirsayisi; c++)
                {
                    rota_sifreliveri.Text += rota[c, anahtar - 1];
                }

                for (int d = 1; d < anahtar; d++)
                {
                    rota_sifreliveri.Text += rota[anahtar - d, d + 1];
                }
            }
        }

        private void vig_sifrele_Click(object sender, EventArgs e)
        {
            vig_sifreliveri.Text = "";
            string veri = vig_veri.Text;
            string anahtarveri = vig_anahtar.Text;
            int arrLength = vig_anahtar.TextLength;
            string[] dizi = new string[arrLength];
            int index = 0, index0 = 0, index1 = 0;
            char temp;

            while (dizi.Length == arrLength)
            {
                dizi[index] = vig_anahtar.Text[index].ToString();
                index++;
                if (index == arrLength)
                    break;
            }

            if (vig_veri.Text != "")
            {
                if (vig_veri.TextLength % dizi.Length != 0)
                {
                    while (vig_veri.TextLength % dizi.Length != 0)
                    {
                        vig_veri.Text += "a";
                        veri = vig_veri.Text;
                    }
                }
                int[] anahtardizi = new int[anahtarveri.Length];
                foreach (char c in anahtarveri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            anahtardizi[index0] = i;
                            index0++;
                        }
                    }
                }

                foreach (char c in veri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[(i + anahtardizi[index1]) % 29];
                            index1++;
                            if (index1 > anahtardizi.Length - 1)
                                index1 = 0;
                        }
                    }
                    vig_sifreliveri.Text += Convert.ToChar(temp).ToString();
                }
            }
        }

        private void vig_sifrecoz_Click(object sender, EventArgs e)
        {
            vig_veri.Text = "";
            string veri = vig_sifreliveri.Text;
            string anahtarveri = vig_anahtar.Text;
            int arrLength = vig_anahtar.TextLength;
            string[] dizi = new string[arrLength];
            int index = 0, index0 = 0, index1 = 0;
            char temp;

            while (dizi.Length == arrLength)
            {
                dizi[index] = vig_anahtar.Text[index].ToString();
                index++;
                if (index == arrLength)
                    break;
            }

            if (vig_sifreliveri.Text != "")
            {

                int[] anahtardizi = new int[anahtarveri.Length];
                foreach (char c in anahtarveri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            anahtardizi[index0] = i;
                            index0++;
                        }
                    }
                }

                foreach (char c in veri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 29; i++)
                    {
                        if (c == alfabe[i])
                        {
                            if (i - anahtardizi[index1] < 0)
                                i += 29;
                            temp = alfabe[(i - anahtardizi[index1]) % 29];
                            index1++;
                            if (index1 > anahtardizi.Length - 1)
                                index1 = 0;
                        }
                    }
                    vig_veri.Text += Convert.ToChar(temp).ToString();
                }
            }
        }

        public static char[] kareAlfabesagust = { 'l', 'x', 'h', 'ö', 'ç', 'z', 'd', 'p', 'n', 'u', 'o', 'a', 'ı', 'ş', 'k', 'y', 'e', 'b', 'f', 'r', 'j', 'g', 'i', 'ü', 'ğ', 's', 'v', 'm', 't', 'c' };
        public static char[] kareAlfabesolalt = { 'l', 'd', 'y', 'o', 't', 'v', 'x', 'k', 't', 'c', 'ç', 'p', 'e', 'h', 'i', 'ü', 'ç', 'l', 'ğ', 'r', 'u', 'ş', 'z', 'h', 'b', 'm', 'g', 'j', 's', 'ö' };
        public static char[] alfabenormal = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', 'x' };
        private void kare_sifrele_Click(object sender, EventArgs e)
        {
            kare_sifreliveri.Text = "";
            string veri = kare_veri.Text;
            char[,] dizisagust = new char[6, 5];
            char[,] dizisolalt = new char[6, 5];
            char[,] dizinormal = new char[6, 5];
            int alfabeindex = 0, foreachindex = 2;
            char temp;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dizisagust[i, j] = kareAlfabesagust[alfabeindex];
                    dizisolalt[i, j] = kareAlfabesolalt[alfabeindex];
                    dizinormal[i, j] = alfabenormal[alfabeindex];
                    alfabeindex++;
                }
                if (alfabeindex == 31) break;
            }

            if (kare_veri.Text != "")
            {
                while (kare_veri.TextLength % 2 != 0)
                {
                    kare_veri.Text += "a";
                    veri = rota_veri.Text;
                }

                foreach (char c in veri.ToCharArray())
                {
                    temp = c;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if(foreachindex % 2 == 0)
                            {
                                if (c == dizinormal[i,j])
                                {
                                    kare_sifreliveri.Text += (dizisagust[i, j]).ToString();
                                }
                            }

                            else
                            {
                                if (c == dizinormal[i, j])
                                {
                                    kare_sifreliveri.Text += (dizisolalt[i, j]).ToString();
                                }
                            }
                        }
                    }
                    foreachindex++;
                }
            }
        }
    }
}
