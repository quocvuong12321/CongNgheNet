using BLL;
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
    public partial class frm_BaoCaoNgay : Form
    {
        ThongKeBLL tkBll = new ThongKeBLL();
        public frm_BaoCaoNgay()
        {
            InitializeComponent();
        }

        public void LoadReportNgay(DateTime ngayBaoCao)
        {
            try
            {
                // Tạo instance của Crystal Report
                BaoCaoNgay rpt = new BaoCaoNgay();

                rpt.SetParameterValue("ngayBaoCao", ngayBaoCao);
                rpt.SetDatabaseLogon("sa", "123");

                // Gán report vào CrystalReportViewer
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
