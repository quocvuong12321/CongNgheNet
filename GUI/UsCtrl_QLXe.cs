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
    public partial class UsCtrl_QLXe : UserControl
    {

        XeBLL xeBLL = new XeBLL();
        public UsCtrl_QLXe()
        {
            InitializeComponent();
            LoadSoGhe();
            HienThiDanhSachXe();
        }

       
        private void LoadSoGhe()
        {
            cbo_SoGhe.Items.Add("20");
            cbo_SoGhe.Items.Add("34");
        }

        private void HienThiDanhSachXe()
        {
            List<XeDTO> lstXe = xeBLL.GetAllXe();
            dgv_DanhSachXe.DataSource = lstXe;
            dgv_DanhSachXe.Columns["Id"].HeaderText = "Mã xe";
            dgv_DanhSachXe.Columns["BienSoXe"].HeaderText = "Biển số xe";
            dgv_DanhSachXe.Columns["SoGhe"].HeaderText = "Số ghế";
            dgv_DanhSachXe.Columns["NgayThem"].HeaderText = "Ngày thêm";
            dgv_DanhSachXe.Columns["NgayThem"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgv_DanhSachXe.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhSachXe.Font, FontStyle.Bold);
        }

        private void ClearInput()
        {
            txtBienSoXe.Clear();
            cbo_SoGhe.SelectedIndex = -1;
        }


        private void btn_ThemXe_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(txtBienSoXe.Text))
            {
                MessageBox.Show("Vui lòng nhập biển số xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_SoGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra biển số xe có tồn tại không
            if (xeBLL.CheckBienSoXe(txtBienSoXe.Text))
            {
                MessageBox.Show("Biển số xe đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng xe mới
            XeDTO xe = new XeDTO
            {
                //Id = int.Parse(txt_MaXe.Text),
                BienSoXe = txtBienSoXe.Text,
                SoGhe = int.Parse(cbo_SoGhe.SelectedItem.ToString()),
                NgayThem = dtp_NgayThem.Value
            };

            // Thêm xe vào cơ sở dữ liệu
            xeBLL.InsertXe(xe);
            MessageBox.Show("Thêm xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiDanhSachXe();
            ClearInput();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            XeDTO xe = new XeDTO
            {
                //Id = int.Parse(txt_MaXe.Text),
                BienSoXe = txtBienSoXe.Text,
                SoGhe = int.Parse(cbo_SoGhe.SelectedItem.ToString()),
                NgayThem = dtp_NgayThem.Value
            };

            xeBLL.UpdateXe(xe);
            MessageBox.Show("Cập nhật xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachXe();
        }

        private void btn_XoaXe_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dgv_DanhSachXe.SelectedRows[0].Cells[0].Value.ToString());
                xeBLL.DeleteXe(id);
                MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachXe();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachXe();
        }

        
        private void dgv_DanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachXe.Rows[e.RowIndex];

                txtBienSoXe.Text = row.Cells["BienSoXe"].Value.ToString();
                // Kiểm tra và chuyển đổi giá trị ngày
                if (DateTime.TryParse(row.Cells["NgayThem"].Value.ToString(), out DateTime ngayThem))
                {
                    dtp_NgayThem.Format = DateTimePickerFormat.Custom;
                    dtp_NgayThem.CustomFormat = "dd/MM/yyyy";
                    dtp_NgayThem.Value = ngayThem;
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Cập nhật ComboBox với số ghế
                string soGhe = row.Cells["SoGhe"].Value.ToString();
                if (cbo_SoGhe.Items.Contains(soGhe))
                {
                    cbo_SoGhe.SelectedItem = soGhe;
                }
                else
                {
                    cbo_SoGhe.SelectedIndex = -1;
                }
            }
        }
    }
}
