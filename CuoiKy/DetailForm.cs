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
        public DetailForm(string Id = "")
        {
            InitializeComponent();
            SinhVienId = Id;
        }
        private string SinhVienId = "";

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            var Id = txtMSSV.Text;
            var TenSinhVien = txtname.Text;
            var LopSinhHoat=cbblopsh.SelectedItem.ToString();
            var GioiTinh = RbMale.Checked ? true : false;
            var DiemBaiTap = txtdiembt.Text;
            var DiemGiuaKy = txtdiemgk.Text;
            var DiemCuoiKy = txtdiemck.Text;



        }
    }
}
