using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using web;

namespace Bike18Text
{
    public partial class Form1 : Form
    {
        WebRequest webRequest = new WebRequest();

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
            if (tbDescription.Enabled)
            {
                tbDescription.Enabled = false;
            }
            else
            {
                tbDescription.Enabled = true;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            string otv = null;

            if(tbURL.Lines.Length > 0)
            {
                string url = tbURL.Lines[0].ToString();
                if (chbTitle.Checked)
                {
                    otv = webRequest.getRequest(url);
                    MatchCollection razdel = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*(?=\" class=\"blue\">)").Matches(otv);
                    for (int i = 0; razdel.Count > i; i++)
                    {
                        otv = webRequest.getRequest(razdel[i].ToString() + "/page/all");
                        string razdelName = new Regex("(?<=<h1 class=\"category-name\">).*?(?=</h1>)").Match(otv).ToString();
                        MatchCollection tovar = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*(?=\" >)").Matches(otv);
                        for(int n = 0; tovar.Count > n; n++)
                        {
                            string urlTovar = tovar[n].ToString();
                            urlTovar = urlTovar.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");
                            List<string> tovarList = webRequest.arraySaveimage(urlTovar);
                            string articl = tovarList[6].ToString();
                            string name = tovarList[4].ToString();

                            string seoTitleText = tbTitle.Lines[0];
                            seoTitleText = seoTitleText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);
                            if(seoTitleText.Length > 200)
                            {
                                seoTitleText = seoTitleText.Remove(200);
                                seoTitleText = seoTitleText.Remove(seoTitleText.LastIndexOf(" "));
                            }
                            tovarList[13] = seoTitleText;
                            webRequest.saveImage(tovarList);


                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните адрес раздела для работы на сайте");
            }
            
        }
    }
}
