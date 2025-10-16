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

namespace GUI
{
    public partial class Controler : Form
    {
        private ControlerBUS controlerBUS = new ControlerBUS();
        public Controler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreManager storeManager = new StoreManager();
            storeManager.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheTV theTV = new TheTV();
            theTV.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (controlerBUS.checkDangNhap())
            {
                this.Hide();
                Admin admin = new Admin();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có đủ thẩm quyền để truy cập", "Thông Báo", MessageBoxButtons.OK);
            }
            
        }
    }
}
