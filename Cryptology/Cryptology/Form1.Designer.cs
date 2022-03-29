namespace Cryptology
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dogrusalAnahtar1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dogrusalAnahtar2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dogrusalVeri = new System.Windows.Forms.TextBox();
            this.dogrusalSifreliVeri = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trans_sifrecoz = new System.Windows.Forms.Button();
            this.trans_sifre = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trans_veri = new System.Windows.Forms.TextBox();
            this.trans_sifreliveri = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.perm_dizi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.perm_sifreliveri = new System.Windows.Forms.TextBox();
            this.perm_sifrecoz = new System.Windows.Forms.Button();
            this.perm_sifrele = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.perm_anahtar = new System.Windows.Forms.TextBox();
            this.perm_veri = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rota_sifrecoz = new System.Windows.Forms.Button();
            this.rota_sifrele = new System.Windows.Forms.Button();
            this.rota_sifreliveri = new System.Windows.Forms.TextBox();
            this.rota_veri = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rota_anahtar = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.vig_sifrecoz = new System.Windows.Forms.Button();
            this.vig_sifrele = new System.Windows.Forms.Button();
            this.vig_sifreliveri = new System.Windows.Forms.TextBox();
            this.vig_veri = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.vig_anahtar = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.kare_sifrecoz = new System.Windows.Forms.Button();
            this.kare_sifrele = new System.Windows.Forms.Button();
            this.kare_sifreliveri = new System.Windows.Forms.TextBox();
            this.kare_veri = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sezar Şifreleme";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sifre Çöz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sifrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Veri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veri";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 204);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kaydırmalı Şifreleme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Anahtar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sifre Çöz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sifrele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifreli Veri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Veri";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dogrusalAnahtar1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dogrusalAnahtar2);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dogrusalVeri);
            this.groupBox3.Controls.Add(this.dogrusalSifreliVeri);
            this.groupBox3.Location = new System.Drawing.Point(289, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 217);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doğrusal Şifreleme";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Sifre Çöz";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "1. Anahtar";
            // 
            // dogrusalAnahtar1
            // 
            this.dogrusalAnahtar1.Location = new System.Drawing.Point(79, 39);
            this.dogrusalAnahtar1.Name = "dogrusalAnahtar1";
            this.dogrusalAnahtar1.Size = new System.Drawing.Size(161, 20);
            this.dogrusalAnahtar1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "2. Anahtar";
            // 
            // dogrusalAnahtar2
            // 
            this.dogrusalAnahtar2.BackColor = System.Drawing.SystemColors.Window;
            this.dogrusalAnahtar2.Location = new System.Drawing.Point(79, 65);
            this.dogrusalAnahtar2.Name = "dogrusalAnahtar2";
            this.dogrusalAnahtar2.Size = new System.Drawing.Size(161, 20);
            this.dogrusalAnahtar2.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Sifrele";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Şifreli Veri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Veri";
            // 
            // dogrusalVeri
            // 
            this.dogrusalVeri.Location = new System.Drawing.Point(79, 95);
            this.dogrusalVeri.Name = "dogrusalVeri";
            this.dogrusalVeri.Size = new System.Drawing.Size(161, 20);
            this.dogrusalVeri.TabIndex = 1;
            // 
            // dogrusalSifreliVeri
            // 
            this.dogrusalSifreliVeri.Location = new System.Drawing.Point(79, 125);
            this.dogrusalSifreliVeri.Name = "dogrusalSifreliVeri";
            this.dogrusalSifreliVeri.Size = new System.Drawing.Size(161, 20);
            this.dogrusalSifreliVeri.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trans_sifrecoz);
            this.groupBox4.Controls.Add(this.trans_sifre);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.trans_veri);
            this.groupBox4.Controls.Add(this.trans_sifreliveri);
            this.groupBox4.Location = new System.Drawing.Point(289, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 135);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yer Değiştirme Şifreleme";
            // 
            // trans_sifrecoz
            // 
            this.trans_sifrecoz.Location = new System.Drawing.Point(164, 100);
            this.trans_sifrecoz.Name = "trans_sifrecoz";
            this.trans_sifrecoz.Size = new System.Drawing.Size(75, 23);
            this.trans_sifrecoz.TabIndex = 5;
            this.trans_sifrecoz.Text = "Sifre Çöz";
            this.trans_sifrecoz.UseVisualStyleBackColor = true;
            this.trans_sifrecoz.Click += new System.EventHandler(this.trans_sifrecoz_Click);
            // 
            // trans_sifre
            // 
            this.trans_sifre.Location = new System.Drawing.Point(78, 100);
            this.trans_sifre.Name = "trans_sifre";
            this.trans_sifre.Size = new System.Drawing.Size(75, 23);
            this.trans_sifre.TabIndex = 4;
            this.trans_sifre.Text = "Sifrele";
            this.trans_sifre.UseVisualStyleBackColor = true;
            this.trans_sifre.Click += new System.EventHandler(this.trans_sifre_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Şifreli Veri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Veri";
            // 
            // trans_veri
            // 
            this.trans_veri.Location = new System.Drawing.Point(79, 26);
            this.trans_veri.Name = "trans_veri";
            this.trans_veri.Size = new System.Drawing.Size(161, 20);
            this.trans_veri.TabIndex = 1;
            // 
            // trans_sifreliveri
            // 
            this.trans_sifreliveri.Location = new System.Drawing.Point(79, 52);
            this.trans_sifreliveri.Name = "trans_sifreliveri";
            this.trans_sifreliveri.Size = new System.Drawing.Size(161, 20);
            this.trans_sifreliveri.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.perm_dizi);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.perm_sifreliveri);
            this.groupBox5.Controls.Add(this.perm_sifrecoz);
            this.groupBox5.Controls.Add(this.perm_sifrele);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.perm_anahtar);
            this.groupBox5.Controls.Add(this.perm_veri);
            this.groupBox5.Location = new System.Drawing.Point(565, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 217);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Permütasyon Şifreleme";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Dizi";
            // 
            // perm_dizi
            // 
            this.perm_dizi.Location = new System.Drawing.Point(78, 32);
            this.perm_dizi.Name = "perm_dizi";
            this.perm_dizi.Size = new System.Drawing.Size(161, 20);
            this.perm_dizi.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Anahtar";
            // 
            // perm_sifreliveri
            // 
            this.perm_sifreliveri.Location = new System.Drawing.Point(78, 108);
            this.perm_sifreliveri.Name = "perm_sifreliveri";
            this.perm_sifreliveri.Size = new System.Drawing.Size(161, 20);
            this.perm_sifreliveri.TabIndex = 6;
            // 
            // perm_sifrecoz
            // 
            this.perm_sifrecoz.Location = new System.Drawing.Point(164, 153);
            this.perm_sifrecoz.Name = "perm_sifrecoz";
            this.perm_sifrecoz.Size = new System.Drawing.Size(75, 23);
            this.perm_sifrecoz.TabIndex = 5;
            this.perm_sifrecoz.Text = "Sifre Çöz";
            this.perm_sifrecoz.UseVisualStyleBackColor = true;
            this.perm_sifrecoz.Click += new System.EventHandler(this.perm_sifrecoz_Click);
            // 
            // perm_sifrele
            // 
            this.perm_sifrele.Location = new System.Drawing.Point(78, 153);
            this.perm_sifrele.Name = "perm_sifrele";
            this.perm_sifrele.Size = new System.Drawing.Size(75, 23);
            this.perm_sifrele.TabIndex = 4;
            this.perm_sifrele.Text = "Sifrele";
            this.perm_sifrele.UseVisualStyleBackColor = true;
            this.perm_sifrele.Click += new System.EventHandler(this.perm_sifrele_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Şifreli Veri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Veri";
            // 
            // perm_anahtar
            // 
            this.perm_anahtar.Location = new System.Drawing.Point(78, 56);
            this.perm_anahtar.Name = "perm_anahtar";
            this.perm_anahtar.Size = new System.Drawing.Size(161, 20);
            this.perm_anahtar.TabIndex = 1;
            // 
            // perm_veri
            // 
            this.perm_veri.Location = new System.Drawing.Point(78, 82);
            this.perm_veri.Name = "perm_veri";
            this.perm_veri.Size = new System.Drawing.Size(161, 20);
            this.perm_veri.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.rota_sifrecoz);
            this.groupBox6.Controls.Add(this.rota_sifrele);
            this.groupBox6.Controls.Add(this.rota_sifreliveri);
            this.groupBox6.Controls.Add(this.rota_veri);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.rota_anahtar);
            this.groupBox6.Location = new System.Drawing.Point(565, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 134);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rota Şifreleme";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Şifreli Veri";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Veri";
            // 
            // rota_sifrecoz
            // 
            this.rota_sifrecoz.Location = new System.Drawing.Point(164, 105);
            this.rota_sifrecoz.Name = "rota_sifrecoz";
            this.rota_sifrecoz.Size = new System.Drawing.Size(75, 23);
            this.rota_sifrecoz.TabIndex = 5;
            this.rota_sifrecoz.Text = "Sifre Çöz";
            this.rota_sifrecoz.UseVisualStyleBackColor = true;
            // 
            // rota_sifrele
            // 
            this.rota_sifrele.Location = new System.Drawing.Point(78, 104);
            this.rota_sifrele.Name = "rota_sifrele";
            this.rota_sifrele.Size = new System.Drawing.Size(75, 23);
            this.rota_sifrele.TabIndex = 4;
            this.rota_sifrele.Text = "Sifrele";
            this.rota_sifrele.UseVisualStyleBackColor = true;
            this.rota_sifrele.Click += new System.EventHandler(this.rota_sifrele_Click);
            // 
            // rota_sifreliveri
            // 
            this.rota_sifreliveri.Location = new System.Drawing.Point(77, 78);
            this.rota_sifreliveri.Name = "rota_sifreliveri";
            this.rota_sifreliveri.Size = new System.Drawing.Size(161, 20);
            this.rota_sifreliveri.TabIndex = 3;
            // 
            // rota_veri
            // 
            this.rota_veri.Location = new System.Drawing.Point(78, 52);
            this.rota_veri.Name = "rota_veri";
            this.rota_veri.Size = new System.Drawing.Size(161, 20);
            this.rota_veri.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Anahtar";
            // 
            // rota_anahtar
            // 
            this.rota_anahtar.Location = new System.Drawing.Point(78, 26);
            this.rota_anahtar.Name = "rota_anahtar";
            this.rota_anahtar.Size = new System.Drawing.Size(161, 20);
            this.rota_anahtar.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.vig_sifrecoz);
            this.groupBox7.Controls.Add(this.vig_sifrele);
            this.groupBox7.Controls.Add(this.vig_sifreliveri);
            this.groupBox7.Controls.Add(this.vig_veri);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.vig_anahtar);
            this.groupBox7.Location = new System.Drawing.Point(841, 236);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(270, 134);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vigenere Şifreleme";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Şifreli Veri";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Veri";
            // 
            // vig_sifrecoz
            // 
            this.vig_sifrecoz.Location = new System.Drawing.Point(183, 104);
            this.vig_sifrecoz.Name = "vig_sifrecoz";
            this.vig_sifrecoz.Size = new System.Drawing.Size(75, 23);
            this.vig_sifrecoz.TabIndex = 5;
            this.vig_sifrecoz.Text = "Sifre Çöz";
            this.vig_sifrecoz.UseVisualStyleBackColor = true;
            this.vig_sifrecoz.Click += new System.EventHandler(this.vig_sifrecoz_Click);
            // 
            // vig_sifrele
            // 
            this.vig_sifrele.Location = new System.Drawing.Point(97, 103);
            this.vig_sifrele.Name = "vig_sifrele";
            this.vig_sifrele.Size = new System.Drawing.Size(75, 23);
            this.vig_sifrele.TabIndex = 4;
            this.vig_sifrele.Text = "Sifrele";
            this.vig_sifrele.UseVisualStyleBackColor = true;
            this.vig_sifrele.Click += new System.EventHandler(this.vig_sifrele_Click);
            // 
            // vig_sifreliveri
            // 
            this.vig_sifreliveri.Location = new System.Drawing.Point(98, 77);
            this.vig_sifreliveri.Name = "vig_sifreliveri";
            this.vig_sifreliveri.Size = new System.Drawing.Size(160, 20);
            this.vig_sifreliveri.TabIndex = 3;
            // 
            // vig_veri
            // 
            this.vig_veri.Location = new System.Drawing.Point(98, 51);
            this.vig_veri.Name = "vig_veri";
            this.vig_veri.Size = new System.Drawing.Size(161, 20);
            this.vig_veri.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Anahtar (kelime)";
            // 
            // vig_anahtar
            // 
            this.vig_anahtar.Location = new System.Drawing.Point(98, 25);
            this.vig_anahtar.Name = "vig_anahtar";
            this.vig_anahtar.Size = new System.Drawing.Size(161, 20);
            this.vig_anahtar.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.kare_sifrecoz);
            this.groupBox8.Controls.Add(this.kare_sifrele);
            this.groupBox8.Controls.Add(this.kare_sifreliveri);
            this.groupBox8.Controls.Add(this.kare_veri);
            this.groupBox8.Location = new System.Drawing.Point(841, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(270, 115);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "4 Kare Şifreleme";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Şifreli Veri";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Veri";
            // 
            // kare_sifrecoz
            // 
            this.kare_sifrecoz.Location = new System.Drawing.Point(184, 82);
            this.kare_sifrecoz.Name = "kare_sifrecoz";
            this.kare_sifrecoz.Size = new System.Drawing.Size(75, 23);
            this.kare_sifrecoz.TabIndex = 5;
            this.kare_sifrecoz.Text = "Sifre Çöz";
            this.kare_sifrecoz.UseVisualStyleBackColor = true;
            // 
            // kare_sifrele
            // 
            this.kare_sifrele.Location = new System.Drawing.Point(97, 82);
            this.kare_sifrele.Name = "kare_sifrele";
            this.kare_sifrele.Size = new System.Drawing.Size(75, 23);
            this.kare_sifrele.TabIndex = 4;
            this.kare_sifrele.Text = "Sifrele";
            this.kare_sifrele.UseVisualStyleBackColor = true;
            this.kare_sifrele.Click += new System.EventHandler(this.kare_sifrele_Click);
            // 
            // kare_sifreliveri
            // 
            this.kare_sifreliveri.Location = new System.Drawing.Point(97, 56);
            this.kare_sifreliveri.Name = "kare_sifreliveri";
            this.kare_sifreliveri.Size = new System.Drawing.Size(160, 20);
            this.kare_sifreliveri.TabIndex = 3;
            // 
            // kare_veri
            // 
            this.kare_veri.Location = new System.Drawing.Point(97, 30);
            this.kare_veri.Name = "kare_veri";
            this.kare_veri.Size = new System.Drawing.Size(161, 20);
            this.kare_veri.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 397);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dogrusalAnahtar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dogrusalAnahtar2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dogrusalVeri;
        private System.Windows.Forms.TextBox dogrusalSifreliVeri;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button trans_sifrecoz;
        private System.Windows.Forms.Button trans_sifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox trans_veri;
        private System.Windows.Forms.TextBox trans_sifreliveri;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox perm_sifreliveri;
        private System.Windows.Forms.Button perm_sifrecoz;
        private System.Windows.Forms.Button perm_sifrele;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox perm_anahtar;
        private System.Windows.Forms.TextBox perm_veri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox perm_dizi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button rota_sifrecoz;
        private System.Windows.Forms.Button rota_sifrele;
        private System.Windows.Forms.TextBox rota_sifreliveri;
        private System.Windows.Forms.TextBox rota_veri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rota_anahtar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button vig_sifrecoz;
        private System.Windows.Forms.Button vig_sifrele;
        private System.Windows.Forms.TextBox vig_sifreliveri;
        private System.Windows.Forms.TextBox vig_veri;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox vig_anahtar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button kare_sifrecoz;
        private System.Windows.Forms.Button kare_sifrele;
        private System.Windows.Forms.TextBox kare_sifreliveri;
        private System.Windows.Forms.TextBox kare_veri;
    }
}

