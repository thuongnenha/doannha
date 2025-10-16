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
    public partial class QLChiTietHoaDon : UserControl
    {
        public QLChiTietHoaDon()
        {
            InitializeComponent();
        }
        AdminBUS cthdBUS = new AdminBUS();
        List<BillInfoDTO> dscthd;

        BillInfoDTO bif;

        AdminBUS bill_sp = new AdminBUS();
        List<BillDTO> dsbill;
        List<ProductsDTO> dssp;
        private void QLChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSBILL();
            LoadDSSP();
            dgvDSCTHD.AutoGenerateColumns = false;
            LoadDSCTHD();
        }

        private void LoadDSSP()
        {
            dssp = bill_sp.Loaddssp();

            cmbSPID.DataSource = dssp;
            cmbSPID.DisplayMember = "Name";
            cmbSPID.ValueMember = "ID";
        }

        private void LoadDSBILL()
        {
            dsbill = bill_sp.Loaddsbill();

            cmbBILLID.DataSource = dsbill;
            cmbBILLID.DisplayMember = "ID";
            cmbBILLID.ValueMember = "ID";
        }
        private void LoadDSCTHD()
        {
            dscthd = cthdBUS.Loaddscthd();
            dgvDSCTHD.DataSource = dscthd;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamCTHD())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinCTHD();
                if (ThemMoiCTHD(bif))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSCTHD();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiCTHD(BillInfoDTO bif)
        {
            AdminBUS themcthd = new AdminBUS();
            int kq = themcthd.Themcthd(bif);
            return kq > 0;
        }

        private void LayThongTinCTHD()
        {
            if (bif == null)
            {
                bif = new BillInfoDTO();
            }
            bif.BillID = int.Parse(cmbBILLID.SelectedValue.ToString());
            bif.ProductsID = int.Parse(cmbSPID.SelectedValue.ToString());
            bif.SoLuong = int.Parse(txtSoLuong.Text);
            bif.Gia = decimal.Parse(txtGia.Text);
            bif.ThanhTien = decimal.Parse(txtThanhTien.Text);
            bif.KhuyenMai = int.Parse(txtKhuyenMai.Text);
        }

        private bool XuLiViPhamCTHD()
        {
            if (cthdBUS.ViPhamCTHD(cmbBILLID.SelectedValue.ToString(), cmbSPID.SelectedValue.ToString(), txtSoLuong.Text, txtGia.Text, txtThanhTien.Text, txtKhuyenMai.Text))
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

                if (XoaBoCTHD(bif))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSCTHD();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoCTHD(BillInfoDTO bif)
        {
            AdminBUS xoacthd = new AdminBUS();
            int kq = xoacthd.Xoacthd(bif);
            return kq > 0;
        }

        private void dgvDSCTHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSCTHD.SelectedRows.Count > 0)
            {
                bif = dgvDSCTHD.SelectedRows[0].DataBoundItem as BillInfoDTO;
                LoadThongTin();

            }
            else
            {
                txtIDCTHD.Clear();
                cmbBILLID.SelectedIndex = 0;
                cmbSPID.SelectedIndex = 0;
                txtSoLuong.Clear();
                txtGia.Clear();
                txtThanhTien.Clear();
                txtKhuyenMai.Clear();

            }
        }
        private void LoadThongTin()
        {
            if (bif != null)
            {
                txtIDCTHD.Text = bif.ID.ToString();
                cmbBILLID.SelectedValue = bif.BillID;
                cmbSPID.SelectedValue = bif.ProductsID;
                txtSoLuong.Text = bif.SoLuong.ToString();
                txtGia.Text = bif.Gia.ToString();
                txtThanhTien.Text = bif.ThanhTien.ToString();
                txtKhuyenMai.Text = bif.KhuyenMai.ToString();

            }
            else
            {
                bif = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamCTHD())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinCTHD();
                if (SuaDoiCTHD(bif))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSCTHD();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiCTHD(BillInfoDTO bif)
        {

            AdminBUS suacthd = new AdminBUS();
            int kq = suacthd.Suacthd(bif);
            return kq > 0;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSCTHD.ClearSelection();
            LoadDSCTHD();
            txtTK.Clear();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtGia.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtThanhTien.Text.Contains('.'))
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
