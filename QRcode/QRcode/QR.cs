using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using QRCoder;

namespace QRcode
{
    public partial class QR : Form
    {
        private string logoPath = "logo.png";
        public QR()
        {
            InitializeComponent();
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(txtInput.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            try
            {
                Bitmap bitmap = qRCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(logoPath));
                picQRcode.Image = bitmap;
            }
            catch
            {
                Bitmap bitmap = qRCode.GetGraphic(20);
                picQRcode.Image = bitmap;
            }
        }
        
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reference: https://github.com/codebude/QRCoder/ \n\n (c) Titytus","Infomation");
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png|All files (*.*)|*.*",
                Title = "Choose *.png file"
            };
            try
            {
                openFileDialog.ShowDialog();
                logoPath = openFileDialog.FileName;
            }
            catch (FileLoadException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            logoPath = openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Title = "Save QR code",
                FileName = "QR-code-" + random.Next().GetHashCode(),
                Filter = "Image (*.png)|*.png|All files (*.*)|*.*"
            };
            saveFile.ShowDialog();
            try
            {
                picQRcode.Image.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch
            {
                MessageBox.Show("Đường dẫn file không hợp lệ hoặc đã tồn tại!");
            }
        }
    }
}
