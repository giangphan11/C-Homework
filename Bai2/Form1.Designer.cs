﻿namespace Bai2
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // txtA
            // 
            this.txtA.AccessibleName = "";
            this.txtA.Location = new System.Drawing.Point(78, 38);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(424, 22);
            this.txtA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "b=";
            // 
            // txtB
            // 
            this.txtB.AccessibleDescription = "";
            this.txtB.AccessibleName = "";
            this.txtB.Location = new System.Drawing.Point(78, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(424, 22);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtC
            // 
            this.txtC.AccessibleName = "";
            this.txtC.Location = new System.Drawing.Point(78, 135);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(424, 22);
            this.txtC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "c=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nghiệm";
            // 
            // txtNghiem
            // 
            this.txtNghiem.AccessibleName = "";
            this.txtNghiem.Location = new System.Drawing.Point(78, 182);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(424, 22);
            this.txtNghiem.TabIndex = 7;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.AccessibleName = "";
            this.btnGiaiPT.Location = new System.Drawing.Point(195, 270);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(137, 35);
            this.btnGiaiPT.TabIndex = 8;
            this.btnGiaiPT.Text = "Giải phương trình";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleName = "btnThoat";
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(377, 270);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(581, 365);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnThoat;
    }
}

