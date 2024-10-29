using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class UsCtrl_BanVe : UserControl
    {
        DiaDiemBLL ddBLL = new DiaDiemBLL();
        LichTrinhBLL ltBLL = new LichTrinhBLL();
        DatVeBLL dvBLL = new DatVeBLL();
        GheBLL gBLL = new GheBLL();
        private List<string> gheDaChon;
        private double giaVe;
        public UsCtrl_BanVe()
        {
            InitializeComponent();
            gheDaChon = new List<string>();

        }

        private void loadCboDiaDiem()
        {
            cbo_DiemDi.DataSource = ddBLL.loadDiaDiem();
            cbo_DiemDi.DisplayMember = "TEN_TINH_THANH";
            cbo_DiemDi.ValueMember = "ID_DIADIEM";
            cbo_DiemDen.DataSource = ddBLL.loadDiaDiem();
            cbo_DiemDen.DisplayMember= "TEN_TINH_THANH";
            cbo_DiemDen.ValueMember = "ID_DIADIEM";
        }

        private void loadTTLicTrinh()
        {
            dgv_ThongTinLichTrinh.DataSource = ltBLL.TTLichTrinh(int.Parse(cbo_DiemDi.SelectedValue.ToString()),int.Parse(cbo_DiemDen.SelectedValue.ToString()), DateTime.Parse(dtp_NgayDi.Value.ToShortDateString()) );
            dgv_ThongTinLichTrinh.Columns["GioDi"].DefaultCellStyle.Format = "HH:mm";
            dgv_ThongTinLichTrinh.Columns["GioDen"].DefaultCellStyle.Format = "HH:mm";
            dgv_ThongTinLichTrinh.Columns["GiaVe"].DefaultCellStyle.Format = "0,00" + " đ";
        }
        private void UsCtrl_BanVe_Load(object sender, EventArgs e)
        {
            gb_Xe20.Visible = false;
            gb_Xe34.Visible = false;
            loadCboDiaDiem();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            loadTTLicTrinh();
        }

        private void dgv_ThongTinLichTrinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ThongTinLichTrinh.SelectedRows.Count > 0)
            {
                string mlt = dgv_ThongTinLichTrinh.SelectedRows[0].Cells[0].Value.ToString();
                if (dvBLL.layLoaiXe(mlt))
                {
                    gb_Xe34.Visible = false;
                    gb_Xe20.Visible = true;
                }
                else
                {
                    gb_Xe34.Visible = true;
                    gb_Xe20.Visible = false;
                }
                txt_TongTien.Clear();
                txt_ViTriGhe.Clear();
                LoadTinhTrangGhe(mlt);
            }
        }

        private void btn_SuKienChonGhe(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string viTriNgoi = clickedButton.Text;

            foreach(Button btn in gb_Xe20.Controls)
            if(clickedButton.BackColor == Color.Gray)
            {
                clickedButton.BackColor = Color.Yellow;
                txt_ViTriGhe.Text = viTriNgoi;
            }
        }

        private Control FindControlRecursive(Control parent, string name)
        {
            // Kiểm tra nếu control hiện tại là control cần tìm
            if (parent.Name == name)
            {
                return parent;
            }

            // Tìm kiếm trong các control con
            foreach (Control child in parent.Controls)
            {
                Control result = FindControlRecursive(child, name);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

        private void LoadTinhTrangGhe(string malichtrinh)
        {
            List<GHE> lst = gBLL.LoadGhe(malichtrinh);
            int SoGhe = gBLL.LaySoGhe(malichtrinh);
            giaVe = ltBLL.LayGiaLichTrinh(malichtrinh);
            foreach (var item in lst)
            {
                string viTriNgoi = item.VI_TRI_NGOI;
                string trangThai = item.TRANG_THAI;
                string buttonName = "xe" + SoGhe + "_" + viTriNgoi;

                Button seatButton = FindControlRecursive(this, buttonName) as Button;

                if (seatButton != null)
                {
                    if(trangThai.Equals("Đã đặt"))
                    {
                        seatButton.BackColor = Color.Gray;
                    }
                    else
                    {
                        seatButton.BackColor = Color.White;
                        seatButton.Click += ChucNangChonGhe;
                        //txt_TongTien.Tag = ltBLL.LayGiaLichTrinh(malichtrinh) * gheDaChon.Count  ;
                        //txt_TongTien.Text = string.Format("{0:0,00} VNĐ", txt_TongTien.Tag);
                    }
                }
                UpdateTongTien();
            }
        }

        
        private void ChucNangChonGhe(object sender,EventArgs e) 
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                if(seatButton.BackColor == Color.White)
                {
                    seatButton.BackColor = Color.ForestGreen;
                    gheDaChon.Add(seatButton.Text);
                }
                else if(seatButton.BackColor == Color.ForestGreen)
                {
                    seatButton.BackColor = Color.White;
                    gheDaChon.Remove(seatButton.Text);
                }
            }
            UpdateTongTien();
            txt_ViTriGhe.Text = String.Join(", ", gheDaChon);
        }

        private void UpdateTongTien()
        {
            double totalPrice = giaVe * gheDaChon.Count;
            txt_TongTien.Text = string.Format("{0:0,00} VNĐ", totalPrice);
            txt_TongTien.Tag = totalPrice;
        }
    }
}
