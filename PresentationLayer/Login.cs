using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        BusinessLogicLayer bl;
        public Login()
        {
            InitializeComponent();

            bl= new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(bl.LoginKontrol(textBox1.Text, textBox2.Text)>0)
            {
                this.Visible = false;
                MainForm main = new MainForm();
                main.Show();
            }
           else
            {
                MessageBox.Show("Girilen Bilgiler Hatalıdır");
                textBox1.Clear();
                textBox2.Clear();

            }
        }
    }
}
