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
        }

        private void btn_ThemLichTrinh_Click(object sender, EventArgs e)
        {

            DateTime ngaykh = DateTime.Parse(dtp_NgayKhoiHanh.Value.ToShortDateString() + " " + dtp_GioKhoiHanh.Value.ToShortTimeString());

            bool themThanhCong = ltBll.ThemLichTrinh(txt_MaLichTrinh.Text, int.Parse(cbo_TuyenDuong.SelectedValue.ToString()), ngaykh, float.Parse(txt_GiaVe.Text), int.Parse(cbo_Xe.SelectedValue.ToString()));

            if (themThanhCong)
            {
                MessageBox.Show("Thêm lịch trình thành công!");
                HienThiDanhSachLichTrinhTheoTuyenDuong(int.Parse(cbo_TuyenDuong.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Thêm lịch trình thất bại. Mã lịch trình đã tồn tại.");
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




    }
}
