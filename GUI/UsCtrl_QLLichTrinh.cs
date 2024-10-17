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
    public partial class UsCtrl_QLLichTrinh : UserControl
    {
        frm_Main main;
        public UsCtrl_QLLichTrinh()
        {
            InitializeComponent();
        }

        public UsCtrl_QLLichTrinh(frm_Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btn_QLTramDungChan_Click(object sender, EventArgs e)
        {

            UsCtrl_QLTramDungChan us = new UsCtrl_QLTramDungChan();
            if (main != null) // Đảm bảo main không null
            {
                main.MoUsCtrl(us);
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
