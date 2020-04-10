namespace Bai4._6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTen = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChonAll = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuyAll = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lvDanhSach = new System.Windows.Forms.ListBox();
            this.lvDanhSachChon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thể Thao";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn họ tên:";
            // 
            // cboTen
            // 
            this.cboTen.FormattingEnabled = true;
            this.cboTen.Items.AddRange(new object[] {
            "Nguyễn Thanh Tâm",
            "Bùi Văn An",
            "Trần Thị Hạnh",
            "Trần Văn Phúc",
            "Tô Thị Giải",
            "Nguyễn Văn Thoát"});
            this.cboTen.Location = new System.Drawing.Point(212, 97);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(260, 24);
            this.cboTen.TabIndex = 2;
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(352, 146);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 22);
            this.time.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(144, 146);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(110, 22);
            this.date.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách các môn";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh sách đã chọn";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kết quả";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(74, 425);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(250, 89);
            this.txtKQ.TabIndex = 5;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(378, 394);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(94, 36);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(378, 436);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 36);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(378, 478);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChonAll
            // 
            this.btnChonAll.Location = new System.Drawing.Point(245, 230);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.Size = new System.Drawing.Size(75, 30);
            this.btnChonAll.TabIndex = 8;
            this.btnChonAll.Text = ">>";
            this.btnChonAll.UseVisualStyleBackColor = true;
            this.btnChonAll.Click += new System.EventHandler(this.btnChonAll_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(245, 266);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 30);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuyAll
            // 
            this.btnHuyAll.Location = new System.Drawing.Point(245, 302);
            this.btnHuyAll.Name = "btnHuyAll";
            this.btnHuyAll.Size = new System.Drawing.Size(75, 30);
            this.btnHuyAll.TabIndex = 8;
            this.btnHuyAll.Text = "<<";
            this.btnHuyAll.UseVisualStyleBackColor = true;
            this.btnHuyAll.Click += new System.EventHandler(this.btnHuyAll_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(245, 338);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "<";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.FormattingEnabled = true;
            this.lvDanhSach.ItemHeight = 16;
            this.lvDanhSach.Items.AddRange(new object[] {
            "Bóng bàn",
            "Bóng đá",
            "Nhảy dù",
            "Bập bênh",
            "Cầu lông",
            "Bắn bi",
            "Bóng chuyền",
            "Bơi lội"});
            this.lvDanhSach.Location = new System.Drawing.Point(74, 230);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(120, 148);
            this.lvDanhSach.TabIndex = 9;
            // 
            // lvDanhSachChon
            // 
            this.lvDanhSachChon.FormattingEnabled = true;
            this.lvDanhSachChon.ItemHeight = 16;
            this.lvDanhSachChon.Location = new System.Drawing.Point(352, 230);
            this.lvDanhSachChon.Name = "lvDanhSachChon";
            this.lvDanhSachChon.Size = new System.Drawing.Size(120, 148);
            this.lvDanhSachChon.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 533);
            this.Controls.Add(this.lvDanhSachChon);
            this.Controls.Add(this.lvDanhSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnHuyAll);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnChonAll);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.cboTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTen;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChonAll;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuyAll;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ListBox lvDanhSach;
        private System.Windows.Forms.ListBox lvDanhSachChon;
        private System.Windows.Forms.Label label4;
    }
}

