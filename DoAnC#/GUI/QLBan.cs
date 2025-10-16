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
    public partial class QLBan : UserControl
    {
        public QLBan()
        {
            InitializeComponent();
        }
        AdminBUS banBUS = new AdminBUS();
        List<TablesDTO> dsban;

        TablesDTO ban;

        private void LoadDSBAN()
        {
            dsban = banBUS.LoaddsBan();
            dgvDSBAN.DataSource = dsban;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamBan())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (ThemMoiBAN(ban))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSBAN();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiBAN(TablesDTO ban)
        {
            AdminBUS themban = new AdminBUS();
            int kq = themban.ThemBan(ban);
            return kq > 0;
        }
        private void LayThongTin()
        {
            if (ban == null)
            {
                ban = new TablesDTO();
            }
            ban.Name = txtTenBan.Text;
            ban.Status = chkTrangThai.Checked;
        }

        private bool XuLiViPhamBan()
        {
            if (banBUS.ViPhamBAN(txtTenBan.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void QLBan_Load(object sender, EventArgs e)
        {
            dsban = banBUS.LoaddsBan();
            dgvDSBAN.DataSource = dsban;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamBan())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (SuaDoiBAN(ban))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSBAN();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiBAN(TablesDTO ban)
        {
            AdminBUS suaban = new AdminBUS();
            int kq = suaban.SuaBan(ban);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                if (XoaBoBAN(ban))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSBAN();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }

        }
        private bool XoaBoBAN(TablesDTO ban)
        {
            AdminBUS xoaban = new AdminBUS();
            int kq = xoaban.XoaBan(ban);
            return kq > 0;
        }

        private void dgvDSBAN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSBAN.SelectedRows.Count > 0)
            {
                ban = dgvDSBAN.SelectedRows[0].DataBoundItem as TablesDTO;
                LoadThongTin();

            }
            else
            {
                txtIDBan.Clear();
                txtTenBan.Clear();
                chkTrangThai.Checked = false;
            }
        }
        private void LoadThongTin()
        {
            if (ban != null)
            {
                txtIDBan.Text = ban.ID.ToString();
                txtTenBan.Text = ban.Name;
                chkTrangThai.Checked = ban.Status;
                txtIDBan.ReadOnly = true;
            }
            else
            {
                ban = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSBAN.ClearSelection();
            LoadDSBAN();
            txtTKBan.Clear();   
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTKBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                TKDSBAN(txtTKBan.Text);
            }
        }
        private void TKDSBAN(string ten)
        {
            dsban = banBUS.TimKiemBan(ten);
            dgvDSBAN.DataSource = dsban;
        }

       
    }
}
