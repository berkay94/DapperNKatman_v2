using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int k= bll.PersonelKaydet(textAd.Text, textSoyad.Text, maskedTel.Text, textEmail.Text, int.Parse(textMaas.Text), textSehir.Text, textDepartman.Text);


            if (k>0)
            {
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
         
                MessageBox.Show("Girilen Değerlerde Eksiklik Var!!");
            }
            
        }

        private void textMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
           
            {
                MessageBox.Show("email doğru biçimde değil");
                textEmail.Clear();
                textEmail.Focus();
            }
            
        }
    }
}
