using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKİ_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSize = true;

            this.Text = "Vücut Kitle İndeksi (VKİ) Hesaplayıcı";
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)(HTCAPTION);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxBoy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxKilo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği boy ve kilo değerlerini alıyoruz
                double boy = Convert.ToDouble(textBoxBoy.Text);
                double kilo = Convert.ToDouble(textBoxKilo.Text);

                // VKİ'yi hesapla
                double vki = kilo / ((boy / 100) * (boy / 100));

                // VKİ sonucunu TextBox'ta göster
                textBoxVKI.Text = vki.ToString("N2"); // Sonucu 2 ondalık basamaklı olarak göster
                labelDurum.Text = "VKİ Durumu: " + VKIDurumu(vki);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli boy ve kilo değerleri girin.");
            }
        }
        private string VKIDurumu(double vki)
        {
            if (vki < 18.5)
            {
                return "Zayıf";
            }
            else if (vki >= 18.5 && vki < 24.9)
            {
                return "Normal";
            }
            else if (vki >= 25 && vki < 29.9)
            {
                return "Fazla Kilolu";
            }
            else if (vki >= 30 && vki < 34.9)
            {
                return "Şişman (Obez) - Tip 1";
            }
            else if (vki >= 35 && vki < 39.9)
            {
                return "Şişman (Obez) - Tip 2";
            }
            else
            {
                return "Aşırı Şişman (Aşırı Obez)";
            }
        }

    }
}
