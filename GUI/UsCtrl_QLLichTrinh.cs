using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class UsCtrl_QLLichTrinh : UserControl
    {
        XeBLL xeBll = new XeBLL();
        LichTrinhBLL ltBll = new LichTrinhBLL();
        TuyenDuongBLL tdBll = new TuyenDuongBLL();
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
            if (main != null)
            {
                main.MoUsCtrl(us);
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isLoading = true;
        private void Loadcbo_MaTuyenDuong()
        {
            isLoading = true;
            cbo_TuyenDuong.DataSource = tdBll.TuyenDuong();
            cbo_TuyenDuong.DisplayMember = "TEN_TUYEN";
            cbo_TuyenDuong.ValueMember = "ID_TUYEN";
            isLoading = false;
        }

        private void loadcbo_IDXe()
        {
            cbo_Xe.DataSource = xeBll.Xe();
            cbo_Xe.DisplayMember = "BIEN_SO_XE";
            cbo_Xe.ValueMember = "ID_XE";

        }

        private void UsCtrl_QLLichTrinh_Load(object sender, EventArgs e)
        {
            Loadcbo_MaTuyenDuong();
            loadcbo_IDXe();
            HienThiDanhSachLichTrinhTheoTuyenDuong(int.Parse(cbo_TuyenDuong.SelectedValue.ToString()));
            //databindding_DgvDsLichTrinh();
        }

        private void btn_ThemLichTrinh_Click(object sender, EventArgs e)
        {
            if (txt_MaLichTrinh.Text.Trim().Length != 0 && txt_GiaVe.Text.Trim().Length != 0)
            {
                int maTuyenDuong = int.Parse(cbo_TuyenDuong.SelectedValue.ToString());
                DateTime ngaykh = DateTime.Parse(dtp_NgayKhoiHanh.Value.ToShortDateString() + " " + dtp_GioKhoiHanh.Value.ToShortTimeString());

                bool themThanhCong = ltBll.ThemLichTrinh(txt_MaLichTrinh.Text, int.Parse(cbo_TuyenDuong.SelectedValue.ToString()), ngaykh, float.Parse(txt_GiaVe.Text), int.Parse(cbo_Xe.SelectedValue.ToString()));

                if (themThanhCong)
                {
                    MessageBox.Show("Thêm lịch trình thành công!");
                    HienThiDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);
                }
                else
                {
                    MessageBox.Show("Thêm lịch trình thất bại. Mã lịch trình đã tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
        }

        private void cbo_TuyenDuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            int maTuyenDuong = int.Parse(cbo_TuyenDuong.SelectedValue.ToString());

            HienThiDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);
        }


        //private void Load_DgvDanhSachLichTrinh()
        //{
        //    var danhSachLichTrinh = ltBll.LayDanhSachLichTrinh();

        //    dgv_DanhSachLichTrinh.DataSource = danhSachLichTrinh;

        //    dgv_DanhSachLichTrinh.Columns["MA_LICH_TRINH"].HeaderText = "Mã Lịch Trình";
        //    dgv_DanhSachLichTrinh.Columns["ID_TUYEN_DUONG"].HeaderText = "Mã Tuyến Đường";
        //    dgv_DanhSachLichTrinh.Columns["KHOI_HANH"].HeaderText = "Khởi Hành";
        //    dgv_DanhSachLichTrinh.Columns["KET_THUC"].HeaderText = "Kết Thúc";
        //    dgv_DanhSachLichTrinh.Columns["GIA_VE"].HeaderText = "Giá Vé";
        //    dgv_DanhSachLichTrinh.Columns["ID_XE"].HeaderText = "Xe";
        //    dgv_DanhSachLichTrinh.Columns["SOGHETRONG"].HeaderText = "Số Ghế Trống";
        //    dgv_DanhSachLichTrinh.Columns["NGAY_TAO_LICH_TRINH"].HeaderText = "Ngày Tạo Lịch Trình";

        //    dgv_DanhSachLichTrinh.Columns["XE"].Visible = false;
        //    dgv_DanhSachLichTrinh.Columns["TuyenDuong"].Visible = false;
        //}

        private void HienThiDanhSachLichTrinhTheoTuyenDuong(int maTuyenDuong)
        {
            var danhSachLichTrinh = ltBll.LayDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);

            dgv_DanhSachLichTrinh.DataSource = danhSachLichTrinh;


            dgv_DanhSachLichTrinh.Columns["MA_LICH_TRINH"].HeaderText = "Mã Lịch Trình";
            dgv_DanhSachLichTrinh.Columns["ID_TUYEN_DUONG"].HeaderText = "Mã Tuyến Đường";
            dgv_DanhSachLichTrinh.Columns["KHOI_HANH"].HeaderText = "Khởi Hành";
            dgv_DanhSachLichTrinh.Columns["KET_THUC"].HeaderText = "Kết Thúc";
            dgv_DanhSachLichTrinh.Columns["GIA_VE"].HeaderText = "Giá Vé";
            dgv_DanhSachLichTrinh.Columns["ID_XE"].HeaderText = "Xe";
            dgv_DanhSachLichTrinh.Columns["SOGHETRONG"].HeaderText = "Số Ghế Trống";
            dgv_DanhSachLichTrinh.Columns["NGAY_TAO_LICH_TRINH"].HeaderText = "Ngày Tạo Lịch Trình";

            dgv_DanhSachLichTrinh.Columns["XE"].Visible = false;
            dgv_DanhSachLichTrinh.Columns["TuyenDuong"].Visible = false;
        }

        private void btn_XoaLichTrinh_Click(object sender, EventArgs e)
        {
            if (txt_MaLichTrinh.Text.Trim().Length != 0)
            {
                string maLichTrinh = txt_MaLichTrinh.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch trình này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool xoaThanhCong = ltBll.XoaLichTrinh(maLichTrinh);

                    if (xoaThanhCong)
                    {
                        MessageBox.Show("Xóa lịch trình thành công!");

                        HienThiDanhSachLichTrinhTheoTuyenDuong(int.Parse(cbo_TuyenDuong.SelectedValue.ToString()));

                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch trình thất bại. Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch trình để xóa.");
            }
        }

        private void databindding_DgvDsLichTrinh()
        {
            txt_MaLichTrinh.Text = dgv_DanhSachLichTrinh.CurrentRow.Cells["MA_LICH_TRINH"].Value.ToString();

            cbo_TuyenDuong.DataBindings.Clear();
            cbo_TuyenDuong.DataBindings.Add("SelectedValue", dgv_DanhSachLichTrinh.DataSource, "ID_TUYEN_DUONG");

            dtp_NgayKhoiHanh.DataBindings.Clear();
            dtp_NgayKhoiHanh.DataBindings.Add("Value", dgv_DanhSachLichTrinh.DataSource, "KHOI_HANH");

            dtp_GioKhoiHanh.DataBindings.Clear();
            dtp_GioKhoiHanh.DataBindings.Add("Value", dgv_DanhSachLichTrinh.DataSource, "KHOI_HANH");

            txt_GiaVe.DataBindings.Clear();
            txt_GiaVe.DataBindings.Add("Text", dgv_DanhSachLichTrinh.DataSource, "GIA_VE");

            cbo_Xe.DataBindings.Clear();
            cbo_Xe.DataBindings.Add("SelectedValue", dgv_DanhSachLichTrinh.DataSource, "ID_XE");

        }

        private void btn_CapNhatLichTrinh_Click(object sender, EventArgs e)
        {
            if (txt_MaLichTrinh.Text.Trim().Length != 0 && txt_GiaVe.Text.Trim().Length != 0)
            {
                int maTuyenDuong = int.Parse(cbo_TuyenDuong.SelectedValue.ToString());
                DateTime ngaykh = DateTime.Parse(dtp_NgayKhoiHanh.Value.ToShortDateString() + " " + dtp_GioKhoiHanh.Value.ToShortTimeString());
                float giaVe = float.Parse(txt_GiaVe.Text);
                int maXe = int.Parse(cbo_Xe.SelectedValue.ToString());

                bool capNhatThanhCong = ltBll.CapNhatLichTrinh(txt_MaLichTrinh.Text, maTuyenDuong, ngaykh, giaVe, maXe);

                if (capNhatThanhCong)
                {
                    MessageBox.Show("Cập nhật lịch trình thành công!");
                    HienThiDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);
                }
                else
                {
                    MessageBox.Show("Cập nhật lịch trình thất bại. Không tìm thấy mã lịch trình.");
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
        }
    }
}
