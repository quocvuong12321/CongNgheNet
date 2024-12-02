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
    public partial class frm_BaoCaoThang : Form
    {
        public frm_BaoCaoThang()
        {
            InitializeComponent();
        }

        public void LoadReportThang(int thang, int nam)
        {
            try
            {
                // Tạo instance của Crystal Report
                BaoCaoThang rpt = new BaoCaoThang();

                rpt.SetParameterValue("@Thang", thang);
                rpt.SetParameterValue("@Nam", nam);
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
