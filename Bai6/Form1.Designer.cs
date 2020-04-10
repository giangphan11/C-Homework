namespace Bai6
{
    partial class frmTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(41, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(537, 343);
            this.treeView1.TabIndex = 0;
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.Location = new System.Drawing.Point(216, 390);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(103, 37);
            this.btnXoaNode.TabIndex = 1;
            this.btnXoaNode.Text = "Xóa Node";
            this.btnXoaNode.UseVisualStyleBackColor = true;
            this.btnXoaNode.Click += new System.EventHandler(this.btnXoaNode_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(343, 390);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(103, 37);
            this.btnXoaAll.TabIndex = 1;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(475, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 37);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoaNode);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnXoaNode;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnThoat;
    }
}

