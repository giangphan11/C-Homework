using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int row;
        private void btnThem_Click(object sender, EventArgs e)
        {
            row = listView1.Items.Count;
            listView1.Items.Add(txtHoTen.Text);
            listView1.Items[row].SubItems.Add(txtNgaySinh.Text);
            listView1.Items[row].SubItems.Add(txtQueQuan.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(row);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
