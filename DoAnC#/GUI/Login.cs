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
    public partial class Login : Form
    {
        private LoginBUS loginBUS = new LoginBUS();
        private ChamCongBUS chamCongBUS = new ChamCongBUS();
        
        public Login()
        {
            InitializeComponent();
            lblLogin_tbTK.Visible = false;
            lblLogin_tbMK.Visible = false;

        }

        private void txtLogin_TK_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLogin_TK.Text))
            {
                lblLogin_tbTK.Visible = false;
            }
        }

        private void txtLogin_MK_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLogin_MK.Text))
            {
                lblLogin_tbMK.Visible = false;
            }
        }

        private void btnLogin_DN_Click(object sender, EventArgs e)
        {
            if (loginBUS.checkInputTk(txtLogin_TK.Text) == null && loginBUS.checkInputMK(txtLogin_MK.Text) == null)
            {
                if (loginBUS.CheckLogin(txtLogin_TK.Text.ToString(), txtLogin_MK.Text.ToString()))
                {
                    MessageBox.Show(txtLogin_TK.Text.ToString() + " đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK);
                    Session.time = chamCongBUS.gioVao();
                    this.Hide();
                    Controler controler = new Controler();
                    controler.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công , tài khoản hoặc mật khẩu không đúng .", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else
            {
                lblLogin_tbTK.Visible = true;
                lblLogin_tbMK.Visible = true;
                lblLogin_tbTK.Text = loginBUS.checkInputTk(txtLogin_TK.Text);
                lblLogin_tbMK.Text = loginBUS.checkInputMK(txtLogin_MK.Text);
            }
        }


    }
}
