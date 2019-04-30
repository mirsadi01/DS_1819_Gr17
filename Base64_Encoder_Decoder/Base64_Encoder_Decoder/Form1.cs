using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64_Encoder_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(txtPlaintext.Text);
            Base64Encoder myEncoder = new Base64Encoder(data);
            StringBuilder sb = new StringBuilder();

            sb.Append(myEncoder.GetEncoded());

            txtEncoded.Text = sb.ToString();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            char[] data = txtEncoded.Text.ToCharArray();
            Base64Decoder myDecoder = new Base64Decoder(data);
            StringBuilder sb = new StringBuilder();

            byte[] temp = myDecoder.GetDecoded();
            sb.Append(System.Text.UTF8Encoding.UTF8.GetChars(temp));

            txtDecoded.Text = sb.ToString();
        }
    }
}
