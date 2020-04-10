using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc thoát?",
                "Xác nhận thoát",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            this.ActiveControl = txtTen;
            txtM1.Text = "";
            txtM2.Text = "";
            txtM3.Text = "";
            txtM4.Text = "";
            txtM5.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            float m1 = Single.Parse(txtM1.Text);
            float m2 = Single.Parse(txtM2.Text);
            float m3 = Single.Parse(txtM3.Text);
            float m4 = Single.Parse(txtM4.Text);
            float m5 = Single.Parse(txtM5.Text);
            float dtb = (m1 + m2 + m3 + m4 + m5) / 5;
            txtKQ2.Text = dtb + "";
            string xepLoai = "";
            if (dtb < 5)
            {
                xepLoai = "Yếu";
            }
            else if (dtb < 6.5)
            {
                xepLoai = "Trung bình";
            }
            else if (dtb < 7.5)
            {
                xepLoai = "Khá";
            }
            else if (dtb < 9)
            {
                xepLoai = "Giỏi";
            }
            else
            {
                xepLoai = "Xuất sắc";
            }
            txtKQ1.Text = txtTen.Text  + Environment.NewLine + "Xếp loại: " + xepLoai;
        }
    }
}
