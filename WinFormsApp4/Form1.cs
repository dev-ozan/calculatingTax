using System.Runtime.CompilerServices;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void KdvHesapla(decimal yuzdeOrani)
        {
            try
            {
                decimal fiyat = Convert.ToInt32(fiyatText.Text);
                decimal fiyat1 = fiyat * yuzdeOrani;
                MessageBox.Show(fiyat1.ToString());

            }
            catch {

                MessageBox.Show("Lütfen Sayı giriniz");

            }
       


        }


        private void btnDiger_Click(object sender, EventArgs e)
        {
            KdvHesapla(1.18m);
           // int fiyat2 = Convert.ToInt32(fiyatText.Text);
          //  int kdvDiger = (fiyat2 / 100) * 18;
           // MessageBox.Show(kdvDiger.ToString());




        }

        private void btnGida_Click(object sender, EventArgs e)
        {
            KdvHesapla(1.08m);
          //// int kdvDiger = (fiyat3 / 100) * 8;
           // MessageBox.Show(kdvDiger.ToString());
        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            KdvHesapla(1.01m);
        //    int fiyat4 = Convert.ToInt32(fiyatText.Text);
          //  int kdvDiger = (fiyat4 / 100) * 1;
           // MessageBox.Show(kdvDiger.ToString());
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }
    }
}