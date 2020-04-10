namespace Bai5
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radChuaKetHon = new System.Windows.Forms.RadioButton();
            this.radDaKetHon = new System.Windows.Forms.RadioButton();
            this.chkBongDa = new System.Windows.Forms.CheckBox();
            this.chkBoiLoi = new System.Windows.Forms.CheckBox();
            this.chkAmNhac = new System.Windows.Forms.CheckBox();
            this.chkLeoNui = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(247, 22);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(37, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDaKetHon);
            this.groupBox2.Controls.Add(this.radChuaKetHon);
            this.groupBox2.Location = new System.Drawing.Point(37, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng hôn nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLeoNui);
            this.groupBox3.Controls.Add(this.chkAmNhac);
            this.groupBox3.Controls.Add(this.chkBoiLoi);
            this.groupBox3.Controls.Add(this.chkBongDa);
            this.groupBox3.Location = new System.Drawing.Point(37, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sở thích";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(376, 25);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(326, 452);
            this.lstDanhSach.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(511, 513);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(627, 513);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(21, 21);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(21, 48);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radChuaKetHon
            // 
            this.radChuaKetHon.AutoSize = true;
            this.radChuaKetHon.Location = new System.Drawing.Point(21, 21);
            this.radChuaKetHon.Name = "radChuaKetHon";
            this.radChuaKetHon.Size = new System.Drawing.Size(113, 21);
            this.radChuaKetHon.TabIndex = 0;
            this.radChuaKetHon.TabStop = true;
            this.radChuaKetHon.Text = "Chưa kết hôn";
            this.radChuaKetHon.UseVisualStyleBackColor = true;
            // 
            // radDaKetHon
            // 
            this.radDaKetHon.AutoSize = true;
            this.radDaKetHon.Location = new System.Drawing.Point(21, 57);
            this.radDaKetHon.Name = "radDaKetHon";
            this.radDaKetHon.Size = new System.Drawing.Size(98, 21);
            this.radDaKetHon.TabIndex = 1;
            this.radDaKetHon.TabStop = true;
            this.radDaKetHon.Text = "Đã kết hôn";
            this.radDaKetHon.UseVisualStyleBackColor = true;
            // 
            // chkBongDa
            // 
            this.chkBongDa.AutoSize = true;
            this.chkBongDa.Location = new System.Drawing.Point(21, 30);
            this.chkBongDa.Name = "chkBongDa";
            this.chkBongDa.Size = new System.Drawing.Size(83, 21);
            this.chkBongDa.TabIndex = 0;
            this.chkBongDa.Text = "Bóng đá";
            this.chkBongDa.UseVisualStyleBackColor = true;
            // 
            // chkBoiLoi
            // 
            this.chkBoiLoi.AutoSize = true;
            this.chkBoiLoi.Location = new System.Drawing.Point(21, 57);
            this.chkBoiLoi.Name = "chkBoiLoi";
            this.chkBoiLoi.Size = new System.Drawing.Size(68, 21);
            this.chkBoiLoi.TabIndex = 1;
            this.chkBoiLoi.Text = "Bơi lội";
            this.chkBoiLoi.UseVisualStyleBackColor = true;
            // 
            // chkAmNhac
            // 
            this.chkAmNhac.AutoSize = true;
            this.chkAmNhac.Location = new System.Drawing.Point(21, 84);
            this.chkAmNhac.Name = "chkAmNhac";
            this.chkAmNhac.Size = new System.Drawing.Size(85, 21);
            this.chkAmNhac.TabIndex = 2;
            this.chkAmNhac.Text = "Âm nhạc";
            this.chkAmNhac.UseVisualStyleBackColor = true;
            // 
            // chkLeoNui
            // 
            this.chkLeoNui.AutoSize = true;
            this.chkLeoNui.Location = new System.Drawing.Point(21, 111);
            this.chkLeoNui.Name = "chkLeoNui";
            this.chkLeoNui.Size = new System.Drawing.Size(77, 21);
            this.chkLeoNui.TabIndex = 3;
            this.chkLeoNui.Text = "Leo núi";
            this.chkLeoNui.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thành viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radDaKetHon;
        private System.Windows.Forms.RadioButton radChuaKetHon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkLeoNui;
        private System.Windows.Forms.CheckBox chkAmNhac;
        private System.Windows.Forms.CheckBox chkBoiLoi;
        private System.Windows.Forms.CheckBox chkBongDa;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}

