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
        int countStrAltText = 0;

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

            writers = new StreamWriter("files\\descriptionText", false, Encoding.GetEncoding(1251));
            writers.WriteLine(tbDescription.Lines[0]);
            writers.Close();

            writers = new StreamWriter("files\\keywordsText", false, Encoding.GetEncoding(1251));
            writers.WriteLine(tbKeywords.Lines[0]);
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

        private void chbFullText_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbMiniText.Enabled)
            {
                rtbMiniText.Enabled = false;
            }
            else
            {
                rtbMiniText.Enabled = true;
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
                        updateText(tovar);
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
                                updateText(tovar);
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
                                    for (int z = 0; tovar3Url.Count > z; z++)
                                    {
                                        string tovar = tovar3Url[z].ToString();
                                        updateText(tovar);
                                    }
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
                                            for (int z = 0; tovar4Url.Count > z; z++)
                                            {
                                                string tovar = tovar4Url[z].ToString();
                                                updateText(tovar);
                                            }
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

        private void updateText(string tovar)
        {
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
            if (chbFullText.Checked)
            {
                full_Text_tovar(tovar);
            }

            if (chbMiniText.Checked)
            {
                mini_Text_tovar(tovar);
            }
            if (chbAltText.Checked)
            {
                altText(tovar);
            }
        }

        private void altText(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");
            List<string> tovarList = webRequest.listTovar(url);
            int countStringTovar = tovarList.Count;
            int countImages = returnCountImage(countStringTovar);
            
            if(countImages > 1)
            {
                for (int i = 0; countImages - 1 > i; i++)
                {
                    string altText = returnAltText();
                    countStringTovar -= 14;
                    string idImg = tovarList[countStringTovar].ToString();
                    webRequest.loadAltTextImage(idImg, altText);
                }
            }
            if (countImages == 1 || countStringTovar <= 40)
            {
                string altText = returnAltText();
                string idImg = tovarList[17].ToString();
                webRequest.loadAltTextImage(idImg, altText);
            }   
        }

        private string returnAltText()
        {
            string altText = "";
            List<string> ListAltText = new List<string>();
            foreach (string str in rtbAltText.Lines)
            {
                if (str != "")
                    ListAltText.Add(str);
            }
            if (countStrAltText >= ListAltText.Count)
                countStrAltText = 0;
            altText = ListAltText[countStrAltText].ToString();
            countStrAltText++;
            return altText;
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

        private void mini_Text_tovar(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string miniText = miniTextTemplate();

            miniText = AutoCorrect(url, miniText);
            miniText = autoCrop(miniText, 1000);
            tovarList[7] = miniText;
            webRequest.saveImage(tovarList);
        }

        private void full_Text_tovar(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            string fullText = fullTextTemplate();

            fullText = AutoCorrect(url, fullText);
            fullText = autoCrop(fullText, 1000);

            tovarList[8] = fullText;
            webRequest.saveImage(tovarList);
        }

        private void seoKeywords(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);

            string seoKeywordsText = tbKeywords.Lines[0];
            seoKeywordsText = AutoCorrect(url, seoKeywordsText);
            seoKeywordsText = autoCrop(seoKeywordsText, 100);
            tovarList[12] = seoKeywordsText;
            webRequest.saveImage(tovarList);
        }

        private void seoDescription(string url)
        {
            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            
            string seoDescriptionText = tbDescription.Lines[0];
            seoDescriptionText = AutoCorrect(url, seoDescriptionText);
            seoDescriptionText = autoCrop(seoDescriptionText, 200);
            tovarList[11] = seoDescriptionText;
            webRequest.saveImage(tovarList);
        }

        private void seoTitle(string url)
        {
            if(!url.Contains("nethouse"))
            url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            List<string> tovarList = webRequest.arraySaveimage(url);
            
            string seoTitleText = tbTitle.Lines[0];
            seoTitleText = AutoCorrect(url, seoTitleText);
            seoTitleText = autoCrop(seoTitleText, 200);
            tovarList[13] = seoTitleText;
            webRequest.saveTovar(tovarList);
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

        public string AutoCorrect(string urlTovar, string text)
        { 
            List<string> tovarList = webRequest.listTovar(urlTovar);
            otv = webRequest.getRequest(urlTovar);
            string name = tovarList[4].ToString();
            string price = tovarList[9].ToString();
            string articl = tovarList[6].ToString();
            string category1 = "";
            string category2 = "";

            MatchCollection categories = new Regex("(?<=<span class=\"separator\">/</span><a href=\").*?(?=</a>)").Matches(otv);
            int countCategories = categories.Count;
            if(countCategories == 1)
            {
                category1 = categories[0].ToString();
                category1 = category1.Remove(0, category1.IndexOf(">") +1);
            }
            else
            {
                category1 = categories[countCategories - 1].ToString();
                category2 = categories[countCategories - 2].ToString();
                category1 = category1.Remove(0, category1.IndexOf(">") + 1);
                category2 = category2.Remove(0, category2.IndexOf(">") + 1);
            }
            text = text.Replace("НАЗВАНИЕ", name).Replace("ЦЕНА", price).Replace("АРТИКУЛ", articl).Replace("РАЗДЕЛ1", category1).Replace("РАЗДЕЛ2", category2);
            
            return text;
        }

        public string autoCrop(string text, int count)
        {
            if (text.Length > count)
            {
                text = text.Remove(count);
                text = text.Remove(text.LastIndexOf(" "));
            }
            return text;
        }

        private void btnMiniTextBold_Click(object sender, EventArgs e)
        {
            FontStyle newFontStyle;
            Font currentFont = rtbMiniText.SelectionFont;
            if (rtbMiniText.SelectedText != null)
            {
                if (rtbMiniText.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }
                rtbMiniText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void btnAlignRigth_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                if (rtbMiniText.SelectionAlignment == HorizontalAlignment.Right)
                {
                    rtbMiniText.SelectionAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    rtbMiniText.SelectionAlignment = HorizontalAlignment.Right;
                }
            }
        }

        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                if (rtbMiniText.SelectionAlignment == HorizontalAlignment.Center)
                {
                    rtbMiniText.SelectionAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    rtbMiniText.SelectionAlignment = HorizontalAlignment.Center;
                }
            }
        }
    }
}
