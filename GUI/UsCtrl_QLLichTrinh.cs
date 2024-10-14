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
        public UsCtrl_QLLichTrinh()
        {
            InitializeComponent();
        }



        private void btn_QLTramDungChan_Click(object sender, EventArgs e)
        {
            frm_QLTramDungChan frmTDC = new frm_QLTramDungChan();
            frmTDC.ShowDialog();
        }
    }
}
