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
    public partial class UsCtrl_QLVe : UserControl
    {
        LichTrinhBLL ltBLL = new LichTrinhBLL();
        VeBLL vBLL = new VeBLL();
        public UsCtrl_QLVe()
        {
            InitializeComponent();
        }


        private void UsCtrl_QLVe_Load(object sender, EventArgs e)
        {

            cbo_LichTrinh.DataSource = ltBLL.loadLT();
            cbo_LichTrinh.DisplayMember = "MA_LICH_TRINH";
            cbo_LichTrinh.ValueMember= "MA_LICH_TRINH";
            cbo_LichTrinh.SelectedItem = null;


            string[] trangthai = { "Tất cả", "Chưa thanh toán", "Đã thanh toán" };
            cbo_TrangThai.Items.AddRange(trangthai);
            cbo_TrangThai.SelectedIndex = 0;
            dgv_DSVe.DataSource = vBLL.LoadDSVe();
            dgv_DSVe.Columns["ID_VE"].HeaderText = "Mã vé";
            dgv_DSVe.Columns["TONG_TIEN"].HeaderText = "Tổng tiền";
            dgv_DSVe.Columns["TENKHACHHANG"].HeaderText = "Tên khách hàng";
            dgv_DSVe.Columns["SDT"].HeaderText = "Số điện thoại";
            dgv_DSVe.Columns["TRANG_THAI"].HeaderText = "Trạng thái";
            dgv_DSVe.Columns["DIEMDON"].HeaderText = "Điểm đón";
            dgv_DSVe.Columns["DIEMTRA"].HeaderText = "Điểm trả";

            dgv_DSVe.Columns["TONG_TIEN"].DefaultCellStyle.Format = "0,00" + " đ";
        }

        private void btn_DSVe_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if(cbo_LichTrinh.SelectedItem== null || cbo_TrangThai.SelectedItem==null) {
                MessageBox.Show("Vui lòng chọn mã lịch trình và trạng thái");
                return;
            }

            dgv_DSVe.DataSource = null;
            dgv_DSVe.DataSource= vBLL.locVe(cbo_LichTrinh.SelectedValue.ToString(), cbo_TrangThai.SelectedItem.ToString());

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khoá cần tìm kiếm");
                return;
            }
            dgv_DSVe.DataSource = null;
            List<object> lst= vBLL.TimKiemVe(txt_TimKiem.Text);
            if (lst != null)
            {
                dgv_DSVe.DataSource = lst;
            }
            else
            {
                MessageBox.Show("Thông tin tìm kiếm không tồn tại");
            }
            
        }

        private void btn_HuyVe_Click(object sender, EventArgs e)
        {
            if(dgv_DSVe.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn vé muốn hủy");
                return;
            }
            string mave = dgv_DSVe.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn hủy vé này không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                MessageBox.Show( vBLL.HuyVe(mave)?"Hủy vé thành công": "Hủy vé thất bại");
                var currentControl = this;
                UsCtrl_QLVe Nus = new UsCtrl_QLVe();
                var panel = currentControl.Parent;
                Parent.Controls.Remove(currentControl);
                panel.Controls.Add(Nus);
                Nus.Dock = DockStyle.Fill;
            }    
        }
    }
}
