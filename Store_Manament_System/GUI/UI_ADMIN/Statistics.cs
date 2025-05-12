using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using Bunifu.UI.WinForms;
using DTO.DTO;

namespace GUI
{
    public partial class Statistics : UserControl
    {
        private readonly IReportServicesBLL _reportServicesBLL = new ReportServicesBLL();
        public Statistics()
        {
            InitializeComponent();
            this.Load += Statistics_Load; // Đăng ký sự kiện Load
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
        }

            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 10; i++)
        {
                yearComboBox.Items.Add(currentYear - i);
            }

            monthComboBox.SelectedValue = DateTime.Now.Month;
            yearComboBox.SelectedValue = DateTime.Now.Year;

            if (!DesignMode)
            {
                COGS.Text = String.Format("{0:0,0} VND",_reportServicesBLL.getTotalCostOfGoodsSoldToday());
                totalRevenue.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueToday());
                totalProfit.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueToday() - _reportServicesBLL.getTotalCostOfGoodsSoldToday());
                GenerateTopProductSelling();
                GenerateTopCategorySelling();
                generateMonthYearChart(DateTime.Now.Month, DateTime.Now.Year);
            }
        }

        private void GenerateTopProductSelling()
        {
            List<ProductRevenueDTO> productDTOs = _reportServicesBLL.getTopSellingProduct();
            chart1.Series["Series1"].Points.Clear();

            // Mảng màu gradient mới (tông màu ấm)
            Color[] baseColors = {
            Color.FromArgb(255, 255, 159, 64),    // Cam
            Color.FromArgb(255, 255, 99, 132),    // Hồng
            Color.FromArgb(255, 201, 203, 207),   // Xám nhạt
            Color.FromArgb(255, 255, 205, 86),    // Vàng nhạt
            Color.FromArgb(255, 153, 102, 255)    // Tím pastel
        };

            for (int i = 0; i < productDTOs.Count; i++)
            {
                var point = new DataPoint();
                point.SetValueXY(productDTOs[i].ProductName, productDTOs[i].TotalRevenue);

                // Màu chính và màu phụ
                point.Color = baseColors[i % baseColors.Length];
                point.BackSecondaryColor = Color.FromArgb(150, point.Color);
                point.BackGradientStyle = GradientStyle.LeftRight;

                point.BorderColor = Color.White;
                point.BorderWidth = 1;

                chart1.Series["Series1"].Points.Add(point);
            }

            // Cấu hình thêm
            chart1.Series["Series1"].IsValueShownAsLabel = false;
            chart1.Series["Series1"]["PieLabelStyle"] = "Disabled";
            chart1.Legends[0].Font = new Font("Poppins", 8, FontStyle.Regular);

            // Kiểm tra và thêm title nếu chưa có
            if (chart1.Titles.Count == 0)
            {
                chart1.Titles.Add("Top 5 Selling Products");
            }
            chart1.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);
        }


        private void GenerateTopCategorySelling()
        {
            List<CategoryRevenueDTO> categoryDTOs = _reportServicesBLL.getTopSellingCategory();
            chart2.Series["Series1"].Points.Clear();
            //chart2.Series["Series1"].Points.AddXY("Sports Shoes", 55);
            //chart2.Series["Series1"].Points.AddXY("Office Shoes", 25);
            //chart2.Series["Series1"].Points.AddXY("Kids Shoes", 20);

            // Mảng màu gradient từ đậm đến nhạt (ví dụ: màu xanh dương)
            Color[] baseColors = {
            Color.FromArgb(255, 255, 99, 132),  // Đỏ
            Color.FromArgb(255, 54, 162, 235),  // Xanh
            Color.FromArgb(255, 255, 206, 86),  // Vàng
            Color.FromArgb(255, 75, 192, 192),  // Xanh lá
            Color.FromArgb(255, 153, 102, 255)  // Tím
        };

            for (int i = 0; i < categoryDTOs.Count; i++)
            {
                var point = new DataPoint();
                point.SetValueXY(categoryDTOs[i].CategoryName, categoryDTOs[i].TotalRevenue);

                // Màu chính là màu đậm, màu phụ là màu nhạt hơn
                point.Color = baseColors[i % baseColors.Length];
                point.BackSecondaryColor = Color.FromArgb(150, point.Color); // Màu phụ là màu nhạt trong suốt

                point.BackGradientStyle = GradientStyle.DiagonalRight;
                point.BorderColor = Color.White;
                point.BorderWidth = 1;

                chart2.Series["Series1"].Points.Add(point);
            }

            // Cấu hình thêm
            chart2.Series["Series1"].IsValueShownAsLabel = false;
            chart2.Series["Series1"]["PieLabelStyle"] = "Disabled";
            chart2.Legends[0].Font = new Font("Poppins", 8, FontStyle.Regular);

            // Kiểm tra và thêm title nếu chưa có
            if (chart2.Titles.Count == 0)
            {
                chart2.Titles.Add("Top 5 Selling Categories");
            }
            chart2.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);
        }

        private void customReportBtn_Click(object sender, EventArgs e)
            {
            //filterBtn.Enabled = true;
            //monthComboBox.Enabled = true;
            //yearComboBox.Enabled = true;
            }

        private void generateMonthYearChart(int? selectedMonth, int? selectedYear)
        {
            var revenues = _reportServicesBLL.GetRevenueByMonthAndYear(selectedMonth, selectedYear);

            foreach (var revenue in revenues)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(revenue.Date.ToString(selectedMonth.HasValue && selectedYear.HasValue ? "dd/MM" :
                                                       !selectedMonth.HasValue && selectedYear.HasValue ? "MM/yyyy" :
                                                       "dd/MM/yyyy"),
                                 revenue.TotalRevenue);
                point.Color = Color.FromArgb(100, 149, 237); // Màu xanh dương pastel
                point.BorderColor = Color.White;
                point.BorderWidth = 1;

                chart3.Series["Series1"].Points.Add(point);

                chart3.Series["Series1"].IsValueShownAsLabel = true;
            }

            // Cập nhật tiêu đề biểu đồ
            if (chart3.Titles.Count == 0)
                chart3.Titles.Add("Revenue Statistics");

            chart3.Titles[0].Text = selectedMonth.HasValue && selectedYear.HasValue
                ? $"Revenue in {selectedMonth}/{selectedYear}"
                : selectedYear.HasValue
                    ? $"Monthly Revenue in {selectedYear}"
                    : selectedMonth.HasValue
                        ? $"Revenue in {selectedMonth}/{DateTime.Now.Year}"
                        : "Revenue Statistics";

            chart3.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);
        }



        private void filterBtn_Click(object sender, EventArgs e)
        {
            chart3.Series["Series1"].Points.Clear(); // Xóa dữ liệu cũ

            int? selectedMonth = monthComboBox.SelectedItem as int?;
            int? selectedYear = yearComboBox.SelectedItem as int?;

            generateMonthYearChart(selectedMonth, selectedYear);
        }

        private void thisWeekReportBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel3.Text = "Total revenue this week";
            totalProductSale.Text = _reportServicesBLL.getTotalProductsSoldThisWeek().ToString();
            totalRevenue.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisWeek());
            COGS.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalCostOfGoodsSoldThisWeek());
            totalProfit.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisWeek() - _reportServicesBLL.getTotalCostOfGoodsSoldThisWeek());
        }

        private void reportTodayBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel3.Text = "Total revenue today";
            totalRevenue.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueToday());
            totalProductSale.Text = _reportServicesBLL.getTotalProductsSoldToday().ToString();
            COGS.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalCostOfGoodsSoldToday());
            totalProfit.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueToday() - _reportServicesBLL.getTotalCostOfGoodsSoldToday());
        }

        private void thisMonthReportBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel3.Text = "Total revenue this month";
            totalRevenue.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisMonth());
            totalProductSale.Text = _reportServicesBLL.getTotalProductsSoldThisMonth().ToString();
            COGS.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalCostOfGoodsSoldThisMonth());
            totalProfit.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisMonth() - _reportServicesBLL.getTotalCostOfGoodsSoldThisMonth());
        }

        private void thisYearReportBtn_Click(object sender, EventArgs e)
        {
            bunifuLabel3.Text = "Total revenue this year";
            totalRevenue.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisYear());
            totalProductSale.Text = _reportServicesBLL.getTotalProductsSoldThisYear().ToString();
            COGS.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalCostOfGoodsSoldThisYear());
            totalProfit.Text = String.Format("{0:0,0} VND", _reportServicesBLL.getTotalRevenueThisYear() - _reportServicesBLL.getTotalCostOfGoodsSoldThisYear());
        }
    }
}