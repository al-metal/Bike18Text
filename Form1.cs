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
using Формирование_ЧПУ;

namespace Bike18Text
{
    public partial class Form1 : Form
    {
        WebRequest webRequest = new WebRequest();
        CHPU chpu = new CHPU();
        string otv = null;
        string boldOpen = "<span style=\"font-weight: bold; font-weight: bold; \">";
        string boldClose = "</span>%26nbsp%3B";
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
            if (!File.Exists("files\\file"))
            {
                File.Create("files\\file");
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
            text = new StreamReader("files\\file", Encoding.GetEncoding("windows-1251"));
            while (!text.EndOfStream)
            {
                string str = text.ReadLine();
                tbLogin.AppendText(str + "\n");
                str = text.ReadLine();
                tbPassword.AppendText(str + "\n");
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
                btnFullTextURL.Enabled = false;
                tbFullTextURL.Enabled = false;
            }
            else
            {
                rtbFullText.Enabled = true;
                btnFullTextURL.Enabled = true;
                tbFullTextURL.Enabled = true;
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
                btnMiniTextUrl.Enabled = false;
                tbMiniTextURL.Enabled = false;
            }
            else
            {
                rtbMiniText.Enabled = true;
                btnMiniTextUrl.Enabled = true;
                tbMiniTextURL.Enabled = true;
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
            MessageBox.Show("Готово!");
        }

        private void updateText(string tovar)
        {
            if (!tovar.Contains("nethouse"))
                tovar = tovar.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");
            List<string> tovarList = webRequest.arraySaveimage(tovar);

            if (chbTitle.Checked)
                tovarList[13] = seoTitle(tovarList, tovar);

            if (chbDescription.Checked)
                tovarList[11] = seoDescription(tovarList, tovar);

            if (chbKeywords.Checked)
                tovarList[12] = seoKeywords(tovarList, tovar);

            if (chbFullText.Checked)
                tovarList[8] = full_Text_tovar(tovarList, tovar);

            if (chbMiniText.Checked)
                tovarList[7] = mini_Text_tovar(tovarList, tovar);

            if (chbAltText.Checked)
            {
                altText(tovar);
            }

            if (chbAlsoBuy.Checked)
                tovarList[42] = alsoBuyTovars(tovarList);

            tovarList[1] = slug(tovarList);
            otv = webRequest.saveTovar(tovarList);
            if (otv.Contains("errors"))
            {

            }



        }

        private string slug(List<string> tovarList)
        {
            string str = tovarList[4].ToString();
            str = chpu.vozvr(str);
            return str;
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

        private string mini_Text_tovar(List<string> tovarList, string url)
        {
            string miniText = miniTextTemplate();
            miniText = AutoCorrect(url, miniText, "", tovarList);
            miniText = autoCrop(miniText, 1000);
            return miniText;
        }

        private string full_Text_tovar(List<string> tovarList, string url)
        {
            string fullText = fullTextTemplate();
            fullText = AutoCorrect(url, fullText, "", tovarList);
            fullText = autoCrop(fullText, 1000);
            return fullText;
        }

        private string seoKeywords(List<string> tovarList, string url)
        {
            string seoKeywordsText = tbKeywords.Lines[0];
            seoKeywordsText = AutoCorrect(url, seoKeywordsText, "seo", tovarList);
            seoKeywordsText = autoCrop(seoKeywordsText, 100);
            return seoKeywordsText;
        }

        private string seoDescription(List<string> tovarList, string url)
        {
            string seoDescriptionText = tbDescription.Lines[0];
            seoDescriptionText = AutoCorrect(url, seoDescriptionText, "seo", tovarList);
            seoDescriptionText = autoCrop(seoDescriptionText, 200);
            return seoDescriptionText;
        }

        private string seoTitle(List<string> tovarList, string url)
        {
            string seoTitleText = tbTitle.Lines[0];
            seoTitleText = AutoCorrect(url, seoTitleText, "seo", tovarList);
            seoTitleText = autoCrop(seoTitleText, 200);
            return seoTitleText;
        }

        private string alsoBuyTovars(List<string> tovarList)
        {
            string name = tovarList[4].ToString();
            otv = webRequest.getRequest("http://bike18.ru/products/search/page/1?sort=0&balance=&categoryId=&min_cost=&max_cost=&text=" + name);
            MatchCollection searchTovars = new Regex("(?<=<div class=\"product-item preview-size-156\" id=\"item).*?(?=\"><div class=\"background\">)").Matches(otv);
            string alsoBuy = "";
            int count = 0;
            if (searchTovars.Count > 1)
            {
                for (int i = 1; 5 > i; i++)
                {

                    alsoBuy += "&alsoBuy[" + count + "]=" + searchTovars[i].ToString();
                    count++;
                }
            }
            return alsoBuy;
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
                    string str = rtbMiniText.Lines[z].ToString();
                    if (str.Contains("<ссылка"))
                    {
                        string urlstring = new Regex("<ссылка .*</ссылка>").Match(str).ToString();
                        string text = new Regex("(?<=>).*(?=<)").Match(urlstring).ToString();
                        string url = new Regex("(?<=\").*(?=\")").Match(urlstring).ToString();
                        string newString = "<span><a target=\"_blank\" href=\"" + url + "\">" + text + "</a></span>";
                        str = str.Replace(urlstring, newString);
                    }
                    miniText += "<p>" + str + "</p>";
                }
            }
            return miniText;
        }

