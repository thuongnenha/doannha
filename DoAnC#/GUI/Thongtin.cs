using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Thongtin : Form
    {
        public Thongtin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreManager storeManager = new StoreManager();
            storeManager.ShowDialog();
            this.Close();
        }
        private void Thongtin_Load(object sender, EventArgs e)
        {
            if(Session.chucVu == "admin")
            {
                txtHo_TT.Text = Session.admin.Ho;
                txtTen_TT.Text = Session.admin.Ten;
                txtEmail_TT.Text = Session.admin.Email;
                txtSDT_TT.Text = Session.admin.PhoneNumber;
                txtMK_TT.Text = Session.admin.Password;
                txtMKA_TT.Text = Session.admin.Password;
            }else if(Session.chucVu == "nhanvien")
            {
                txtHo_TT.Text = Session.nhanVien.Ho;
                txtTen_TT.Text = Session.nhanVien.Ten;
                txtEmail_TT.Text = Session.nhanVien.Email;
                txtSDT_TT.Text = Session.nhanVien.PhoneNumber;
                txtMK_TT.Text = Session.nhanVien.Password;
                txtMKA_TT.Text = Session.nhanVien.Password;
            }
        }

        private void btnXN_TT_Click(object sender, EventArgs e)
        {

        }
    }
}
