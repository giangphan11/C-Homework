using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?",
                "Xác nhận thoát",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSo, "");
            double a = 0;
            if(Double.TryParse(txtSo.Text,out a) == false)
            {
                errorProvider1.SetError(txtSo, "Thím nhập lụi rùi");
            }
            else
            {
                lbDanhSach.Items.Add(a);
            }
            
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(double x in lbDanhSach.Items)
            {
                sum += x;
            }
            MessageBox.Show("Sum= " + sum);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(btnXoaDauCuoi, "");
            
            if (lbDanhSach.Items.Count < 2)
            {
                errorProvider1.SetError(btnXoaDauCuoi, "DS rỗng rùi, sao xoá được");
                return;
            }
            else
            {
                lbDanhSach.Items.RemoveAt(0);
                lbDanhSach.Items.RemoveAt(lbDanhSach.Items.Count - 1);
            }
            }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            /*
            int vtChon = lbDanhSach.SelectedIndex;
            if (vtChon == -1)
            {
                return;
            }
            else
            {
                lbDanhSach.Items.RemoveAt(vtChon);
            }
            */
            while (lbDanhSach.SelectedIndices.Count > 0)
            {
                lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndices[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lbDanhSach.Items.Count; i++)
            {
                double x = Double.Parse(lbDanhSach.Items[i].ToString());
                lbDanhSach.Items[i] = x*2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbDanhSach.Items.Count; i++)
            {
                double x = Double.Parse(lbDanhSach.Items[i].ToString());
                lbDanhSach.Items[i] = Math.Pow(x,2);
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            // trước khi chọn số chẵn, ta bỏ chọn số cũ
            lbDanhSach.SelectedIndex = -1;
            for(int i=0; i<lbDanhSach.Items.Count; i++)
            {
                double x = Double.Parse(lbDanhSach.Items[i].ToString());
                if (x % 2 == 0)
                {
                    lbDanhSach.SelectedIndex = i;
                }
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            lbDanhSach.SelectedIndex = -1;
            for (int i = 0; i < lbDanhSach.Items.Count; i++)
            {
                double x = Double.Parse(lbDanhSach.Items[i].ToString());
                if (x % 2 != 0)
                {
                    lbDanhSach.SelectedIndex = i;
                }
            }
        }
    }
}