        public string fullTextTemplate()
        {
            string fullText = null;
            for (int z = 0; rtbFullText.Lines.Length > z; z++)
            {
                if (rtbFullText.Lines[z].ToString() == "")
                {
                    fullText += "<p><br /></p>";
                }
                else
                {
                    string str = rtbFullText.Lines[z].ToString();
                    if (str.Contains("<ссылка"))
                    {
                        string urlstring = new Regex("<ссылка .*</ссылка>").Match(str).ToString();
                        string text = new Regex("(?<=>).*(?=<)").Match(urlstring).ToString();
                        string url = new Regex("(?<=\").*(?=\")").Match(urlstring).ToString();
                        string newString = "<span><a target=\"_blank\" href=\"" + url + "\">" + text + "</a></span>";
                        str = str.Replace(urlstring, newString);
                    }
                    fullText += "<p>" + str + "</p>";
                }
            }
            return fullText;
        }

        public string AutoCorrect(string urlTovar, string text, string descriptionCartTovar, List<string> tovarList)
        { 
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
            if (descriptionCartTovar != "seo")
            {
                name = boldOpen + tovarList[4].ToString() + boldClose;
                price = boldOpen + tovarList[9].ToString() + boldClose;
                articl = boldOpen + tovarList[6].ToString() + boldClose;
                category1 = boldOpen + category1 + boldClose;
                category2 = boldOpen + category2 + boldClose;
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

        private void btnMiniTextUrl_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != "" & tbMiniTextURL.Text != "" & tbMiniTextURL.Text.Contains("http://"))
            {
                rtbMiniText.SelectedText = "<ссылка на =\"" + tbMiniTextURL.Text + "\">" + rtbMiniText.SelectedText + "</ссылка>"; 
            }
            else
            {
                MessageBox.Show("Проверте выделен ли текст и заполнена ли ссылка");
            }
        }

        private void btnFullTextURL_Click(object sender, EventArgs e)
        {
            if (rtbFullText.SelectedText != "" & tbFullTextURL.Text != "" & tbFullTextURL.Text.Contains("http://"))
            {
                rtbFullText.SelectedText = "<ссылка на =\"" + tbFullTextURL.Text + "\">" + rtbFullText.SelectedText + "</ссылка>";
            }
            else
            {
                MessageBox.Show("Проверте выделен ли текст и заполнена ли ссылка");
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("НАЗВАНИЕ");
        }

        private void lblCategory2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("РАЗДЕЛ2");
        }

        private void lblCategory1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("РАЗДЕЛ1");
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("ЦЕНА");
        }

        private void lblArticl_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("АРТИКУЛ");
        }

        private void btnSaveLoginPass_Click(object sender, EventArgs e)
        {
            StreamWriter writers = new StreamWriter("files\\file", false, Encoding.GetEncoding(1251));
            writers.WriteLine(tbLogin.Lines[0].ToString());
            writers.Close();
            writers = new StreamWriter("files\\file", true, Encoding.GetEncoding(1251));
            writers.WriteLine(tbPassword.Lines[0].ToString());
            
            writers.Close();
            MessageBox.Show("Логин и пароль сохранены!");
        }
        public string getLogin()
        {
            return tbLogin.Lines[0].ToString();
        }
    }
}
