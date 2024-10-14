using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }


        //private void toolStripButton1_Click_1(object sender, EventArgs e)
        //{
        //    UsCtrl_QLTaiKhoan us = new UsCtrl_QLTaiKhoan();
        //    panel.Controls.Clear();
        //    panel.Controls.Add(us);
        //}

        private void tsb_QLXe_Click(object sender, EventArgs e)
        {
            UsCtrl_QLXe us = new UsCtrl_QLXe();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;//fill cho vừa với panel
            panel.Controls.Add(us);
        }

        private void tsb_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            UsCtrl_QLTaiKhoan us = new UsCtrl_QLTaiKhoan();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }

        private void tsb_QLTuyenDuong_Click(object sender, EventArgs e)
        {
            UsCtrl_QLTuyenDuong us = new UsCtrl_QLTuyenDuong();
            panel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panel.Controls.Add(us);
        }
    }
}
