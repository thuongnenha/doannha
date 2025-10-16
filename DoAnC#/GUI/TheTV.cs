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

namespace GUI
{
    public partial class TheTV : Form
    {
        private TheTVBUS theTVBUS = new TheTVBUS();

        public TheTV()
        {
            InitializeComponent();
            lblFN_TheTV.Visible = false;
            lblDiaChi_TheTV.Visible = false;
            lblSDT_TheTV.Visible = false;
        }


        private void txtFullname_TTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ cái, số, khoảng trắng và các phím điều khiển
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiaChi_TTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ cái, số, khoảng trắng và các phím điều khiển
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSdt_TTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số và phím điều khiển (Backspace, Delete,...)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void btnQuayLai_TTV_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Controler controler = new Controler();
            controler.ShowDialog();
            this.Close();
        }

        private void btnTao_TTV_Click_1(object sender, EventArgs e)
        {

            if (theTVBUS.checkInput(txtFullname_TTV.Text) == null &&
                theTVBUS.checkInput(txtSdt_TTV.Text) == null &&
                theTVBUS.checkInput(txtDiaChi_TTV.Text) == null &&
                theTVBUS.checkPhonNumber(txtSdt_TTV.Text) == null)
            {
                if (theTVBUS.taoTheTV(txtFullname_TTV.Text, txtSdt_TTV.Text, txtDiaChi_TTV.Text))
                {
                    DialogResult rs = MessageBox.Show("Tạo thành công .", "Thông Báo", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        txtFullname_TTV.Text = null;
                        txtSdt_TTV.Text = null;
                        txtDiaChi_TTV.Text = null;
                    }
                }

            }
            else
            {
                lblFN_TheTV.Visible = true;
                lblDiaChi_TheTV.Visible = true;
                lblSDT_TheTV.Visible = true;
                lblFN_TheTV.Text = theTVBUS.checkInput(txtFullname_TTV.Text);
                lblDiaChi_TheTV.Text = theTVBUS.checkInput(txtDiaChi_TTV.Text);
                if (string.IsNullOrEmpty(txtSdt_TTV.Text))
                {
                    lblSDT_TheTV.Text = theTVBUS.checkInput(txtSdt_TTV.Text);
                }
                else
                {
                    lblSDT_TheTV.Text = theTVBUS.checkPhonNumber(txtSdt_TTV.Text);
                }
            }
        }
    }
}
