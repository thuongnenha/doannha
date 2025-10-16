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
    public partial class QLNhanVien : UserControl
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }
        AdminBUS nvBUS = new AdminBUS();
        List<NhanVienDTO> dsnhanvien;

        NhanVienDTO nv;
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.AutoGenerateColumns = false;
            LoadDSNV();
        }
        private void LoadDSNV()
        {
            dsnhanvien = nvBUS.Loaddsnv();
            dgvDSNV.DataSource = dsnhanvien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamNhanVien())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else if (XuLiViPhamEmailNhanVien())
            {
                MessageBox.Show("Nhập sai định dang email", "Cảnh báo");
                return;
            }
            else if (txtSĐT.Text.Length != 10)
            {
                MessageBox.Show("Nhập 10 số", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (ThemMoiNV(nv))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSNV();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool XuLiViPhamEmailNhanVien()
        {
            if (nvBUS.ViPhamEmailNV(txtEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ThemMoiNV(NhanVienDTO nv)
        {
            AdminBUS themnv = new AdminBUS();
            int kq = themnv.ThemNhanVien(nv);
            return kq > 0;
        }

        private void LayThongTin()
        {
            if (nv == null)
            {
                nv = new NhanVienDTO();
                nv.ID = txtID.Text;
            }
            nv.Ho = txtHoNV.Text;
            nv.Ten = txtTenNV.Text;
            nv.Luong = Decimal.Parse(txtLuong.Text);
            nv.PhoneNumber = txtSĐT.Text;
            nv.Email = txtEmail.Text;
            nv.Password = txtPW.Text;
        }
        private bool XuLiViPhamNhanVien()
        {
            if (nvBUS.ViPhamNV(txtID.Text, txtHoNV.Text, txtTenNV.Text, txtLuong.Text, txtSĐT.Text, txtEmail.Text, txtPW.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamNhanVien())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else if (XuLiViPhamEmailNhanVien())
            {
                MessageBox.Show("Nhập sai định dang email", "Cảnh báo");
                return;
            }
            else if (txtSĐT.Text.Length != 10)
            {
                MessageBox.Show("Nhập 10 số", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (SuaDoiNV(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSNV();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiNV(NhanVienDTO nv)
        {
            AdminBUS suanv = new AdminBUS();
            int kq = suanv.SuaNhanVien(nv);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                if (XoaBoNV(nv))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSNV();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoNV(NhanVienDTO nv)
        {
            AdminBUS xoanv = new AdminBUS();
            int kq = xoanv.XoaNhanVien(nv);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSNV.ClearSelection();
            txtID.ReadOnly = false;
            txtTKNV.Clear();
            LoadDSNV();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                TKDSNV(txtTKNV.Text);
            }
        }
        private void TKDSNV(string tennv)
        {
            dsnhanvien = nvBUS.TimKiemNhanVien(tennv);
            dgvDSNV.DataSource = dsnhanvien;
        }

        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
                nv = dgvDSNV.SelectedRows[0].DataBoundItem as NhanVienDTO;
                LoadThongTin();

            }
            else
            {
                txtID.Clear();
                txtHoNV.Clear();
                txtTenNV.Clear();
                txtLuong.Clear();
                txtSĐT.Clear();
                txtEmail.Clear();
                txtPW.Clear();


            }
        }
        private void LoadThongTin()
        {
            if (nv != null)
            {
                txtID.Text = nv.ID;
                txtHoNV.Text = nv.Ho;
                txtTenNV.Text = nv.Ten;
                txtLuong.Text = nv.Luong.ToString();
                txtSĐT.Text = nv.PhoneNumber;
                txtEmail.Text = nv.Email;
                txtPW.Text = nv.Password;
                txtID.ReadOnly = true;
            }
            else
            {
                nv = null;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtLuong.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtHoNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                MessageBox.Show("Hãy nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
      
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            
            
        }
    }
}
