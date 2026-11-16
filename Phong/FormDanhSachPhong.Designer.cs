namespace HotelManagement.Phong
{
    partial class FormDanhSachPhong
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
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnXuatExcel = new System.Windows.Forms.Button();
            btnThemMoiPhong = new System.Windows.Forms.Button();
            dtgDanhSachPhong = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTimKiem.Location = new System.Drawing.Point(130, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(187, 32);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += new System.EventHandler(txtTimKiem_TextChanged);
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = System.Drawing.Color.DarkTurquoise;
            btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnXuatExcel.Location = new System.Drawing.Point(560, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new System.Drawing.Size(167, 37);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += new System.EventHandler(btnXuatExcel_Click);
            // 
            // btnThemMoiPhong
            // 
            btnThemMoiPhong.BackColor = System.Drawing.Color.MediumSpringGreen;
            btnThemMoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnThemMoiPhong.Location = new System.Drawing.Point(803, 12);
            btnThemMoiPhong.Name = "btnThemMoiPhong";
            btnThemMoiPhong.Size = new System.Drawing.Size(188, 37);
            btnThemMoiPhong.TabIndex = 3;
            btnThemMoiPhong.Text = "Thêm mới phòng";
            btnThemMoiPhong.UseVisualStyleBackColor = false;
            btnThemMoiPhong.Click += new System.EventHandler(btnThemMoiPhong_Click);
            // 
            // dtgDanhSachPhong
            // 
            dtgDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhong.Location = new System.Drawing.Point(12, 72);
            dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            dtgDanhSachPhong.RowHeadersWidth = 51;
            dtgDanhSachPhong.RowTemplate.Height = 24;
            dtgDanhSachPhong.Size = new System.Drawing.Size(1015, 615);
            dtgDanhSachPhong.TabIndex = 4;
            dtgDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgDanhSachPhong_CellClick);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new System.Drawing.Point(85, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(39, 37);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1039, 699);
            Controls.Add(dtgDanhSachPhong);
            Controls.Add(btnThemMoiPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachPhong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin phòng";
            Load += new System.EventHandler(FormDanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThemMoiPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
    }
}
