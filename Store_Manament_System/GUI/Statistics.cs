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

namespace GUI
{
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
            this.Load += Statistics_Load; // Đăng ký sự kiện Load
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            GenerateMockData();

            // Cập nhật các label với dữ liệu giả
            //bunifuLabel3.Text = $"Total Profit\n${new Random().Next(5000, 20000):N0}";
            //bunifuLabel4.Text = $"Total Revenue\n${new Random().Next(20000, 50000):N0}";
            //bunifuLabel5.Text = $"Sales by Category\n{new Random().Next(100, 500)} items";
        }

        private void GenerateMockData()
        {
            // Tạo dữ liệu giả cho chart1 (Customer Volume - Doughnut chart)
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY("New Customers", 45);
            chart1.Series["Series1"].Points.AddXY("Returning Customers", 30);
            chart1.Series["Series1"].Points.AddXY("VIP Customers", 25);

            // Tắt label trên chart1
            chart1.Series["Series1"].IsValueShownAsLabel = false;

            // Đặt font Poppins cho chart1
            chart1.Legends[0].Font = new Font("Poppins", 8, FontStyle.Regular);

            // Kiểm tra và thêm title nếu chưa có
            if (chart1.Titles.Count == 0)
            {
                chart1.Titles.Add("Customer Volume");
            }
            chart1.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);

            // Tạo dữ liệu giả cho chart2 (Total Profit - Doughnut chart)
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.AddXY("Sports Shoes", 55);
            chart2.Series["Series1"].Points.AddXY("Office Shoes", 25);
            chart2.Series["Series1"].Points.AddXY("Kids Shoes", 20);

            // Tắt label trên chart2
            chart2.Series["Series1"].IsValueShownAsLabel = false;

            // Đặt font Poppins cho chart2
            chart2.Legends[0].Font = new Font("Poppins", 8, FontStyle.Regular);

            // Kiểm tra và thêm title nếu chưa có
            if (chart2.Titles.Count == 0)
            {
                chart2.Titles.Add("Sales by Category");
            }
            chart2.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);

            // Tạo dữ liệu giả cho chart3 (Revenue Trend - Spline Area chart)
            chart3.Series["Series1"].Points.Clear();
            Random rand = new Random();
            int baseValue = 1000;

            for (int i = 0; i < 12; i++)
            {
                int value = baseValue + rand.Next(-200, 300);
                chart3.Series["Series1"].Points.AddXY(GetMonthName(i + 1), value);
                baseValue = value;
            }

            // Đặt font Poppins cho chart3
            chart3.Legends[0].Font = new Font("Poppins", 8, FontStyle.Regular);
            chart3.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Regular);
            chart3.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Regular);

            // Kiểm tra và thêm title nếu chưa có
            if (chart3.Titles.Count == 0)
            {
                chart3.Titles.Add("Revenue Trend");
            }
            chart3.Titles[0].Font = new Font("Poppins", 10, FontStyle.Bold);

            // Tùy chỉnh màu sắc cho các chart
            CustomizeChartColors();
        }

        private void CustomizeChartColors()
        {
            // Tùy chỉnh màu sắc cho chart1
            chart1.Series["Series1"].Points[0].Color = Color.FromArgb(124, 170, 150);
            chart1.Series["Series1"].Points[1].Color = Color.FromArgb(70, 130, 180);
            chart1.Series["Series1"].Points[2].Color = Color.FromArgb(255, 140, 0);

            // Tùy chỉnh màu sắc cho chart2
            chart2.Series["Series1"].Points[0].Color = Color.FromArgb(255, 192, 203);
            chart2.Series["Series1"].Points[1].Color = Color.FromArgb(147, 112, 219);
            chart2.Series["Series1"].Points[2].Color = Color.FromArgb(100, 149, 237);

            // Tùy chỉnh màu sắc cho chart3
            //chart3.Series["Series1"].Color = Color.FromArgb(124, 170, 150);
            //chart3.Series["Series1"].BorderColor = Color.FromArgb(70, 130, 180);
            //chart3.Series["Series1"].BorderWidth = 3;
        }

        private string GetMonthName(int month)
        {
            return new DateTime(2023, month, 1).ToString("MMM");
        }
    }
}