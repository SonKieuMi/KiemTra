using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lab_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text;
            string password = textboxmatkhau.Text;
            if(username=="admin" && password == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
        }
    }
}
