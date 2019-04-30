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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlaintext.Clear();
            txtEncoded.Clear();
            txtDecoded.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“Implementimi i Base64 enkoderit dhe dekoderit” është detyrë e realizuar në " +
                "kuadër të lëndës “Siguria e të Dhënave”, lëndë e cila është oligative dhe i takon semestrit " +
                "IV të studimeve, niveli bachelor, UP 'Hasan Prishtina' - FIEK.\n\nMentor:     MSc. Arbnor Halili\nStudentët: Erza Hasangjekaj & Mirsad Dibrani" +
                "\n\n                                                 Prishtinë, Maj 2019");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
