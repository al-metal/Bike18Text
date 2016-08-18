﻿using System;
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
        string otv = null;

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
            if(tbURL.Lines.Length == 0)
            {
                MessageBox.Show("Заполните адрес раздела для работы на сайте");
            }
            else
            {
                string url = tbURL.Lines[0].ToString();
                otv = webRequest.getRequest(url);
                MatchCollection categoryUrl = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                MatchCollection tovarUrl = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                if(tovarUrl.Count != 0)
                {
                    for(int z = 0; tovarUrl.Count > z; z++)
                    {
                        string tovar = tovarUrl[z].ToString();
                        if (chbTitle.Checked)
                        {
                            seoTitle(tovar);
                        }
                        if (chbDescription.Checked)
                        {
                            seoDescription(tovar);
                        }
                        if (chbKeywords.Checked)
                        {
                            seoKeywords(tovar);
                        }
                        if (chbAddTextTovar.Checked)
                        {
                            mini_Full_Text_tovar(tovar);
                        }
                        if (chbAltText.Checked)
                        {
                            altText(tovar);
                        }
                    }
                }
                else
                {
                    for(int i = 0; categoryUrl.Count > i; i++)
                    {
                        otv = webRequest.getRequest(categoryUrl[i].ToString());
                        MatchCollection category2Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                        MatchCollection tovar2Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                        if (tovar2Url.Count != 0)
                        {
                            for (int z = 0; tovar2Url.Count > z; z++)
                            {
                                string tovar = tovar2Url[z].ToString();
                                if (chbTitle.Checked)
                                {
                                    seoTitle(tovar);
                                }
                                if (chbDescription.Checked)
                                {
                                    seoDescription(tovar);
                                }
                                if (chbKeywords.Checked)
                                {
                                    seoKeywords(tovar);
                                }
                                if (chbAddTextTovar.Checked)
                                {
                                    mini_Full_Text_tovar(tovar);
                                }
                                if (chbAltText.Checked)
                                {
                                    altText(tovar);
                                }
                            }
                        }
                        else
                        {
                            for(int x = 0; category2Url.Count > x; x++)
                            {
                                otv = webRequest.getRequest(category2Url[i].ToString());
                                MatchCollection category3Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                MatchCollection tovar3Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                if (tovar3Url.Count != 0)
                                {

                                }
                                else
                                {
                                    for (int m = 0; category3Url.Count > m; m++)
                                    {
                                        otv = webRequest.getRequest(category3Url[m].ToString());
                                        MatchCollection category4Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                        MatchCollection tovar4Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                        if (tovar4Url.Count != 0)
                                        {

                                        }
                                        else
                                        {
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }            
        }

        private void altText(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");
            List<string> tovarList = webRequest.listTovar(url);
            int countStringTovar = tovarList.Count;
            int countImages = returnCountImage(countStringTovar);
            
            string altText = "New altText";
            if (countImages == 1)
            {
                string idImg = tovarList[17].ToString();
                webRequest.loadAltTextImage(idImg, altText);
            }
            else
            {
                for (int i = 0; countImages - 1 > i; i++)
                {
                    countStringTovar -= 14;
                    string idImg = tovarList[countStringTovar].ToString();
                    webRequest.loadAltTextImage(idImg, altText);
                }
            }
            if(countStringTovar <= 40)
            {
                string idImg = tovarList[17].ToString();
                webRequest.loadAltTextImage(idImg, altText);
            }
            webRequest.saveImage(tovarList);
        }

        private int returnCountImage(int countStringTovar)
        {
            int countImages = 0;
            switch (countStringTovar)
            {
                case 39:
                    countImages = 1;
                    break;
                case 54:
                    countImages = 2;
                    break;
                case 68:
                    countImages = 3;
                    break;
                case 82:
                    countImages = 4;
                    break;
                case 96:
                    countImages = 5;
                    break;
                case 110:
                    countImages = 6;
                    break;
                case 124:
                    countImages = 7;
                    break;
                case 138:
                    countImages = 8;
                    break;
                case 152:
                    countImages = 9;
                    break;
                case 166:
                    countImages = 10;
                    break;
                case 180:
                    countImages = 11;
                    break;
            }
            return countImages;
        }

        private void mini_Full_Text_tovar(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string articl = tovarList[6].ToString();
            string name = tovarList[4].ToString();
            string miniText = miniTextTemplate();
            string fullText = fullTextTemplate();

            otv = webRequest.getRequest(url);
            string razdelName = new Regex("(?<=<h1 class=\"category-name\">).*?(?=</h1>)").Match(otv).ToString();

            miniText = miniText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);
            fullText = fullText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);

            if (fullText.Length > 1000)
            {
                fullText = fullText.Remove(1000);
                fullText = fullText.Remove(fullText.LastIndexOf(" "));
            }
            if (miniText.Length > 1000)
            {
                miniText = miniText.Remove(1000);
                miniText = miniText.Remove(miniText.LastIndexOf(" "));
            }

            tovarList[7] = miniText;
            tovarList[8] = fullText;
            webRequest.saveImage(tovarList);
        }

        private void seoKeywords(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string articl = tovarList[6].ToString();
            string name = tovarList[4].ToString();

            otv = webRequest.getRequest(url);
            string razdelName = new Regex("(?<=<h1 class=\"category-name\">).*?(?=</h1>)").Match(otv).ToString();

            string seoKeywordsText = tbKeywords.Lines[0];
            seoKeywordsText = seoKeywordsText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);
            if (seoKeywordsText.Length > 100)
            {
                seoKeywordsText = seoKeywordsText.Remove(100);
                seoKeywordsText = seoKeywordsText.Remove(seoKeywordsText.LastIndexOf(" "));
            }
            tovarList[12] = seoKeywordsText;
            webRequest.saveImage(tovarList);
        }

        private void seoDescription(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string articl = tovarList[6].ToString();
            string name = tovarList[4].ToString();

            otv = webRequest.getRequest(url);
            string razdelName = new Regex("(?<=<h1 class=\"category-name\">).*?(?=</h1>)").Match(otv).ToString();

            string seoDescriptionText = tbDescription.Lines[0];
            seoDescriptionText = seoDescriptionText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);
            if (seoDescriptionText.Length > 200)
            {
                seoDescriptionText = seoDescriptionText.Remove(200);
                seoDescriptionText = seoDescriptionText.Remove(seoDescriptionText.LastIndexOf(" "));
            }
            tovarList[11] = seoDescriptionText;
            webRequest.saveImage(tovarList);
        }

        private void seoTitle(string url)
        {
            if(!url.Contains("nethouse"))
            url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string articl = tovarList[6].ToString();
            string name = tovarList[4].ToString();

            otv = webRequest.getRequest(url);
            string razdelName = new Regex("(?<=<h1 class=\"category-name\">).*?(?=</h1>)").Match(otv).ToString();

            string seoTitleText = tbTitle.Lines[0];
            seoTitleText = seoTitleText.Replace("НАЗВАНИЕ", name).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ", razdelName);
            if (seoTitleText.Length > 200)
            {
                seoTitleText = seoTitleText.Remove(200);
                seoTitleText = seoTitleText.Remove(seoTitleText.LastIndexOf(" "));
            }
            tovarList[13] = seoTitleText;
            webRequest.saveImage(tovarList);
        }

        public string miniTextTemplate()
        {
            string miniText = null;
            for (int z = 0; rtbMiniText.Lines.Length > z; z++)
            {
                if (rtbMiniText.Lines[z].ToString() == "")
                {
                    miniText += "<p><br /></p>";
                }
                else
                {
                    miniText += "<p>" + rtbMiniText.Lines[z].ToString() + "</p>";
                }
            }
            return miniText;
        }

        public string fullTextTemplate()
        {
            string fullText = null;
            for (int z = 0; rtbFullText.Lines.Length > z; z++)
            {
                if (rtbMiniText.Lines[z].ToString() == "")
                {
                    fullText += "<p><br /></p>";
                }
                else
                {
                    fullText += "<p>" + rtbMiniText.Lines[z].ToString() + "</p>";
                }
            }
            return fullText;
        }
    }
}
