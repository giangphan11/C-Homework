using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("Nhập môn tin học");
            lstDanhSach.Items.Add("Tin văn phòng");
            lstDanhSach.Items.Add("Lập trình mạng");
            lstDanhSach.Items.Add("lập trình trên windows");
            lstDanhSach.Items.Add("Công nghệ thực tại ảo");
            lstDanhSach.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSach.Items.Add("Lập trình hướng đối tượng");
            lstDanhSach.Items.Add("Thiết kế trang web");
            lstDanhSach.Items.Add("Đảm bảo chất lượng phần mềm");
            lstDanhSach.Items.Add("Giải thuật di truyền và ứng dụng");
            lstDanhSach.Items.Add("Hệ chuyên gia");
            lstDanhSach.Items.Add("Lập trình căn bản");
            lstDanhSach.Items.Add("Một số phương pháp tính toán mềm");
            lstDanhSach.Items.Add("Phân tích và thống kê số liệu");
            lstDanhSach.Items.Add("Thiết kế cơ sở dữ liệu");
        }

        private void btnThemDonLe_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Add(lstDanhSach.SelectedItem);
        }

        private void btnThemToanBo_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lstDanhSach.Items.Count; i++)
            {
                lstSachChon.Items.Add(lstDanhSach.Items[i]);
            }
        }

        private void btnXoaDonLe_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Remove(lstSachChon.SelectedItem);
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
