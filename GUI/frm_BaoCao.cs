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
    public partial class frm_BaoCao : Form
    {
        public frm_BaoCao()
        {
            InitializeComponent();
        }


        public void LoadReport(DateTime ngayBaoCao)
        {
            try
            {
                // Tạo instance của Crystal Report
                CrystalReport1 rpt = new CrystalReport1();

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
