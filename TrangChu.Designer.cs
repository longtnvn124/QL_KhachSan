namespace QLKSpj
{
    partial class TrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonThuePhong = new System.Windows.Forms.Button();
            this.buttonTraPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDatPhong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelKH = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ KHÁCH SẠN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flowLayoutPanelPhong);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(364, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 683);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách phòng";
            // 
            // flowLayoutPanelPhong
            // 
            this.flowLayoutPanelPhong.BackColor = System.Drawing.Color.OldLace;
            this.flowLayoutPanelPhong.Location = new System.Drawing.Point(26, 59);
            this.flowLayoutPanelPhong.Name = "flowLayoutPanelPhong";
            this.flowLayoutPanelPhong.Size = new System.Drawing.Size(876, 505);
            this.flowLayoutPanelPhong.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonThuePhong);
            this.panel5.Controls.Add(this.buttonTraPhong);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.buttonDatPhong);
            this.panel5.Location = new System.Drawing.Point(313, 582);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(589, 88);
            this.panel5.TabIndex = 2;
            // 
            // buttonThuePhong
            // 
            this.buttonThuePhong.Enabled = false;
            this.buttonThuePhong.Location = new System.Drawing.Point(436, 17);
            this.buttonThuePhong.Name = "buttonThuePhong";
            this.buttonThuePhong.Size = new System.Drawing.Size(131, 52);
            this.buttonThuePhong.TabIndex = 3;
            this.buttonThuePhong.Text = "Bắt đầu Thuê";
            this.buttonThuePhong.UseVisualStyleBackColor = true;
            this.buttonThuePhong.Click += new System.EventHandler(this.buttonThuePhong_Click);
            // 
            // buttonTraPhong
            // 
            this.buttonTraPhong.Enabled = false;
            this.buttonTraPhong.Location = new System.Drawing.Point(299, 17);
            this.buttonTraPhong.Name = "buttonTraPhong";
            this.buttonTraPhong.Size = new System.Drawing.Size(131, 52);
            this.buttonTraPhong.TabIndex = 2;
            this.buttonTraPhong.Text = "Trả Phòng";
            this.buttonTraPhong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chi tiết Phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDatPhong
            // 
            this.buttonDatPhong.Enabled = false;
            this.buttonDatPhong.Location = new System.Drawing.Point(162, 17);
            this.buttonDatPhong.Name = "buttonDatPhong";
            this.buttonDatPhong.Size = new System.Drawing.Size(131, 52);
            this.buttonDatPhong.TabIndex = 0;
            this.buttonDatPhong.Text = "Đặt phòng";
            this.buttonDatPhong.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(26, 582);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 88);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.flowLayoutPanelKH);
            this.panel2.Controls.Add(this.buttonChiTiet);
            this.panel2.Location = new System.Drawing.Point(15, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 682);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách hàng gần đây";
            // 
            // flowLayoutPanelKH
            // 
            this.flowLayoutPanelKH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanelKH.Location = new System.Drawing.Point(29, 59);
            this.flowLayoutPanelKH.Name = "flowLayoutPanelKH";
            this.flowLayoutPanelKH.Size = new System.Drawing.Size(289, 505);
            this.flowLayoutPanelKH.TabIndex = 2;
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.Location = new System.Drawing.Point(186, 599);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(132, 52);
            this.buttonChiTiet.TabIndex = 1;
            this.buttonChiTiet.Text = "Chi tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1303, 29);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýĐặtPhòngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýDoanhThuToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý Phòng";
            this.quảnLýPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // quảnLýĐặtPhòngToolStripMenuItem
            // 
            this.quảnLýĐặtPhòngToolStripMenuItem.Name = "quảnLýĐặtPhòngToolStripMenuItem";
            this.quảnLýĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quảnLýĐặtPhòngToolStripMenuItem.Text = "Quản lý đặt phòng";
            this.quảnLýĐặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐặtPhòngToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýDoanhThuToolStripMenuItem
            // 
            this.quảnLýDoanhThuToolStripMenuItem.Name = "quảnLýDoanhThuToolStripMenuItem";
            this.quảnLýDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quảnLýDoanhThuToolStripMenuItem.Text = "Quản lý doanh thu";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.MintCream;
            this.buttonDangXuat.Location = new System.Drawing.Point(1173, 51);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(118, 33);
            this.buttonDangXuat.TabIndex = 8;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1303, 749);
            this.Controls.Add(this.buttonDangXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button buttonDatPhong;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKH;
        private System.Windows.Forms.Button buttonThuePhong;
        private System.Windows.Forms.Button buttonTraPhong;
    }
}