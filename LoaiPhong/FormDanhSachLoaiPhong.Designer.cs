namespace HotelManagement.LoaiPhong
{
    partial class FormDanhSachLoaiPhong
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
            dtgDanhSachLoaiPhong = new System.Windows.Forms.DataGridView();
            btnXuatExcel = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnThemMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachLoaiPhong
            // 
            dtgDanhSachLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachLoaiPhong.Location = new System.Drawing.Point(12, 66);
            dtgDanhSachLoaiPhong.Name = "dtgDanhSachLoaiPhong";
            dtgDanhSachLoaiPhong.RowHeadersWidth = 51;
            dtgDanhSachLoaiPhong.RowTemplate.Height = 24;
            dtgDanhSachLoaiPhong.Size = new System.Drawing.Size(1015, 615);
            dtgDanhSachLoaiPhong.TabIndex = 9;
            dtgDanhSachLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgDanhSachLoaiPhong_CellClick);
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = System.Drawing.Color.DarkTurquoise;
            btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnXuatExcel.Location = new System.Drawing.Point(546, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new System.Drawing.Size(167, 37);
            btnXuatExcel.TabIndex = 7;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += new System.EventHandler(btnXuatExcel_Click);
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTimKiem.Location = new System.Drawing.Point(105, 17);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(187, 32);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += new System.EventHandler(txtTimKiem_TextChanged);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new System.Drawing.Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(39, 37);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = System.Drawing.Color.LightPink;
            btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnThemMoi.Location = new System.Drawing.Point(747, 12);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new System.Drawing.Size(167, 37);
            btnThemMoi.TabIndex = 10;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += new System.EventHandler(btnThemMoi_Click);
            // 
            // FormDanhSachLoaiPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1039, 699);
            Controls.Add(btnThemMoi);
            Controls.Add(dtgDanhSachLoaiPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachLoaiPhong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin loại phòng";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachLoaiPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
    }
}
