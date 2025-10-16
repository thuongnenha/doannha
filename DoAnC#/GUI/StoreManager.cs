using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class StoreManager : Form
    {
        private StoreManegerBUS storeManegerBUS = new StoreManegerBUS();
        private ChamCongBUS chamCongBUS = new ChamCongBUS();
        private Panel selectedPanel = null;
        private readonly string path = @"E:\DoAn\ImageFood\";
        private Image tableImage;

        public StoreManager()
        {
            InitializeComponent();
            LoadMonAn();
        }
        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thongtin thongtin = new Thongtin();
            thongtin.ShowDialog();
            this.Close();
        }


        private void StoreManager_Load(object sender, EventArgs e)
        {
            loadTables();
        }
        private void loadTables()
        {
            flowLayoutPanel1.Controls.Clear();
            List<TablesDTO> Tables = storeManegerBUS.taoTables();
            int dem = storeManegerBUS.soLuongTables();
            int tmp = 0;
            if (tableImage == null)
            {
                tableImage = GUI.Properties.Resources.caiban;
            }
            while (dem != tmp)
            {


                Panel panel = new Panel();
                panel.Size = new Size(125, 89);
                if (Tables[tmp].Status == true)
                {
                    panel.BackColor = Color.Red;
                }
                else
                {
                    panel.BackColor = Color.Green;
                }

                panel.Tag = panel.BackColor;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(119, 59);
                pictureBox.Location = new Point(3, 3);
                pictureBox.BackgroundImage = tableImage;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.Tag = tmp;
                    
                Label label = new Label();
                label.Location = new Point(3, 65);
                label.TextAlign = ContentAlignment.BottomCenter;
                label.Text = Tables[tmp].Name;
                label.Tag = Tables[tmp].ID;

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                flowLayoutPanel1.Controls.Add(panel);

                panel.Click += Panel_Click;
                pictureBox.Click += Panel_Click;
                label.Click += Panel_Click;
                tmp++;
            }
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel ?? ((Control)sender).Parent as Panel;

            if (selectedPanel == clickedPanel)
            {
                // Nếu click vào chính panel đang được chọn => bỏ chọn
                selectedPanel.BackColor = (Color)selectedPanel.Tag;
                selectedPanel = null;
                Session.tablesID = 0;
                txt_SDT_SM.Text = "";
                return;
            }

            if (selectedPanel != null)
            {
                // Trả lại màu gốc cho panel cũ
                selectedPanel.BackColor = (Color)selectedPanel.Tag;
            }

            // Đổi màu cho panel được chọn
            clickedPanel.BackColor = Color.Gray;
            selectedPanel = clickedPanel;

            Label label = clickedPanel.Controls.OfType<Label>().FirstOrDefault();
            Session.tablesID = Convert.ToInt32(label.Tag);
            txt_SDT_SM.Text = storeManegerBUS.showSDT((int)Session.tablesID);
            DataTable dt = storeManegerBUS.showData();
            
            dgvFood_SM.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Image img = TimHinhAnhTheoTenMon(path, row["ImageFood"].ToString());
                dgvFood_SM.Rows.Add(img, row["Name"], row["SoLuong"], row["ThanhTien"] + " VNĐ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbxThemMon_SM.SelectedItem is ProductsDTO mon)
            {
                txtThemMon_SM.Text = mon.Gia.ToString("N0") + " VNĐ";
                
                Image img = TimHinhAnhTheoTenMon(path, mon.Name);
                ptb_Food_SM.BackgroundImage = img;
                // hiển thị giá tiền có định dạng
            }
        }
        private void LoadMonAn()
        {
            List<ProductsDTO> danhSachMon = storeManegerBUS.LayDanhSachMon();
            // Thêm một mục trống hoặc gợi ý vào đầu danh sách
            danhSachMon.Insert(0, new ProductsDTO { Name = null, Gia = 0 });
            cbxThemMon_SM.DataSource = danhSachMon;
            cbxThemMon_SM.DisplayMember = "Name";
            cbxThemMon_SM.ValueMember = "Gia";

            cbxThemMon_SM.SelectedIndex = 0;  // chọn dòng đầu tiên (mặc định là "-- Chọn món ăn --")
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

        private List<BillInfoDTO> LayDanhSachMonTuDataGridView()
        {
            List<BillInfoDTO> danhSachMon = new List<BillInfoDTO>();

            foreach (DataGridViewRow row in dgvFood_SM.Rows)
            {
                if (row.IsNewRow) continue; // bỏ qua dòng trống cuối
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value.ToString().Replace(" VNĐ", "").Replace(",", ""));
                decimal thanhTien = gia * soLuong;
                int khuyenMai = 0;

                if(storeManegerBUS.checkSdt(txt_SDT_SM.Text) != 0)
                {
                    khuyenMai = 10;

                }
                BillInfoDTO mon = new BillInfoDTO
                {
                    ProductsID = storeManegerBUS.LayIDMonTheoTen(row.Cells["TenMon"].Value.ToString()),
                    SoLuong = soLuong,
                    Gia = gia / soLuong,
                    ThanhTien = Convert.ToDecimal(gia),
                    KhuyenMai = khuyenMai
                };

                danhSachMon.Add(mon);
            }

            return danhSachMon;
        }

        private void btnXacNhan_SM_Click(object sender, EventArgs e)
        {
            
            if (selectedPanel == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Đồng ý xác nhận ", "Thông báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                List<BillInfoDTO> danhSachMon = LayDanhSachMonTuDataGridView();
                int theTVID = storeManegerBUS.checkSdt(txt_SDT_SM.Text);
                bool thanhCong = storeManegerBUS.LuuBillVaChiTiet(theTVID, danhSachMon, tinhSumBill());
                if (thanhCong)
                {
                    resetControl();
                    loadTables();

                    MessageBox.Show("Lưu hóa đơn thành công!");
                } 
                else
                {
                    MessageBox.Show("Lưu hóa đơn thất bại.");
                }
            }
        }

        private decimal tinhSumBill()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvFood_SM.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Gia"].Value.ToString().Replace(" VNĐ", "").Replace(",", ""));
            }
            return sum;
        }
        private void btnGiamMon_SM_Click(object sender, EventArgs e)
        {
            if (dgvFood_SM.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvFood_SM.SelectedRows[0];

                // Lấy giá trị số lượng hiện tại
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                int giamSL = (int)nmudGiamMon_SM.Value;

                if (soLuong > giamSL)
                {
                    // Lấy giá hiện tại và tính đơn giá
                    string giaText = row.Cells["Gia"].Value.ToString().Replace(" VNĐ", "").Replace(",", "");
                    decimal tongGiaHienTai = Convert.ToDecimal(giaText);
                    decimal donGia = tongGiaHienTai / soLuong;

                    // Cập nhật số lượng và tổng giá mới
                    soLuong -= giamSL;
                    decimal tongGiaMoi = donGia * soLuong;

                    row.Cells["SoLuong"].Value = soLuong;
                    row.Cells["Gia"].Value = tongGiaMoi.ToString("N0") + " VNĐ";
                    nmudGiamMon_SM.Value = 1;
                }
                else if (soLuong == giamSL)
                {
                    // Xóa dòng nếu số lượng giảm bằng 0
                    dgvFood_SM.Rows.Remove(row);
                    nmudGiamMon_SM.Value = 1;
                }
                else
                {
                    MessageBox.Show("Không thể giảm nhiều hơn số lượng hiện có!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để giảm số lượng!");
            }
        }

        private void btnThemMon_SM_Click_1(object sender, EventArgs e)
        {
            ProductsDTO mon = cbxThemMon_SM.SelectedItem as ProductsDTO;
            if (mon == null || string.IsNullOrEmpty(mon.Name))
            {
                MessageBox.Show("Chưa có món nào được chọn !!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string tenMon = mon.Name;
                int soLuong = (int)nmudThemMon_SM.Value;
                Image img = TimHinhAnhTheoTenMon(path, mon.Name); // Tên resource là tên file (không đuôi)

                bool daCoMon = false;//kiểm tra đã có món trong dataGridView chưa

                foreach (DataGridViewRow row in dgvFood_SM.Rows)
                {
                    if (row.Cells["TenMon"].Value != null && row.Cells["TenMon"].Value.ToString() == tenMon)
                    {
                        // Món đã có → cộng dồn số lượng
                        int soLuongCu = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        int soLuongMoiTong = soLuongCu + soLuong;

                        // Tính lại tổng tiền
                        
                        decimal donGia = Convert.ToDecimal(mon.Gia);

                        // Cập nhật lại dòng
                        row.Cells["SoLuong"].Value = soLuongMoiTong;
                        row.Cells["Gia"].Value = storeManegerBUS.giaTienFood(donGia.ToString(), soLuongMoiTong).ToString("N0") + " VNĐ";

                        daCoMon = true;
                        break;
                    }
                }

                // Nếu chưa có món này → thêm mới
                if (!daCoMon)
                {
                    decimal tongTien = storeManegerBUS.giaTienFood(mon.Gia.ToString(), soLuong);

                    dgvFood_SM.Rows.Add(img, mon.Name, soLuong, tongTien.ToString("N0") + " VNĐ");
                }
                cbxThemMon_SM.SelectedIndex = 0;
                nmudThemMon_SM.Value = 1;
                
            }
        }
        private void nmudThemMon_SM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void nmudGiamMon_SM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void btnChuyenBan_SM_Click(object sender, EventArgs e)
        {
            storeManegerBUS.chuyenTable(Convert.ToInt32(cbxChuyenBan_SN.SelectedValue));
            resetControl();
            loadTables();
        }

        private void btnGhepBan_SM_Click(object sender, EventArgs e)
        {
            storeManegerBUS.ghepTable(Convert.ToInt32(cbxGhepBan_SM.SelectedValue));
            resetControl();
            loadTables();

        }

        private void resetControl()
        {
            cbxChuyenBan_SN.SelectedIndex = -1;
            cbxGhepBan_SM.SelectedIndex = -1;
            cbxThemMon_SM.Text = "";
            txtThemMon_SM.Text = "";
            txt_SDT_SM.Text = "";
            dgvFood_SM.DataSource = null;
            dgvFood_SM.Rows.Clear();
            flowLayoutPanel1.Controls.Clear();
            

        }
        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControl();
            loadTables();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill bill = new Bill(); 
            bill.ShowDialog();
            this.Close();
        }

        
        private void cbxChuyenBan_SN_DropDown(object sender, EventArgs e)
        {
            List<TablesDTO> Tables = storeManegerBUS.taoTables();

            var danhSachChuyenBan = Tables
                .Where(t => t.Status == false)
                .Select(t => new TablesDTO
                {
                    ID = t.ID,
                    Name = t.Name,
                    Status = t.Status
                }).ToList();
            cbxGhepBan_SM.DataSource = null;
            danhSachChuyenBan.Insert(0, new TablesDTO { ID = 0, Name = "--- Chọn bàn ---" });
            cbxChuyenBan_SN.DataSource = danhSachChuyenBan;
            cbxChuyenBan_SN.DisplayMember = "Name";
            cbxChuyenBan_SN.ValueMember = "ID";
        }

        private void cbxGhepBan_SM_DropDown(object sender, EventArgs e)
        {
            List<TablesDTO> Tables = storeManegerBUS.taoTables();

            var danhSachGhepBan = Tables
                .Where(t => t.Status == false)
                .Select(t => new TablesDTO
                {
                    ID = t.ID,
                    Name = t.Name,
                    Status = t.Status
                }).ToList();
            cbxGhepBan_SM.DataSource = null;
            danhSachGhepBan.Insert(0, new TablesDTO { ID = 0, Name = "--- Chọn bàn ---" });
            cbxGhepBan_SM.DataSource = danhSachGhepBan;
            cbxGhepBan_SM.DisplayMember = "Name";
            cbxGhepBan_SM.ValueMember = "ID";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
            flowLayoutPanel1.Controls.Clear();
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }


    }
}
