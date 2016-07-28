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

namespace Bike18Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("files"))
            {
                Directory.CreateDirectory("files");
            }
            if (!File.Exists("files\\altText"))
            {
                File.Create("files\\altText");
            }
            if (!File.Exists("files\\miniText"))
            {
                File.Create("files\\miniText");
            }
            if (!File.Exists("files\\fullText"))
            {
                File.Create("files\\fullText");
            }
            if (!File.Exists("files\\titleText"))
            {
                File.Create("files\\titleText");
            }
            if (!File.Exists("files\\descriptionText"))
            {
                File.Create("files\\descriptionText");
            }
            if (!File.Exists("files\\keywordsText"))
            {
                File.Create("files\\keywordsText");
            }

            StreamReader text = new StreamReader("files\\altText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                rtbAltText.AppendText(str + "\n");
            }
            text.Close();

            text = new StreamReader("files\\miniText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                rtbMiniText.AppendText(str + "\n");
            }
            text.Close();

            text = new StreamReader("files\\fullText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                rtbFullText.AppendText(str + "\n");
            }
            text.Close();

            text = new StreamReader("files\\titleText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                tbTitle.AppendText(str + "\n");
            }
            text.Close();

            text = new StreamReader("files\\descriptionText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                tbDescription.AppendText(str + "\n");
            }
            text.Close();

            text = new StreamReader("files\\keywordsText", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                tbKeywords.AppendText(str + "\n");
            }
            text.Close();

        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {

        }
    }
}
