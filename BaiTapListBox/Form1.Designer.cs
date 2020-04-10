namespace BaiTapListBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(170, 24);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(197, 22);
            this.txtSo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(65, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 16;
            this.lbDanhSach.Location = new System.Drawing.Point(3, 18);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSach.Size = new System.Drawing.Size(208, 258);
            this.lbDanhSach.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSoLe);
            this.groupBox2.Controls.Add(this.btnSoChan);
            this.groupBox2.Controls.Add(this.btnBinhPhuong);
            this.groupBox2.Controls.Add(this.btnTang2);
            this.groupBox2.Controls.Add(this.btnXoaDangChon);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnTinhTong);
            this.groupBox2.Location = new System.Drawing.Point(381, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 261);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(1, 30);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(193, 26);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tổng của danh sách";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(1, 62);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(193, 26);
            this.btnXoaDauCuoi.TabIndex = 0;
            this.btnXoaDauCuoi.Text = "Xoá phần tử đầu cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(1, 94);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(193, 26);
            this.btnXoaDangChon.TabIndex = 0;
            this.btnXoaDangChon.Text = "Xoá phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(0, 126);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(193, 26);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(0, 158);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(193, 26);
            this.btnBinhPhuong.TabIndex = 0;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(0, 190);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(193, 26);
            this.btnSoChan.TabIndex = 0;
            this.btnSoChan.Text = "Chọn số chẵn";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(0, 222);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(193, 26);
            this.btnSoLe.TabIndex = 0;
            this.btnSoLe.Text = "Chọn số lẻ";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(68, 405);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(506, 35);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(406, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(87, 33);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 484);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSoLe;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

