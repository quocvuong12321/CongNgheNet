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
    public partial class UsCtrl_QLTuyenDuong : UserControl
    {
        DiaDiemBLL ddBLL = new DiaDiemBLL();
        TuyenDuongBLL tdBLL = new TuyenDuongBLL();
        public UsCtrl_QLTuyenDuong()
        {
            InitializeComponent();
        }

        private void loadDiaDiem()
        {
            cbbDiemDi.DataSource = ddBLL.loadDiaDiem();
            cbbDiemDi.DisplayMember = "TEN_TINH_THANH";
            cbbDiemDi.ValueMember = "ID_DIADIEM";
            cbbDiemDen.DataSource = ddBLL.loadDiaDiem();
            cbbDiemDen.DisplayMember = "TEN_TINH_THANH";
            cbbDiemDen.ValueMember = "ID_DIADIEM";
        }

        

        private void btnThemTuyenDuong_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(txtTenTuyenDuong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tuyến đường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtKhoangCach.Text))
            {
                MessageBox.Show("Vui lòng nhập khoảng cách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txt_ThoiGianDuKien.Text))
            {
                MessageBox.Show("Vui lòng nhập thời gian dự kiến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra biển số xe có tồn tại không
            if (tdBLL.CheckTrungTenTuyen(txtTenTuyenDuong.Text))
            {
                MessageBox.Show("Tuyến đường này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu điểm đầu và điểm cuối giống nhau
            if (cbbDiemDi.SelectedValue.ToString() == cbbDiemDen.SelectedValue.ToString())
            {
                MessageBox.Show("Điểm đầu và điểm cuối không được trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int diemDau = int.Parse(cbbDiemDi.SelectedValue.ToString());
            int diemCuoi = int.Parse(cbbDiemDen.SelectedValue.ToString());
            // Kiểm tra xem tuyến đường có trùng với tuyến nào đã có chưa (cùng điểm đầu và điểm cuối)
            if (tdBLL.CheckTrungTuyen(diemDau, diemCuoi))
            {
                MessageBox.Show("Tuyến đường này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TuyenDuongDTO td = new TuyenDuongDTO
            {
                TenTuyen = txtTenTuyenDuong.Text,
                DiemDau = int.Parse(cbbDiemDi.SelectedValue.ToString()),
                DiemCuoi = int.Parse(cbbDiemDen.SelectedValue.ToString()),
                KhoangCach = float.Parse(txtKhoangCach.Text),
                TgianDiChuyen = float.Parse(txt_ThoiGianDuKien.Text)
            };

            tdBLL.insertTuyen(td);
            MessageBox.Show("Thêm tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiDanhSachTuyenDuong();
        }

        private void UsCtrl_QLTuyenDuong_Load(object sender, EventArgs e)
        {
            loadDiaDiem();
            HienThiDanhSachTuyenDuong();
        }

        private void HienThiDanhSachTuyenDuong()
        {
            List<TuyenDuongDTO> lstTuyen = tdBLL.GetAll();
            dgvDanhSachTuyenDuong.DataSource = null;
            dgvDanhSachTuyenDuong.DataSource = lstTuyen;

            dgvDanhSachTuyenDuong.Columns["IdTuyen"].HeaderText = "Mã tuyến đường";
            dgvDanhSachTuyenDuong.Columns["TenTuyen"].HeaderText = "Tên tuyến đường";
            dgvDanhSachTuyenDuong.Columns["DiemDau"].HeaderText = "Điểm đầu";
            dgvDanhSachTuyenDuong.Columns["DiemCuoi"].HeaderText = "Điểm cuối";
            dgvDanhSachTuyenDuong.Columns["KhoangCach"].HeaderText = "Khoảng cách";
            dgvDanhSachTuyenDuong.Columns["TgianDiChuyen"].HeaderText = "Thời gian di chuyển";
            dgvDanhSachTuyenDuong.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDanhSachTuyenDuong.Font, FontStyle.Bold);
        }

        private void ClearInput()
        {
            txtTenTuyenDuong.Clear();
            txtKhoangCach.Clear();
            txt_ThoiGianDuKien.Clear();
            cbbDiemDi.SelectedIndex = -1;
            cbbDiemDen.SelectedIndex = -1;
        }

        private void dgvDanhSachTuyenDuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachTuyenDuong.Rows[e.RowIndex];

                txtTenTuyenDuong.Text = row.Cells["TenTuyen"].Value.ToString();
                txtKhoangCach.Text = row.Cells["KhoangCach"].Value.ToString();
                txt_ThoiGianDuKien.Text = row.Cells["TgianDiChuyen"].Value.ToString();

                // Cập nhật ComboBox với điểm đầu
                int diemDauId = Convert.ToInt32(row.Cells["DiemDau"].Value);
                int diemCuoiId = Convert.ToInt32(row.Cells["DiemCuoi"].Value);

                cbbDiemDi.SelectedValue = diemDauId;
                cbbDiemDen.SelectedValue = diemCuoiId;
            }
        }

        private void btnCapNhatTuyenDuong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTuyenDuong.Text))
            {
                MessageBox.Show("Vui lòng chọn một tuyến để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTuyen = Convert.ToInt32(dgvDanhSachTuyenDuong.SelectedRows[0].Cells["IdTuyen"].Value);
            if (tdBLL.CheckTrungTenTuyenKhiCapNhat(txtTenTuyenDuong.Text, idTuyen))
            {
                MessageBox.Show("Tên tuyến đường này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TuyenDuongDTO td = new TuyenDuongDTO
            {
                IdTuyen = idTuyen,
                TenTuyen = txtTenTuyenDuong.Text,
                DiemDau = int.Parse(cbbDiemDi.SelectedValue.ToString()),
                DiemCuoi = int.Parse(cbbDiemDen.SelectedValue.ToString()),
                KhoangCach = float.Parse(txtKhoangCach.Text),
                TgianDiChuyen = float.Parse(txt_ThoiGianDuKien.Text)
            };

            tdBLL.updateTuyen(td);
            MessageBox.Show("Cập nhật tuyến thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachTuyenDuong();
        }

        private void btnXoaTuyenDuong_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTuyenDuong.SelectedRows.Count > 0) // Kiểm tra nếu có dòng được chọn
            {
                // Lấy ID_TUYEN của tuyến đường được chọn từ DataGridView
                int idTuyen = Convert.ToInt32(dgvDanhSachTuyenDuong.SelectedRows[0].Cells["IdTuyen"].Value);

                // Hỏi người dùng có chắc chắn muốn xóa hay không
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tuyến đường này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi BLL để xóa tuyến đường
                    bool isDeleted = tdBLL.deleteTuyen(idTuyen);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại danh sách sau khi xóa
                        HienThiDanhSachTuyenDuong();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tuyến đường thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tuyến đường để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKhoangCach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ngăn không cho nhập ký tự
            }
        }

        private void txt_ThoiGianDuKien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép nhập số, dấu backspace và dấu chấm (.) hoặc dấu phẩy (,)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ngăn không cho nhập ký tự
            }
        }


        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
