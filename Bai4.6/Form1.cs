using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTen.Text = cboTen.Items[0].ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonAll_Click(object sender, EventArgs e)
        {
            lvDanhSachChon.Items.AddRange(lvDanhSach.Items);
        }

        private void btnHuyAll_Click(object sender, EventArgs e)
        {
            lvDanhSachChon.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?",
                "Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int chon = cboTen.SelectedIndex;
            lvDanhSachChon.Items.Clear();
            txtKQ.Text = "";
            cboTen.Text = cboTen.Items[0]+"";
          
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int vt = lvDanhSach.SelectedIndex;
            if (vt == -1)
                return;
            lvDanhSachChon.Items.Add(lvDanhSach.SelectedItem);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lvDanhSachChon.Items.Count == 0)
            {
                return;
            }
            else
            {
                int vtchon = lvDanhSachChon.SelectedIndex;
                if (vtchon == -1)
                    return;
                lvDanhSachChon.Items.RemoveAt(lvDanhSachChon.SelectedIndex);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string ten = cboTen.SelectedItem.ToString();
           
            string ngay = date.Value.Day+ "/" + date.Value.Month + "/" +
                date.Value.Year;
            string gio = time.Value.Hour + ":" + time.Value.Minute+":" + time.Value.Second;
            string dschon = "";
            foreach (string x in lvDanhSachChon.Items)
            {
                dschon =dschon+x+",";
            }
            txtKQ.Text = ten+"\r\n" + ngay+" "+gio+"\r\n"+dschon ;

        }
    }
}
