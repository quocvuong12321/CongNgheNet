using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class UsCtrl_ThongTinNhanVien : UserControl
    {
        public string Manv;
        frm_Main main;
        NhanVienBLL nvBLL = new NhanVienBLL();
        public UsCtrl_ThongTinNhanVien()
        {
            InitializeComponent();
        }

        public UsCtrl_ThongTinNhanVien(frm_Main main)
        {
            InitializeComponent();
            this.main = main;
            Manv = main.MaNV;
            NHANVIEN nv = nvBLL.getThongTinNhanVien(Manv) ;
            txt_MaNV.Text = nv.USERNAME;
            txt_HoTen.Text = nv.HOTEN;
            txt_SDT.Text = nv.SO_DT;
            txt_GioiTinh.Text = nv.GIOITINH;
            txt_DiaChi.Text = nv.DIACHI;
            txt_ChucVu.Text = nv.LOAINV;
        }


        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            UsCtrl_DoiMatKhau us = new UsCtrl_DoiMatKhau() ;
            if (main != null)
            {
                us.getMaNV(Manv);
                main.MoUsCtrl(us);
                
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
