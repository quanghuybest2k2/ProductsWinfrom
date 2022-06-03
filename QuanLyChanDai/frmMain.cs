using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChanDai.EF;
using QuanLyChanDai.Models;

namespace QuanLyChanDai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        PHONGBAN _phongban;
        NHANVIEN _nhanvien;

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tb_nhanvien nv = new tb_nhanvien();
            nv.HOTEN = txtHoTen.Text;
            nv.GIOITINH = chkGioiTinh.Checked;
            nv.NGAYSINH = dtpNgaySinh.Value;
            nv.DIACHI = txtDiaChi.Text;
            nv.DIENTHOAI = txtDienThoai.Text;
            nv.CCCD = txtCCCD.Text;
            nv.HINHANH = ImageToBase64(pbHinhAnh.Image, pbHinhAnh.Image.RawFormat);
            nv.IDPB = int.Parse(cbbPhongBan.SelectedValue.ToString());
            _nhanvien.add(nv);
            loadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        // su kien
        private void frmMain_Load(object sender, EventArgs e)
        {
            _phongban = new PHONGBAN();
            _nhanvien = new NHANVIEN();
            //load phong ban
            cbbPhongBan.DataSource = _phongban.getList();
            cbbPhongBan.DisplayMember = "TENPB";
            cbbPhongBan.ValueMember = "IDPB";
            //loadData();
        }
        void loadData()
        {
            dtgvNhanVien.DataSource = _nhanvien.getList();
            
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Open image";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                pbHinhAnh.Image = Image.FromFile(openFile.FileName);
                pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        // ham chuyen doi hinh anh luu vao database
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
