using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyLopHoc
{
    public partial class frmLop : Form
    {
        BUS_Lop bus_lop = new BUS_Lop();
        public frmLop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(cbbKhoa.SelectedValue.ToString(), txtMaLop.Text, txtTenLop.Text);
            if (bus_lop.Insert(lop))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus_lop.Delete(txtMaLop.Text))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(cbbKhoa.SelectedValue.ToString(), txtMaLop.Text, txtTenLop.Text);
            if (bus_lop.Update(lop))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = bus_lop.Get_Khoa();
            // hiển thị và giá trị combobox
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
    }
}
