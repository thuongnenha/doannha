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
    public partial class QLLoaiSP : UserControl
    {
        public QLLoaiSP()
        {
            InitializeComponent();
        }
        AdminBUS ctgrBUS = new AdminBUS();
        List<CategoryDTO> dsloai;

        CategoryDTO loai;
        private void QLLoaiSP_Load(object sender, EventArgs e)
        {
            dgvDSLOAISP.AutoGenerateColumns = false;
            LoadDSLOAISP();
        }
        private void LoadDSLOAISP()
        {
            dsloai = ctgrBUS.Loaddsloaisp();
            dgvDSLOAISP.DataSource = dsloai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamLoaiSP())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinLoaiSP();
                if (ThemMoiLOAISP(loai))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSLOAISP();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiLOAISP(CategoryDTO loai)
        {
            AdminBUS themloai = new AdminBUS();
            int kq = themloai.ThemLoaisp(loai);
            return kq > 0;
        }

        private void LayThongTinLoaiSP()
        {
            if (loai == null)
            {
                loai = new CategoryDTO();
            }
            loai.Name = txtTenLoai.Text;
        }

        private bool XuLiViPhamLoaiSP()
        {
            if (ctgrBUS.ViPhamLOAISP(txtTenLoai.Text))
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

                if (XoaBLOAISP(loai))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSLOAISP();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBLOAISP(CategoryDTO loai)
        {
            AdminBUS xoaloai = new AdminBUS();
            int kq = xoaloai.XoaLoaisp(loai);
            return kq > 0;
        }

        private void dgvDSLOAISP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSLOAISP.SelectedRows.Count > 0)
            {
                loai = dgvDSLOAISP.SelectedRows[0].DataBoundItem as CategoryDTO;
                LoadThongTin();

            }
            else
            {
                txtIDLoaiSP.Clear();
                txtTenLoai.Clear();
            }
        }
        private void LoadThongTin()
        {
            if (loai != null)
            {
                txtIDLoaiSP.Text = loai.ID.ToString();
                txtTenLoai.Text = loai.Name;
                txtIDLoaiSP.ReadOnly = true;
            }
            else
            {
                loai = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamLoaiSP())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinLoaiSP();
                if (SuaDoiLOAISP(loai))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSLOAISP();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiLOAISP(CategoryDTO loai)
        {
            AdminBUS sualoai = new AdminBUS();
            int kq = sualoai.SuaLoaisp(loai);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSLOAISP.ClearSelection();
            LoadDSLOAISP();
            txtTKLoaiSP.Clear();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKLoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                TKDSLOAISP(txtTKLoaiSP.Text);
            }
        }
        private void TKDSLOAISP(string ten)
        {
            dsloai = ctgrBUS.TimKiemLoaisp(ten);
            dgvDSLOAISP.DataSource = dsloai;
        }

        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            
        }
    }
}
