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
    public partial class Bill : Form
    {
        private BillBUS billBUS = new BillBUS();
        private StoreManegerBUS store = new StoreManegerBUS();
        public Bill()
        {
            InitializeComponent();
            showData();
            lblTienKhachDua_B.Visible = false;
        }
        private void showData()
        {
            DataTable dt = billBUS.showData();
            dgvBill_B.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvBill_B.Rows.Add(row["Name"], row["SoLuong"], row["Gia"] + " VNĐ", row["ThanhTien"] + " VNĐ");
            }
            decimal sum = tinhSumBill();
            int? checkKM = store.checkKM(Session.tablesID);
            Console.WriteLine(checkKM.ToString());
            if(checkKM != null)
            {
                txtKM_bill.Text = (sum * ((decimal)checkKM / (decimal)100)).ToString("N0") + " VNĐ";
                Session.bill = sum - (sum * ((decimal)checkKM / 100));
            }
            else
            {
                txtKM_bill.Text = "0";
                Session.bill = sum;
            }
            txtSum_B.Text = Session.bill.ToString("N0") + " VNĐ";
        }
        private void txtTienKhachDua_B_Leave(object sender, EventArgs e)
        {
            decimal value = ParseCurrency(txtTienKhachDua_B.Text);
            txtTienKhachDua_B.Text = value.ToString("N0") + " VNĐ";
        }

        private void btnQuayLai_B_Click(object sender, EventArgs e)
        {
            Session.bill = 0;
            this.Hide();
            StoreManager storeManager = new StoreManager();
            storeManager.ShowDialog();
            this.Close();
        }
        
        private decimal tinhSumBill()
        {
            decimal sum = 0;
            decimal cellValue = 0;
            foreach (DataGridViewRow row in dgvBill_B.Rows)
            {
                if (row.IsNewRow) continue;
                cellValue = Convert.ToDecimal(row.Cells["ThanhTien"].Value.ToString().Replace(" VNĐ", "").Replace(",", "").Trim());           
                sum += cellValue;
            }
                return sum;
        }
        private void txtTienKhachDua_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Nhập số !!!", "Thông Báo");
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
        private decimal ParseCurrency(string text)
        {
            string cleaned = text.Replace(" VNĐ", "").Replace(",", "").Replace(".", "").Trim();
            return decimal.TryParse(cleaned, out decimal result) ? result : 0;
        }
        private string showBill(decimal khachDua)
        {
            int width = 64;
            string title = "HÓA ĐƠN";
            string data = title.PadLeft((width + title.Length) / 2).PadRight(width) + "\n\n";
            data += string.Format("{0,-20}{1,8}{2,15}{3,15}\n", "Tên món", "SL", "Giá", "Thành tiền");
            foreach (DataGridViewRow row in dgvBill_B.Rows)
            {
                if (row.IsNewRow) continue;

                data += string.Format("{0,-20}{1,8}{2,15:N0}{3,15:N0}\n",
                    row.Cells["TenMon"].Value.ToString(),
                    row.Cells["SoLuong"].Value.ToString(),
                    Convert.ToDecimal(row.Cells["Gia"].Value.ToString().Replace(" VNĐ", "").Replace(",", "")),
                    Convert.ToDecimal(row.Cells["ThanhTien"].Value.ToString().Replace(" VNĐ", "").Replace(",", ""))
                );
            }

            data += new string('-', width) + "\n";
            data += string.Format("{0,-30}{1,25:N0}\n", "Phải thanh toán:", Session.bill);
            data += string.Format("{0,-30}{1,25:N0}\n", "Tiền khách đưa:", khachDua);
            data += string.Format("{0,-30}{1,25:N0}\n", "Khuyến mãi:", txtKM_bill.Text.ToString().Replace(" VNĐ", "").Replace(",", "").Trim());
            data += string.Format("{0,-30}{1,25:N0}\n", "Tiền thối lại:", khachDua - Session.bill);
            data += new string('-', width) + "\n";
            return data;
        }
        private void btnXacNhan_B_Click(object sender, EventArgs e)
        {
            if (billBUS.checkNull(txtTienKhachDua_B.Text))
            {
                lblTienKhachDua_B.Visible = true;
                lblTienKhachDua_B.Text = "Không được để trống !!!";
                return;
            }
            decimal khachDua = Convert.ToDecimal(txtTienKhachDua_B.Text.Replace(" VNĐ", "").Replace(",", "").Trim());
            if (billBUS.checkTien(khachDua, Session.bill))
            {
                lblTienKhachDua_B.Visible = true;
                lblTienKhachDua_B.Text = "Số tiền không đủ !";
                MessageBox.Show(Session.bill.ToString(), "thong báo");
                return;
            }
            else
            {
                lblTienKhachDua_B.Visible = false; // Ẩn label khi tiền đủ
                lblTienKhachDua_B.Text = "";
               
            }
            if (billBUS.xacNhanThanhToan(khachDua, (khachDua - Session.bill), Session.bill))
            {
                store.updateTable(Session.tablesID);
                MessageBox.Show(showBill(khachDua), "Thông báo");
                MessageBox.Show("Thành công .", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không thành công .", "Thông báo");
            }

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }


    }
}
