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
    public partial class frm_InVe : Form
    {
        public frm_InVe()
        {
            InitializeComponent();
        }
        public void LoadReportInVe(string maVe)
        {
            try
            {
                // Tạo instance của Crystal Report
                InVeReport rpt = new InVeReport();

                // Thiết lập tham số cho Crystal Report
                rpt.SetParameterValue("@MaVe", maVe);

                // Thiết lập thông tin đăng nhập cơ sở dữ liệu
                rpt.SetDatabaseLogon("sa", "123");

                // Gán báo cáo vào CrystalReportViewer
                crystalReportViewer1.ReportSource = rpt;

                // Làm mới báo cáo
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải vé: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
