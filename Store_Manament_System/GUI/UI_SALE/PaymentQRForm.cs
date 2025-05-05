using DTO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace GUI.UI_SALE
{
    public partial class PaymentQRForm : Form
    {
        private int remainingSeconds = 600;
        private readonly InvoiceDTO _invoiceDTO;
        public bool PaymentSuccess { get; private set; } = false;
        public PaymentQRForm(InvoiceDTO invoice)
        {
            InitializeComponent();
            _invoiceDTO = invoice;
            loadQR();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void loadQR()
        {
            var qrCode = $"2|99|0363144153|username|0|0|0|{_invoiceDTO.TotalPrice}";
            totalAmountLbl.Text = _invoiceDTO.TotalPrice.ToString("N0") + " ₫";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrCode);
            Bitmap logo = resizeImage(Properties.Resources.momo_icon_square_pinkbg_RGB, 32, 32) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            qrPictureBox.Image = bitmap;
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(remainingSeconds > 0)
            {
                remainingSeconds--;
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;

                labelMinute.Text = minutes.ToString("D2");
                labelSecond.Text = seconds.ToString("D2");
            }
            else
            {
                timer1.Stop();
                this.Close(); // Hoặc Application.Exit();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            PaymentSuccess = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
