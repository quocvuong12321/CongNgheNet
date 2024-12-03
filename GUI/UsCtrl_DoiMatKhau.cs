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
    public partial class UsCtrl_DoiMatKhau : UserControl
    {
        string manv;
        NhanVienBLL nvBLL = new NhanVienBLL();
        public UsCtrl_DoiMatKhau()
        {
            InitializeComponent();
        }


        public void getMaNV(string manv)
        {
            this.manv = manv;
        }
        
        private void btn_ThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (nvBLL.ktMatKhau(txt_MatKhauCu.Text, manv) == false)
            {
                MessageBox.Show("Mật khẩu không đúng, vui lòng thử lại");
            }
            else
            {
                if (txt_MatKhauMoi.Text.Equals(txt_NhapLaiMatKhau.Text))
                {
                    MessageBox.Show( nvBLL.DoiMatKhau(txt_MatKhauMoi.Text, manv)==1?"Đổi mật khẩu thành công":"Đổi mật khẩu thất bại");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp, vui lòng thử lại");
                }
            }
        }

        private void chk_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMatKhau.Checked ) {
                txt_MatKhauCu.UseSystemPasswordChar = false;
                txt_MatKhauMoi.UseSystemPasswordChar = false;
                txt_NhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhauCu.UseSystemPasswordChar = false;
                txt_MatKhauMoi.UseSystemPasswordChar = false;
                txt_NhapLaiMatKhau.UseSystemPasswordChar = false;

            }
        }
    }
}
