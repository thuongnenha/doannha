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
    public partial class QLDoanhThu : UserControl
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        public QLDoanhThu()
        {
            InitializeComponent();
        }

        private void btnSPUTN_Click(object sender, EventArgs e)
        {

            DataTable dt = thongKeBUS.showSPUTN();
            dgvShow.AutoGenerateColumns = true;
            dgvShow.DataSource = dt;
            foreach (DataGridViewColumn column in dgvShow.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnNVBNN_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBUS.showNVBNN();
            dgvShow.AutoGenerateColumns = true;
            dgvShow.DataSource = dt;
            foreach (DataGridViewColumn column in dgvShow.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBUS.showDT();
            dgvShow.AutoGenerateColumns = true;
            dgvShow.DataSource = dt;
            foreach (DataGridViewColumn column in dgvShow.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
