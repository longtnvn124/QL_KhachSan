
namespace QLKSpj
{
    partial class ChiTietPhong
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
            this.labelTen = new System.Windows.Forms.Label();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.textBoxGiaP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTinhTrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxThongTin = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXóa = new System.Windows.Forms.Button();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(51, 98);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(93, 20);
            this.labelTen.TabIndex = 0;
            this.labelTen.Text = "Tên phòng :";
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenPhong.Location = new System.Drawing.Point(150, 95);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.ReadOnly = true;
            this.textBoxTenPhong.Size = new System.Drawing.Size(276, 26);
            this.textBoxTenPhong.TabIndex = 1;
            // 
            // textBoxGiaP
            // 
            this.textBoxGiaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaP.Location = new System.Drawing.Point(150, 359);
            this.textBoxGiaP.Name = "textBoxGiaP";
            this.textBoxGiaP.ReadOnly = true;
            this.textBoxGiaP.Size = new System.Drawing.Size(276, 26);
            this.textBoxGiaP.TabIndex = 7;
            this.textBoxGiaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaP_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá phòng :";
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoai.Location = new System.Drawing.Point(150, 316);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.ReadOnly = true;
            this.textBoxLoai.Size = new System.Drawing.Size(276, 26);
            this.textBoxLoai.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại phòng :";
            // 
            // textBoxTinhTrang
            // 
            this.textBoxTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTinhTrang.Location = new System.Drawing.Point(150, 274);
            this.textBoxTinhTrang.Name = "textBoxTinhTrang";
            this.textBoxTinhTrang.ReadOnly = true;
            this.textBoxTinhTrang.Size = new System.Drawing.Size(276, 26);
            this.textBoxTinhTrang.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tình Trạng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thông tin :";
            // 
            // richTextBoxThongTin
            // 
            this.richTextBoxThongTin.Location = new System.Drawing.Point(151, 138);
            this.richTextBoxThongTin.Name = "richTextBoxThongTin";
            this.richTextBoxThongTin.ReadOnly = true;
            this.richTextBoxThongTin.Size = new System.Drawing.Size(275, 115);
            this.richTextBoxThongTin.TabIndex = 13;
            this.richTextBoxThongTin.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(387, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 36);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(121, 445);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(108, 36);
            this.buttonSua.TabIndex = 15;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXóa
            // 
            this.buttonXóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXóa.Location = new System.Drawing.Point(273, 445);
            this.buttonXóa.Name = "buttonXóa";
            this.buttonXóa.Size = new System.Drawing.Size(108, 36);
            this.buttonXóa.TabIndex = 16;
            this.buttonXóa.Text = "Xóa";
            this.buttonXóa.UseVisualStyleBackColor = true;
            this.buttonXóa.Click += new System.EventHandler(this.buttonXóa_Click);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXacNhan.Location = new System.Drawing.Point(121, 445);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(108, 36);
            this.buttonXacNhan.TabIndex = 17;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Visible = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(148, 50);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 20);
            this.labelId.TabIndex = 19;
            this.labelId.Text = "0";
            // 
            // buttonHuy
            // 
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(273, 445);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(108, 36);
            this.buttonHuy.TabIndex = 20;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Visible = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // ChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 542);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.buttonXóa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.richTextBoxThongTin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTinhTrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGiaP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTenPhong);
            this.Controls.Add(this.labelTen);
            this.Name = "ChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phòng";
            this.Load += new System.EventHandler(this.ChiTietPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.TextBox textBoxGiaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxThongTin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXóa;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonHuy;
    }
}