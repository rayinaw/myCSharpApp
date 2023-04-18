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
using Excel = Microsoft.Office.Interop.Excel;

namespace lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Bai2_FormClosed);
        }
        private void Bai2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        private void btnNhapDuLieu_Click(object sender, EventArgs e)
        {
            Bai4_NhapDuLieu bai4_NhapDuLieu = new Bai4_NhapDuLieu();
            bai4_NhapDuLieu.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để chọn vị trí lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            saveFileDialog.FileName = "output.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = saveFileDialog.FileName;

                // Tạo đối tượng Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];

                // Ghi tên của mỗi thuộc tính vào đầu mỗi cột
                worksheet.Cells[1, 1] = "MSSV";
                worksheet.Cells[1, 2] = "Họ Tên";
                worksheet.Cells[1, 3] = "SĐT";
                worksheet.Cells[1, 4] = "Điểm Toán";
                worksheet.Cells[1, 5] = "Điểm Văn";
                worksheet.Cells[1, 6] = "ĐTB";

                // Đọc dữ liệu từ file input.txt và tính điểm trung bình
                using (StreamReader reader = new StreamReader("input.txt"))
                {
                    int row = 2;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(';');
                        string hoTen = values[0];
                        string mssv = values[1];
                        string sdt = values[2];
                        double diemToan = Convert.ToDouble(values[3]);
                        double diemVan = Convert.ToDouble(values[4]);

                        // Tính điểm trung bình
                        double diemTB = (diemToan + diemVan) / 2;

                        // Ghi dữ liệu vào file Excel
                        worksheet.Cells[row, 1] = mssv;
                        worksheet.Cells[row, 2] = hoTen;
                        worksheet.Cells[row, 3] = sdt;
                        worksheet.Cells[row, 4] = diemToan;
                        worksheet.Cells[row, 5] = diemVan;
                        worksheet.Cells[row, 6] = diemTB;
                        row++;
                    }
                }

                // Định dạng file Excel
                worksheet.Cells.EntireColumn.AutoFit();
                //Căn giữa hàng đầu tiên
                Excel.Range headerRange = worksheet.Range["A1", "F1"];
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Lưu file Excel
                workbook.SaveAs(excelFilePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Đã lưu dữ liệu vào file Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Mở OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.csv";
                openFileDialog.Title = "Chọn file Excel";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file Excel
                    string filePath = openFileDialog.FileName;

                    // Mở file Excel
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                    Excel.Worksheet worksheet = workbook.Sheets[1] as Excel.Worksheet;

                    // Đọc dữ liệu vào DataTable
                    DataTable dt = new DataTable();
                    Excel.Range range = worksheet.UsedRange;
                    for (int row = 1; row <= range.Rows.Count; row++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int col = 1; col <= range.Columns.Count; col++)
                        {
                            if (row == 1)
                            {
                                // Thêm tên cột vào DataTable
                                dt.Columns.Add(Convert.ToString((range.Cells[row, col] as Excel.Range).Value2));
                            }
                            else
                            {
                                // Thêm dữ liệu vào DataTable
                                dr[col - 1] = Convert.ToString((range.Cells[row, col] as Excel.Range).Value2);
                            }
                        }
                        if (row != 1)
                        {
                            dt.Rows.Add(dr);
                        }
                    }

                    // Đóng Excel app và workbook
                    workbook.Close();
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                    // Gán dữ liệu vào DataGridView
                    dataGridView.DataSource = dt;
                }
            }
        }
    }
}
