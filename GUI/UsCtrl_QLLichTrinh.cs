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

        private void Loadcbo_MaTuyenDuong()
        {
            cbo_TuyenDuong.DataSource = tdBll.TuyenDuong();
            cbo_TuyenDuong.DisplayMember = "TEN_TUYEN";
            cbo_TuyenDuong.ValueMember = "ID_TUYEN";


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

        }

        private void btn_ThemLichTrinh_Click(object sender, EventArgs e)
        {
            //DateTime ngayKhoiHanh = dtp_NgayKhoiHanh.Value.Date;
            //TimeSpan gioKhoiHanh = dtp_GioKhoiHanh.Value.TimeOfDay;
            //DateTime khoiHanh = ngayKhoiHanh.Add(gioKhoiHanh); // Gộp ngày và giờ


            bool themThanhCong = ltBll.ThemLichTrinh(txt_MaLichTrinh.Text, int.Parse(cbo_TuyenDuong.SelectedValue.ToString()), DateTime.Parse(dtp_NgayKhoiHanh.Value.ToLongDateString()), float.Parse(txt_GiaVe.Text), int.Parse(cbo_Xe.SelectedValue.ToString()));


                if (themThanhCong)
                {
                    MessageBox.Show("Thêm lịch trình thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm lịch trình thất bại. Mã lịch trình đã tồn tại.");
                }
        }

        
    }
}
