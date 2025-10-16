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
    public partial class QLBill : UserControl
    {
        public QLBill()
        {
            InitializeComponent();
        }
        AdminBUS billBUS = new AdminBUS();
        List<BillDTO> dsbill;

        BillDTO bill;

        AdminBUS ban_nv_the = new AdminBUS();
        List<TablesDTO> dsban;
        List<NhanVienDTO> dsnv;
        List<TheTVDTO> dsthe;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamBill())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (ThemMoiBILL(bill))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSBILL();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }

        private void QLBill_Load(object sender, EventArgs e)
        {
            LoadDSBAN();
            dgvDSBILL.AutoGenerateColumns = false;
            LoadDSBILL();
        }


        private void LoadDSBAN()
        {
            dsban = ban_nv_the.LoaddsBan();

            cmbBANID.DataSource = dsban;
            cmbBANID.DisplayMember = "Name";
            cmbBANID.ValueMember = "ID";
        }

        private void LoadDSBILL()
        {

            dsbill = billBUS.Loaddsbill();
            dgvDSBILL.DataSource = dsbill;
        }
        private bool ThemMoiBILL(BillDTO bill)
        {
            AdminBUS thembill = new AdminBUS();
            int kq = thembill.ThemBill(bill);
            return kq > 0;
        }

        private void LayThongTin()
        {
            if (bill == null)
            {
                bill = new BillDTO();
            }
            bill.TableID = int.Parse(cmbBANID.SelectedValue.ToString());
            bill.UserID = cmbNVID.Text;
            bill.TheID = int.Parse(txtTHEID.Text);
            bill.TienKhachDua = decimal.Parse(txtTKD.Text);
            bill.TienTraKhach = decimal.Parse(txtTTK.Text);
            bill.Sum = decimal.Parse(txtSum.Text);
            bill.Status = chkTrangThai.Checked;
        }

        private bool XuLiViPhamBill()
        {
            if (billBUS.ViPhamBILL(cmbBANID.SelectedValue.ToString(), cmbNVID.Text, txtTHEID.Text, txtTKD.Text, txtTTK.Text, txtSum.Text))
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

                if (XoaBoBILL(bill))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSBILL();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoBILL(BillDTO bill)
        {
            AdminBUS xoabill = new AdminBUS();
            int kq = xoabill.XoaBill(bill);
            return kq > 0;
        }

        
        private void LoadThongTin()
        {

            if (bill != null)
            {
                txtIDBill.Text = bill.ID.ToString();
                cmbBANID.SelectedValue = bill.TableID;
                cmbNVID.Text = bill.UserID.ToString();
                txtTHEID.Text = bill.TheID.ToString();

                txtTKD.Text = bill.TienKhachDua.ToString();
                txtTTK.Text = bill.TienTraKhach.ToString();
                txtSum.Text = bill.Sum.ToString();
                chkTrangThai.Checked = bill.Status;
                txtIDBill.ReadOnly = true;
            }
            else
            {
                bill = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamBill())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (SuaDoiBILL(bill))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSBILL();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiBILL(BillDTO bill)
        {
            AdminBUS suabill = new AdminBUS();
            int kq = suabill.SuaBill(bill);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSBILL.ClearSelection();
            LoadDSBILL();
            txtTKBill.Clear();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSBILL_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvDSBILL.SelectedRows.Count > 0)
            {
                bill = dgvDSBILL.SelectedRows[0].DataBoundItem as BillDTO;
                LoadThongTin();

            }
            else
            {
                txtIDBill.Clear();
                cmbBANID.SelectedIndex = 0;
                cmbNVID.Clear();
                txtTHEID.Clear();
                txtTKD.Clear();
                txtTTK.Clear();
                txtSum.Clear();
                chkTrangThai.Checked = false;


            }
        }

        private void txtTKD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtTKD.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtTTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtTTK.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtSum.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
