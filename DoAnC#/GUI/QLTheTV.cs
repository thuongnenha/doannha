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
    public partial class QLTheTV : UserControl
    {
        public QLTheTV()
        {
            InitializeComponent();
        }
        AdminBUS theBUS = new AdminBUS();
        List<TheTVDTO> dsthe;

        TheTVDTO the;

        AdminBUS nhavien = new AdminBUS();
        List<NhanVienDTO> dsnv;

        private void QLTheTV_Load(object sender, EventArgs e)
        {

            dgvDSTHETV.AutoGenerateColumns = false;
            LoadDSTHE();
        }

        private void LoadDSTHE()
        {
            dsthe = theBUS.Loaddsthe();
            dgvDSTHETV.DataSource = dsthe;
        }   
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamThe())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else if (txtSĐT.Text.Length != 10)
            {
                MessageBox.Show("Nhập 10 số", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinThe();
                if (ThemMoiTHE(the))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSTHE();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiTHE(TheTVDTO the)
        {
            AdminBUS themthe = new AdminBUS();
            int kq = themthe.ThemThetv(the);
            return kq > 0;
        }

        private void LayThongTinThe()
        {
            if (the == null)
            {
                the = new TheTVDTO();
            }
            the.UserID = cmbNVID.Text;
            the.FullName = txtTenThe.Text;
            the.PhoneNumber = txtSĐT.Text;
            the.DiaChi = txtDiaChi.Text;
            the.TrangThai = chkTrangThai.Checked;
        }

        private bool XuLiViPhamThe()
        {
            if (theBUS.ViPhamTHE(cmbNVID.Text, txtTenThe.Text, txtSĐT.Text, txtDiaChi.Text))
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

                if (XoaBoTHE(the))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSTHE();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoTHE(TheTVDTO the)
        {
            AdminBUS xoathe = new AdminBUS();
            int kq = xoathe.XoaThetv(the);
            return kq > 0;
        }

        private void dgvDSTHETV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSTHETV.SelectedRows.Count > 0)
            {
                the = dgvDSTHETV.SelectedRows[0].DataBoundItem as TheTVDTO;
                LoadThongTinThe();

            }
            else
            {
                txtIDTHE.Clear();
                cmbNVID.Clear();
                txtTenThe.Clear();
                txtSĐT.Clear();
                txtDiaChi.Clear();
                chkTrangThai.Checked = false;
            }
        }
        private void LoadThongTinThe()
        {
            if (the != null)
            {
                txtIDTHE.Text = the.ID.ToString();
                cmbNVID.Text = the.UserID.ToString();
                txtTenThe.Text = the.FullName;
                txtSĐT.Text = the.PhoneNumber;
                txtDiaChi.Text = the.DiaChi;
                chkTrangThai.Checked = the.TrangThai;
                txtIDTHE.ReadOnly = true;
            }
            else
            {
                the = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamThe())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else if (txtSĐT.Text.Length != 10)
            {
                MessageBox.Show("Nhập 10 số", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinThe();
                if (SuaDoiTHE(the))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSTHE();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiTHE(TheTVDTO the)
        {
            AdminBUS suathe = new AdminBUS();
            int kq = suathe.SuaThetv(the);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSTHETV.ClearSelection();
            LoadDSTHE();
            txtTKThe.Clear();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKThe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                TKDSTHE(txtTKThe.Text);
            }
        }
        private void TKDSTHE(string ten)
        {
            dsthe = theBUS.TimKiemThetv(ten);
            dgvDSTHETV.DataSource = dsthe;
        }

        private void txtTenThe_KeyPress(object sender, KeyPressEventArgs e)
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
