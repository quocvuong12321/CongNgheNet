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
        public UsCtrl_BanVe()
        {
            InitializeComponent();
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
            }
        }
    }
}
