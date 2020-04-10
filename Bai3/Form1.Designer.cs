namespace Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstSachChon = new System.Windows.Forms.ListBox();
            this.btnThemDonLe = new System.Windows.Forms.Button();
            this.btnThemToanBo = new System.Windows.Forms.Button();
            this.btnXoaDonLe = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lstDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(47, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lstSachChon);
            this.groupBox2.Location = new System.Drawing.Point(435, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách đã chọn";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(3, 18);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSach.Size = new System.Drawing.Size(239, 302);
            this.lstDanhSach.TabIndex = 0;
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // lstSachChon
            // 
            this.lstSachChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSachChon.FormattingEnabled = true;
            this.lstSachChon.ItemHeight = 16;
            this.lstSachChon.Location = new System.Drawing.Point(3, 18);
            this.lstSachChon.Name = "lstSachChon";
            this.lstSachChon.Size = new System.Drawing.Size(252, 295);
            this.lstSachChon.TabIndex = 0;
            // 
            // btnThemDonLe
            // 
            this.btnThemDonLe.Location = new System.Drawing.Point(317, 126);
            this.btnThemDonLe.Name = "btnThemDonLe";
            this.btnThemDonLe.Size = new System.Drawing.Size(75, 32);
            this.btnThemDonLe.TabIndex = 2;
            this.btnThemDonLe.Text = ">";
            this.btnThemDonLe.UseVisualStyleBackColor = true;
            this.btnThemDonLe.Click += new System.EventHandler(this.btnThemDonLe_Click);
            // 
            // btnThemToanBo
            // 
            this.btnThemToanBo.Location = new System.Drawing.Point(317, 180);
            this.btnThemToanBo.Name = "btnThemToanBo";
            this.btnThemToanBo.Size = new System.Drawing.Size(75, 35);
            this.btnThemToanBo.TabIndex = 2;
            this.btnThemToanBo.Text = ">>";
            this.btnThemToanBo.UseVisualStyleBackColor = true;
            this.btnThemToanBo.Click += new System.EventHandler(this.btnThemToanBo_Click);
            // 
            // btnXoaDonLe
            // 
            this.btnXoaDonLe.Location = new System.Drawing.Point(317, 238);
            this.btnXoaDonLe.Name = "btnXoaDonLe";
            this.btnXoaDonLe.Size = new System.Drawing.Size(75, 32);
            this.btnXoaDonLe.TabIndex = 2;
            this.btnXoaDonLe.Text = "<";
            this.btnXoaDonLe.UseVisualStyleBackColor = true;
            this.btnXoaDonLe.Click += new System.EventHandler(this.btnXoaDonLe_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(601, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 2;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Location = new System.Drawing.Point(317, 290);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(75, 34);
            this.btnXoaToanBo.TabIndex = 2;
            this.btnXoaToanBo.Text = "<<";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXoaToanBo);
            this.Controls.Add(this.btnXoaDonLe);
            this.Controls.Add(this.btnThemToanBo);
            this.Controls.Add(this.btnThemDonLe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSachChon;
        private System.Windows.Forms.Button btnThemDonLe;
        private System.Windows.Forms.Button btnThemToanBo;
        private System.Windows.Forms.Button btnXoaDonLe;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnXoaToanBo;
    }
}

