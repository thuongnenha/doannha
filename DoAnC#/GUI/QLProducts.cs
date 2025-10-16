using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class QLProducts : UserControl
    {
        private readonly string path = @"E:\DoAn\ImageFood\";
        public QLProducts()
        {
            InitializeComponent();
        }
        AdminBUS spBUS = new AdminBUS();
        List<ProductsDTO> dssanpham;

        ProductsDTO sp;

        AdminBUS Category = new AdminBUS();
        List<CategoryDTO> dsloaisp;
        private void QLProducts_Load(object sender, EventArgs e)
        {
            LoadDSLOAISP();
            dgvDSSP.AutoGenerateColumns = false;
            LoadDSSP();
        }
        private void LoadDSLOAISP()
        {
            dsloaisp = Category.Loaddsloaisp();

            cmbLoaiSP.DataSource = dsloaisp;
            cmbLoaiSP.DisplayMember = "Name";
            cmbLoaiSP.ValueMember = "ID";
        }

        private void LoadDSSP()
        {
            dssanpham = spBUS.Loaddssp();
            dgvDSSP.DataSource = dssanpham;

            dsloaisp = Category.Loaddsloaisp();
            colLoaiSP.DataSource = dsloaisp;
            colLoaiSP.DisplayMember = "Name";
            colLoaiSP.ValueMember = "ID";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamSanPham())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (ThemMoiSP(sp))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSSP();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiSP(ProductsDTO sp)
        {
            AdminBUS themsp = new AdminBUS();
            int kq = themsp.ThemSanPham(sp);
            return kq > 0;
        }

        private void LayThongTin()
        {
            if (sp == null)
            {
                sp = new ProductsDTO();
            }
            sp.Name = txtTenSP.Text;
            sp.Gia = decimal.Parse(txtGiaSP.Text);
            sp.CategoryID = int.Parse(cmbLoaiSP.SelectedValue.ToString());
            sp.KhuyenMai = int.Parse(txtKhuyenMai.Text);
            sp.MoTa = txtMoTa.Text;
            sp.TrangThai = chkTrangThai.Checked;
            sp.ImageFood = txtTenSP.Text;
        }
        private bool XuLiViPhamSanPham()
        {

            if (spBUS.ViPhamSP(txtTenSP.Text, txtGiaSP.Text, cmbLoaiSP.SelectedValue.ToString(), txtKhuyenMai.Text, txtMoTa.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                if (XoaBoSP(sp))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSSP();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoSP(ProductsDTO sp)
        {
            AdminBUS xoasp = new AdminBUS();
            int kq = xoasp.XoaSanPham(sp);
            return kq > 0;
        }

        private void LoadThongTin()
        {
            if (sp != null)
            {
                txtIDSP.Text = sp.ID.ToString();
                txtTenSP.Text = sp.Name;
                txtGiaSP.Text = sp.Gia.ToString();
                cmbLoaiSP.SelectedValue = sp.CategoryID;
                txtKhuyenMai.Text = sp.KhuyenMai.ToString();
                txtMoTa.Text = sp.MoTa;
                chkTrangThai.Checked = sp.TrangThai;
                pictureBoxHA.Image = TimHinhAnhTheoTenMon(path, sp.ImageFood);
                txtIDSP.ReadOnly = true;
            }
            else
            {
                sp = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSSP.ClearSelection();
            LoadDSSP();
            txtTKSP.Clear();
        }
        private bool SuaDoiSP(ProductsDTO sp)
        {
            AdminBUS suasp = new AdminBUS();
            int kq = suasp.SuaSanPham(sp);
            return kq > 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamSanPham())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (SuaDoiSP(sp))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSSP();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                TKDSSP(txtTKSP.Text);
            }
        }
        private void TKDSSP(string ten)
        {
            dssanpham = spBUS.TimKiemSanPham(ten);
            dgvDSSP.DataSource = dssanpham;

        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSSP_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvDSSP.SelectedRows.Count > 0)
            {
                sp = dgvDSSP.SelectedRows[0].DataBoundItem as ProductsDTO;
                LoadThongTin();

            }
            else
            {
                txtIDSP.Clear();
                txtTenSP.Clear();
                txtGiaSP.Clear();
                cmbLoaiSP.SelectedIndex = 0;
                txtKhuyenMai.Clear();
                txtMoTa.Clear();
                chkTrangThai.Checked = false;


            }


        }

        private Image TimHinhAnhTheoTenMon(string folderPath, string tenMon)
        {
            string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            foreach (string ext in extensions)
            {
                string fullPath = Path.Combine(folderPath, tenMon + ext);
                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }

            return null; // Không tìm thấy
        }

        private void pictureBoxHA_Click(object sender, EventArgs e)
        {
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                MessageBox.Show("Hãy nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
           
        }

        private void txtGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtGiaSP.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
           
        }

       
    }
}
