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

        public void loadCbo_Thang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbo_Thang.Items.Add(i.ToString());
            }
        }

        public void loadCbo_Nam()
        {
            for (int i = 2000; i <= 2025; i++)
            {
                cbo_Nam.Items.Add(i.ToString());
            }
        }



        private void UsCtrl_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            loadCbo_Thang();
            loadCbo_Nam();

            cbo_Thang.SelectedIndex = 0;
            cbo_Nam.SelectedIndex = cbo_Nam.Items.Count - 1;
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


                if (danhSachve.Any())
                {
                    // Bind danh sách lịch trình vào ComboBox
                    dgv_Ve.DataSource = danhSachve;

                    dgv_Ve.Columns["SDT"].Visible = false;
                    dgv_Ve.Columns["DIEMDON"].Visible = false;
                    dgv_Ve.Columns["DIEMTRA"].Visible = false;
                    dgv_Ve.Columns["HINHTHUCTHANHTOAN"].Visible = false;
                    dgv_Ve.Columns["TRAMDUNGCHAN"].Visible = false;
                    dgv_Ve.Columns["TRAMDUNGCHAN1"].Visible = false;
                    dgv_Ve.Columns["LICHTRINH"].Visible = false;
                    dgv_Ve.Columns["NHANVIEN"].Visible = false;
                }
                else
                {
                    dgv_Ve.DataSource = null; // Xóa dữ liệu DataGridView
                    MessageBox.Show("Không có lịch trình nào trong ngày đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                frm_BaoCaoNgay frmBaoCao = new frm_BaoCaoNgay();
                frmBaoCao.LoadReportNgay(ngayBaoCao); // Truyền tham số vào form báo cáo
                frmBaoCao.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_XuatBaoCaoTheoThang_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Kiểm tra nếu người dùng chưa chọn ngày
            //    if (dtp_Ngay.CustomFormat == " ")
            //    {
            //        MessageBox.Show("Vui lòng chọn ngày để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    int thang = int.Parse(cbo_Thang.SelectedItem.ToString()); // Lấy tháng báo cáo từ DateTimePicker
            //    int nam = int.Parse(cbo_Nam.SelectedItem.ToString()); // Lấy tháng báo cáo từ DateTimePicker

            //    //Kiểm tra xem có dữ liệu vé hay không
            //    var danhSachVe = tkBll.LayDanhSachVeTheoThang(thang, nam);
            //    if (danhSachVe == null || !danhSachVe.Any())
            //    {
            //        MessageBox.Show("Không có dữ liệu vé để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //    //Mở form báo cáo và truyền tham số
            //    frm_BaoCaoThang frmBaoCao = new frm_BaoCaoThang();
            //    frmBaoCao.LoadReportThang(thang, nam); // Truyền tham số vào form báo cáo
            //    frmBaoCao.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}





        }

        private void btn_timTheoThang_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cbo_Thang.SelectedItem.ToString());
                int nam = int.Parse(cbo_Nam.SelectedItem.ToString());

                if(cbo_Nam.SelectedItem == null || cbo_Thang.SelectedItem == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!");
                    return;
                }

                List<Ve> danhSachve = tkBll.LayDanhSachVeTheoThang(thang,nam);


                if (danhSachve.Any())
                {
                    // Bind danh sách lịch trình vào ComboBox
                    dgv_Ve.DataSource = danhSachve;

                    dgv_Ve.Columns["SDT"].Visible = false; 
                    dgv_Ve.Columns["DIEMDON"].Visible = false;
                    dgv_Ve.Columns["DIEMTRA"].Visible = false;
                    dgv_Ve.Columns["HINHTHUCTHANHTOAN"].Visible = false;
                    dgv_Ve.Columns["TRAMDUNGCHAN"].Visible = false;
                    dgv_Ve.Columns["TRAMDUNGCHAN1"].Visible = false;
                    dgv_Ve.Columns["LICHTRINH"].Visible = false;
                    dgv_Ve.Columns["NHANVIEN"].Visible = false;
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
