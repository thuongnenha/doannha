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
    public partial class QLChamCong : UserControl
    {
        public QLChamCong()
        {
            InitializeComponent();
        }
        AdminBUS ccBUS = new AdminBUS();
        List<ChamCongDTO> dsbcc;

        ChamCongDTO cc;

        AdminBUS nhanvien = new AdminBUS();
        List<NhanVienDTO> dsnv;
        private void QLChamCong_Load(object sender, EventArgs e)
        {
            dgvDSCC.AutoGenerateColumns = false;
            LoadDSCC();
        }


        private void LoadDSCC()
        {
            dsbcc = ccBUS.Loaddscc();
            dgvDSCC.DataSource = dsbcc;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamCC())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinCC();
                if (ThemMoiCC(cc))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadDSCC();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        private bool ThemMoiCC(ChamCongDTO cc)
        {
            AdminBUS themcc = new AdminBUS();
            int kq = themcc.Themcc(cc);
            return kq > 0;
        }

        private void LayThongTinCC()
        {
            if (cc == null)
            {
                cc = new ChamCongDTO();
            }
            cc.UserID = cmbNVID.Text;
            cc.Ngay = dtpNgay.Value;

            // Lấy phần giờ phút từ DateTimePicker rồi chuyển sang TimeSpan
            cc.GioVao = dtpGioVao.Value.TimeOfDay;
            cc.GioRa = dtpGioRa.Value.TimeOfDay;

            cc.WorkingTime = Convert.ToInt32(txtTongTG.Text);
        }

        private void TinhTongThoiGian()
        {
            // Lấy giờ vào và giờ ra
            DateTime gioVao = dtpGioVao.Value;
            DateTime gioRa = dtpGioRa.Value;

            // Xử lý nếu giờ ra nhỏ hơn giờ vào (qua ngày)
            if (gioRa < gioVao)
            {
                gioRa = gioRa.AddDays(1);
            }

            // Tính tổng thời gian
            TimeSpan tongThoiGian = gioRa - gioVao;

            // Lấy tổng số giờ (chỉ phần nguyên)
            int TongTG = (int)tongThoiGian.TotalHours;

            // Hiển thị lên TextBox
            txtTongTG.Text = TongTG.ToString();
        }




        private bool XuLiViPhamCC()
        {
            if (ccBUS.ViPhamCC(cmbNVID.Text))
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

                if (XoaBoCC(cc))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDSCC();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
        private bool XoaBoCC(ChamCongDTO cc)
        {
            AdminBUS xoacc = new AdminBUS();
            int kq = xoacc.Xoacc(cc);
            return kq > 0;
        }

            
        private void LoadThongTin()
        {
            if (cc != null)
            {
                txtIDCC.Text = cc.ID.ToString();
                cmbNVID.Text = cc.UserID ?? "";

                if (cc.Ngay.HasValue)
                    dtpNgay.Value = cc.Ngay.Value;

                if (cc.GioVao.HasValue)
                    dtpGioVao.Value = DateTime.Today + cc.GioVao.Value;

                if (cc.GioRa.HasValue)
                    dtpGioRa.Value = DateTime.Today + cc.GioRa.Value;

                txtTongTG.Text = cc.WorkingTime.ToString();
                txtIDCC.ReadOnly = true;
            }
            else
            {
                cc = new ChamCongDTO(); // nên khởi tạo chứ không gán lại null
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XuLiViPhamCC())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTinCC();
                if (SuaDoiCC(cc))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDSCC();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    return;
                }
            }
        }
        private bool SuaDoiCC(ChamCongDTO cc)
        {
            AdminBUS suacc = new AdminBUS();
            int kq = suacc.Suacc(cc);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSCC.ClearSelection();
            LoadDSCC();
            txtTKCC.Clear();
        }

        private void dtpGioVao_ValueChanged(object sender, EventArgs e)
        {
            TinhTongThoiGian();
        }

        private void dtpGioRa_ValueChanged(object sender, EventArgs e)
        {
            TinhTongThoiGian();
        }

        private void dgvDSCC_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvDSCC.SelectedRows.Count > 0)
            {
                cc = dgvDSCC.SelectedRows[0].DataBoundItem as ChamCongDTO;
                LoadThongTin();

            }
            else
            {
                txtIDCC.Clear();
                cmbNVID.Clear();
                dtpNgay.Value = DateTime.Now;
                dtpGioVao.Value = DateTime.Now;
                dtpGioRa.Value = DateTime.Now;
                txtTongTG.Clear();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
