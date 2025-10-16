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
    public partial class Admin : Form
    {
        private ChamCongBUS chamCongBUS = new ChamCongBUS();
        public Admin()
        {
            InitializeComponent();
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thongtin thongtin = new Thongtin();
            thongtin.ShowDialog();
            this.Close();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelHQL.Controls.Clear();         // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;           // Cho vừa khít panel
            panelHQL.Controls.Add(uc);         // Thêm control vào
            uc.BringToFront();                  // Đảm bảo hiển thị lên trên
        }
        private void QuaylaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controler controler = new Controler();
            controler.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamCongBUS.gioRa(Session.time.Value);
            Session.time = null;
            Session.userID = null;
            Session.chucVu = null;
            Session.admin = null;
            Session.nhanVien = null;
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLProducts());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLNhanVien());
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLBill());
        }

        private void btnQLLSP_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLLoaiSP());
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLBan());
        }

        private void btnQLTHETV_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLTheTV());
        }

        private void btnQLCC_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLChamCong());
        }

        private void btnQLCTHD_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLChiTietHoaDon());
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLDoanhThu());
        }
    }
}
