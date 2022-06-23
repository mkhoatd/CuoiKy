using CuoiKy.BLL;
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
    public partial class MainForm : Form
    {
        HocPhanBLL hocPhanBLL = HocPhanBLL.Instance;
        SinhVienBLL sinhVienBLL= SinhVienBLL.Instance;
        public MainForm()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
        }
        private void LoadComboBox()
        {
            var cbbItems = hocPhanBLL.GetAllHocPhanCBBs();
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(cbbItems.ToArray());
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(new String[] { "No order","Id", "Tên sinh viên", "Lớp sinh hoạt", "Điểm bài tập", "Điểm giữa kỳ",
            "Điểm cuối kỳ","Điểm tổng kết","Học phần"});
            comboBox2.SelectedIndex = 0;
        }
        private void LoadData()
        {
            var name = textBox1.Text;
            var lsh = comboBox1.SelectedItem.ToString();
            var ob = comboBox2.SelectedItem.ToString();
            dataGridView1.DataSource = sinhVienBLL.GetAllSinhVienDTOs(name, lsh, ob);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DetailForm frm = new DetailForm();
            frm.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DetailForm form = new DetailForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            
        }

        private void btSort_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
