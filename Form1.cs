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
            int count = 0;
            StreamWriter writers = new StreamWriter("files\\miniText", false, Encoding.GetEncoding(1251));
            count = rtbMiniText.Lines.Length;
            for (int i = 0; rtbMiniText.Lines.Length > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbMiniText.Lines[i] == "")
                        break;
                }
                writers.WriteLine(rtbMiniText.Lines[i].ToString());
            }
            writers.Close();

            count = rtbFullText.Lines.Length;
            writers = new StreamWriter("files\\fullText", false, Encoding.GetEncoding(1251));
            count = rtbFullText.Lines.Length;
            for (int i = 0; count > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbFullText.Lines[i] == "")
                        break;
                }
                writers.WriteLine(rtbFullText.Lines[i].ToString());
            }
            writers.Close();

            count = rtbAltText.Lines.Length;
            writers = new StreamWriter("files\\altText", false, Encoding.GetEncoding(1251));
            count = rtbAltText.Lines.Length;
            for (int i = 0; count > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbAltText.Lines[i] == "")
                        break;
                }
                writers.WriteLine(rtbAltText.Lines[i].ToString());
            }
            writers.Close();

            writers = new StreamWriter("files\\titleText", false, Encoding.GetEncoding(1251));
            writers.WriteLine(tbTitle.Lines[0]);
            writers.Close();

            MessageBox.Show("Текст сохранен");
        }

        private void chbSEO_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSEO.Checked)
            {
                chbKeywords.Enabled = true;
                chbDescription.Enabled = true;
                chbTitle.Enabled = true;
            }
            else
            {
                chbKeywords.Enabled = false;
                chbDescription.Enabled = false;
                chbTitle.Enabled = false;
                chbDescription.Checked = false;
                chbKeywords.Checked = false;
                chbTitle.Checked = false;

                tbDescription.Enabled = false;
                tbKeywords.Enabled = false;
                tbTitle.Enabled = false;
                
            }
        }

        private void chbAddTextTovar_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbFullText.Enabled)
            {
                rtbFullText.Enabled = false;
            }
            else
            {
                rtbFullText.Enabled = true;
            }
            if (rtbMiniText.Enabled)
            {
                rtbMiniText.Enabled = false;
            }
            else
            {
                rtbMiniText.Enabled = true;
            }
        }

        private void chbAltText_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbAltText.Enabled)
            {
                rtbAltText.Enabled = false;
            }
            else
            {
                rtbAltText.Enabled = true;
            }
        }

        private void chbTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (tbTitle.Enabled)
            {
                tbTitle.Enabled = false;
            }
            else
            {
                tbTitle.Enabled = true;
            }
        }

        private void chbDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescription.Enabled)
            {
                tbDescription.Enabled = true;
            }
            if(!chbDescription.Enabled)
            {
                tbDescription.Enabled = false;
            }
        }

        private void chbKeywords_CheckedChanged(object sender, EventArgs e)
        {
            if (tbKeywords.Enabled)
            {
                tbKeywords.Enabled = false;
            }
            else
            {
                tbKeywords.Enabled = true;
            }
        }

        private void chbDescription_EnabledChanged(object sender, EventArgs e)
        {
        }
    }
}
