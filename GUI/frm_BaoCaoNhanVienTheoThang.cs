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
    public partial class frm_BaoCaoNhanVienTheoThang : Form
    {
        public frm_BaoCaoNhanVienTheoThang()
        {
            InitializeComponent();
        }

        public void LoadReportNhanVienTheoThang()
        {
            try
            {
                //Tạo instance của Crystal Report
                BaoCaoNhanVien rpt = new BaoCaoNhanVien();

                //Thiết lập tham số
                //rpt.SetParameterValue("@Thang", thang);
                //rpt.SetParameterValue("@Nam", nam);

                //Thiết lập thông tin đăng nhập cơ sở dữ liệu
                rpt.SetDatabaseLogon("sa", "123");

                //Gán report vào CrystalReportViewer
                crystalReportViewer1.ReportSource = rpt;

                //Làm mới báo cáo
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
