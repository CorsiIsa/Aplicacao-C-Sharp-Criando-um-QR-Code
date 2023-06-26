using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Exemplo_QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode1_Click(object sender, EventArgs e)
        {
            GerarQRCode1();
        }

        private void GerarQRCode1()
        {
            string Nome = "Gabriel Alves";

            QRCodeGenerator qrGeneretor = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGeneretor.CreateQrCode(Nome, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox1.Image = qrCode.GetGraphic(4);
        }

        private void btnCode2_Click(object sender, EventArgs e)
        {
            GerarQRCode2();
        }

        private void GerarQRCode2()
        {
            string Nome = "Isabelle Corsi";

            QRCodeGenerator qrGeneretor = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGeneretor.CreateQrCode(Nome, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox2.Image = qrCode.GetGraphic(4);
        }
    }
}
