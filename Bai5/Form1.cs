using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Giới tính: ";
            if (radNam.Checked)
            {
                gioiTinh += radNam.Text;
            }
            if (radNu.Checked)
            {
                gioiTinh += radNu.Text;
            }
            string honNhan = "Tình trạng hôn nhân: ";
            if (radChuaKetHon.Checked)
            {
                honNhan += radChuaKetHon.Text;
            }
            if (radDaKetHon.Checked)
            {
                honNhan += radDaKetHon.Text;
            }
            string soThich = "Sở thích: ";
            if (chkBongDa.Checked)
            {
                soThich += chkBongDa.Text+",";
            }
            if (chkBoiLoi.Checked)
            {
                soThich += chkBoiLoi.Text + ",";
            }
            if (chkAmNhac.Checked)
            {
                soThich += chkAmNhac.Text + ",";
            }
            if (chkLeoNui.Checked)
            {
                soThich += chkLeoNui.Text + ",";
            }
            string ten = "Họ tên: " + txtHoTen.Text;
            lstDanhSach.Items.Add(ten);
            lstDanhSach.Items.Add(gioiTinh);
            lstDanhSach.Items.Add(honNhan);
            lstDanhSach.Items.Add(soThich);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
