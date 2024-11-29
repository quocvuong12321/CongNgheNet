using BLL;
using DTO;
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
    public partial class UsCtrl_ThongKeDoanhThu : UserControl
    {
        ThongKeBLL tkBll = new ThongKeBLL();
        public UsCtrl_ThongKeDoanhThu()
        {
            InitializeComponent();
        }



        private void UsCtrl_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            //// Đặt DateTimePicker ban đầu không hiển thị giá trị
            //dtp_Ngay.Format = DateTimePickerFormat.Custom;
            //dtp_Ngay.CustomFormat = " "; // Hiển thị trống
        }

        private void btn_timTheoNgay_Click(object sender, EventArgs e)
        {
            // Khi chọn ngày, đặt lại định dạng bình thường
            dtp_Ngay.Format = DateTimePickerFormat.Short;
            try
            {
                // Lấy ngày từ DateTimePicker
                DateTime selectedDate = dtp_Ngay.Value;

                // Lấy danh sách vé theo ngày
                List<Ve> danhSachve = tkBll.LayDanhSachVeTheoNgay(selectedDate);

                // Tạm thời hủy sự kiện SelectedIndexChanged
                //cbo_LichTrinh.SelectedIndexChanged -= cbo_LichTrinh_SelectedIndexChanged;

                if (danhSachve.Any())
                {
                    // Bind danh sách lịch trình vào ComboBox
                    dgv_Ve.DataSource = danhSachve;
                    //cbo_LichTrinh.DisplayMember = "MA_LICH_TRINH"; // Hiển thị mã lịch trình
                    //cbo_LichTrinh.ValueMember = "MA_LICH_TRINH";  // Giá trị là mã lịch trình

                    // Đặt SelectedIndex = -1 để không chọn phần tử đầu tiên
                    //cbo_LichTrinh.SelectedIndex = -1;
                }
                else
                {
                    // Nếu không có lịch trình, hiển thị thông báo và xóa dữ liệu ComboBox
                    //cbo_LichTrinh.DataSource = null;
                    dgv_Ve.DataSource = null; // Xóa dữ liệu DataGridView
                    MessageBox.Show("Không có lịch trình nào trong ngày đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Gắn lại sự kiện SelectedIndexChanged
                //cbo_LichTrinh.SelectedIndexChanged += cbo_LichTrinh_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XuatBaoCaoTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra nếu người dùng chưa chọn ngày
                if (dtp_Ngay.CustomFormat == " ")
                {
                    MessageBox.Show("Vui lòng chọn ngày để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayBaoCao = dtp_Ngay.Value; // Lấy ngày báo cáo từ DateTimePicker

                //Kiểm tra xem có dữ liệu vé hay không
                var danhSachVe = tkBll.LayDanhSachVeTheoNgay(ngayBaoCao);
                if (danhSachVe == null || !danhSachVe.Any())
                {
                    MessageBox.Show("Không có dữ liệu vé để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Mở form báo cáo và truyền tham số
                frm_BaoCao frmBaoCao = new frm_BaoCao();
                frmBaoCao.LoadReport(ngayBaoCao); // Truyền tham số vào form báo cáo
                frmBaoCao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_XuatBaoCaoTheoThang_Click(object sender, EventArgs e)
        {

        }

        private void btn_timTheoThang_Click(object sender, EventArgs e)
        {
            // Khi chọn ngày, đặt lại định dạng bình thường
            dtp_Ngay.Format = DateTimePickerFormat.Short;
            try
            {
                int thang = dtp_Ngay.Value.Month;
                int nam = dtp_Ngay.Value.Year;

                List<Ve> danhSachve = tkBll.LayDanhSachVeTheoThang(thang,nam);


                if (danhSachve.Any())
                {
                    // Bind danh sách lịch trình vào ComboBox
                    dgv_Ve.DataSource = danhSachve;
                }
                else
                {
                    dgv_Ve.DataSource = null; // Xóa dữ liệu DataGridView
                    MessageBox.Show("Không có lịch trình nào trong tháng đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
