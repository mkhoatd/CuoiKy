using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy
{
    public partial class DetailForm : Form
    {
        public DetailForm(string Id , Action d)
        {
            InitializeComponent();
            SinhVienId = Id;
            this.d = d;
            if(!(SinhVienId==""))
            {
                txtMSSV.Text = SinhVienId;
                txtMSSV.ReadOnly = true;
            }
        }
        private string SinhVienId = "";
        private Action d;

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            d();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            var Id = txtMSSV.Text;
            var TenSinhVien = txtname.Text;
            var LopSinhHoat=cbblopsh.SelectedItem.ToString();
            var NgayThi = dateTimePicker1.Value;
            var GioiTinh = RbMale.Checked ? true : false;
            var DiemBaiTap = txtdiembt.Text;
            var DiemGiuaKy = txtdiemgk.Text;
            var DiemCuoiKy = txtdiemck.Text;
            var sv = new SinhVienDTO
            {
                Id = Id,
                TenSinhVien = TenSinhVien,
                LopSinhHoat = LopSinhHoat,
                GioiTinh = GioiTinh,
                NgayThi=NgayThi,
                DiemBaiTap = Convert.ToDouble(DiemBaiTap),
                DiemGiuaKy = Convert.ToDouble(DiemGiuaKy),
                DiemCuoiKy = Convert.ToDouble(DiemCuoiKy),
            };

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
