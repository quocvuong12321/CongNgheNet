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
    public partial class UsCtrl_QLTaiKhoan : UserControl
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        public UsCtrl_QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void UsCtrl_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadGioiTinh();
            loadLoaiTK();
        }

        private void loadLoaiTK()
        {
            string[] loainv = { "Quản lý", "Nhân viên", "Tài xế" };
            foreach (string item in loainv)
            {
                cbo_LoaiTaiKhoan.Items.Add(item);
            }
        }

        private void loadGioiTinh()
        {
            string[] gioitinh = { "Nam", "Nữ" };
            foreach(string item in gioitinh)
            {
                cbo_GioiTinh.Items.Add(item);
            }
        }

        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO(txt_TenDangNhap.Text, txt_MatKhau.Text, txt_HoTen.Text, txt_SoDienThoai.Text, cbo_GioiTinh.SelectedItem.ToString(), txt_DiaChi.Text, cbo_LoaiTaiKhoan.SelectedItem.ToString());
            MessageBox.Show(nvBLL.Insert(nv)?"Thêm thành công":"Thêm thất bại");
        }
    }
}
