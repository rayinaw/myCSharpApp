using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai4_NhapDuLieu : Form
    {
        public Bai4_NhapDuLieu()
        {
            InitializeComponent();

        }

        private void Nhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tất cả các ô nhập liệu đều được điền đầy đủ
            if (!string.IsNullOrEmpty(txtHoTen.Text) &&
                !string.IsNullOrEmpty(txtMSSV.Text) &&
                !string.IsNullOrEmpty(txtSDT.Text) &&
                !string.IsNullOrEmpty(txtDiemToan.Text) &&
                !string.IsNullOrEmpty(txtDiemVan.Text))
            {
                // Kiểm tra nếu điểm Toán và điểm Văn là số và nằm trong khoảng từ 0 đến 10
                float diemToan, diemVan;
                if (float.TryParse(txtDiemToan.Text, out diemToan) &&
                    float.TryParse(txtDiemVan.Text, out diemVan) &&
                    diemToan >= 0 && diemToan <= 10 &&
                    diemVan >= 0 && diemVan <= 10)
                {
                    // Kiểm tra nếu số điện thoại (SDT) là số
                    int sdt;
                    if (int.TryParse(txtSDT.Text, out sdt))
                    {
                        // Tạo nội dung để ghi vào file
                        string content = $"{txtHoTen.Text};{txtMSSV.Text};{txtSDT.Text};{diemToan};{diemVan}";

                        // Ghi nội dung vào file input.txt sử dụng FileStream
                        using (FileStream fs = new FileStream("input.txt", FileMode.Append, FileAccess.Write))
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine(content);
                        }
                        MessageBox.Show("Lưu dữ liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại phải là số!");
                    }
                }
                else
                {
                    MessageBox.Show("Điểm Toán và điểm Văn phải là số và nằm trong khoảng từ 0 đến 10!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }
    }
}
