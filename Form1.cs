using Bike18;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        web.WebRequest webRequest = new web.WebRequest();
        CHPU chpu = new CHPU();
        nethouse nethouse = new nethouse();
        List<string> urls = new List<string>();
        List<string> urlsBad = new List<string>();

        string otv = null;
        string pathDirectory = Environment.CurrentDirectory + "\\files";
        string boldOpen = "<span style=\"font-weight: bold; font-weight: bold; \">";
        string boldClose = "</span>%26nbsp%3B";
        int countStrAltText = 0;
        bool err = false;
        bool errLengthMiniText = false;



        public Form1()
        {
            string template = Properties.Settings.Default.template.ToString();
            InitializeComponent();
            if (!Directory.Exists("files"))
            {
                Directory.CreateDirectory("files");
            }

            if (template == "openFileDialog1")
                template = "";

            if (template != "")
                ShowTemplate(template);
            else
                MessageBox.Show("Проблема с шаблоном, он потерялся, выберите его в ручную!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.Text = Properties.Settings.Default.login.ToString();
            tbPassword.Text = Properties.Settings.Default.password.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            string template = Properties.Settings.Default.template.ToString();
            if (template != "")
            {
                Properties.Settings.Default.template = template;
                Properties.Settings.Default.Save();
                ShowTemplate(template);
            }
            tableLayoutPanel1.Enabled = true;
        }

        #region///ChekBox
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
                chbReplaceFullText.Enabled = false;
                rtbFullText.Enabled = false;
            }
            else
            {
                chbReplaceFullText.Enabled = true;
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
                chbReplaceMiniText.Enabled = false;
            }
            else
            {
                rtbMiniText.Enabled = true;
                chbReplaceMiniText.Enabled = true;
            }
        }

        private void chbDescription_EnabledChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region//OpenFileDialog
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void создатьШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Templates form2 = new Templates();
            tableLayoutPanel1.Enabled = false;
            form2.Activate();
            form2.ShowDialog();
        }

        private void открытьШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = pathDirectory;
            openFileDialog1.ShowDialog();
            string fileTemplate = openFileDialog1.FileName.ToString();

            if (openFileDialog1.FileName != "openFileDialog1")
            {
                Properties.Settings.Default.template = fileTemplate;
                Properties.Settings.Default.Save();
                
                ShowTemplate(fileTemplate);
            }

        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            string template = Properties.Settings.Default.template.ToString();
            Properties.Settings.Default.login = tbLogin.Text;
            Properties.Settings.Default.password = tbPassword.Text;
            Properties.Settings.Default.template = template;
            Properties.Settings.Default.Save();
            File.Delete("errorFiles.txt");

            string article = "";
            CookieContainer cookie = nethouse.CookieNethouse(tbLogin.Text, tbPassword.Text);

            if (cookie.Count != 4)
            {
                MessageBox.Show("Логин или пароль введены не верно!");
                return;
            }
            if (tbURL.Lines.Length == 0)
            {
                MessageBox.Show("Заполните адрес раздела для работы на сайте");
                return;
            }

            if (rbString.Checked)
                urls.Add(tbURL.Lines[0].ToString());

            foreach (string str in urls)
            {
                otv = webRequest.getRequest(str);
                if (otv == "err")
                    continue;
                article = new Regex("(?<=Артикул:)[\\w\\W]*?(?=</div>)").Match(otv).ToString();

                if (article != "")
                    updateText(str, cookie);
                else
                {
                MatchCollection categoryUrl = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                MatchCollection tovarUrl = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);

                if (tovarUrl.Count != 0)
                {
                    for (int z = 0; tovarUrl.Count > z; z++)
                    {
                        string tovar = tovarUrl[z].ToString();
                        updateText(tovar, cookie);
                    }
                }

                if (categoryUrl.Count != 0)
                {
                    for (int i = 0; categoryUrl.Count > i; i++)
                    {
                        otv = webRequest.getRequest(categoryUrl[i].ToString());
                        MatchCollection category2Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                        MatchCollection tovar2Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                        if (tovar2Url.Count != 0)
                        {
                            for (int z = 0; tovar2Url.Count > z; z++)
                            {
                                string tovar = tovar2Url[z].ToString();
                                updateText(tovar, cookie);
                            }
                        }
                        else
                        {
                            for (int x = 0; category2Url.Count > x; x++)
                            {
                                otv = webRequest.getRequest(category2Url[i].ToString());
                                MatchCollection category3Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                MatchCollection tovar3Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                if (tovar3Url.Count != 0)
                                {
                                    for (int z = 0; tovar3Url.Count > z; z++)
                                    {
                                        string tovar = tovar3Url[z].ToString();
                                        updateText(tovar, cookie);
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
                                                updateText(tovar, cookie);
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
            urls.Clear();
            string message = "";
            if (err)
                message = "Во время работы возникли ошибки";
            else if (errLengthMiniText)
                message = "Во время обновления были товары в которых превышена длинна краткого описания, данный товар был пропущен и не обновлен";
            else
                message = "Обновление товара прошло успешно!";
            var okMessageBox = MessageBox.Show(message, "Внимание", MessageBoxButtons.OK);

            if(okMessageBox == DialogResult.OK)
            {
                if(errLengthMiniText)
                    Process.Start("C:\\Windows\\System32\\notepad.exe", "errorFiles.txt");
            }
        }

        private void updateText(string urlTovar, CookieContainer cookie)
        {
            err = false;
            errLengthMiniText = false;
            List<string> tovarList = nethouse.GetProductList(cookie, urlTovar);

            if (chbTitle.Checked)
                tovarList[13] = seoTitle(tovarList, urlTovar);

            if (chbDescription.Checked)
                tovarList[11] = seoDescription(tovarList, urlTovar);

            if (chbKeywords.Checked)
                tovarList[12] = seoKeywords(tovarList, urlTovar);

            if (chbFullText.Checked)
            {
                if (chbReplaceFullText.Checked)
                    tovarList[8] = full_Text_tovar(tovarList, urlTovar);
                else
                {
                    string fullText = tovarList[8].ToString();
                    fullText += full_Text_tovar(tovarList, urlTovar);
                    tovarList[8] = fullText;
                }
            }

            if (chbMiniText.Checked)
            {
                if (chbReplaceMiniText.Checked)
                    tovarList[7] = mini_Text_tovar(tovarList, urlTovar);
                else
                {
                    string miniText = tovarList[7].ToString();
                    miniText += mini_Text_tovar(tovarList, urlTovar);

                    string s = miniText;
                    MatchCollection tags = new Regex("<.*?>").Matches(s);
                    for (int i = 0; tags.Count > i; i++)
                    {
                        s = s.Replace(tags[i].ToString(), "");
                    }

                    int lengthMiniText = s.Length;
                    if (lengthMiniText > 1000)
                    {
                        errLengthMiniText = true;
                        StreamWriter sw = new StreamWriter("errorFiles.txt", true);
                        sw.WriteLine(urlTovar);
                        sw.Close();
                    }

                    tovarList[7] = autoCrop(miniText, 16000);
                }
            }

            if (chbAltText.Checked)
                altText(cookie, urlTovar, tovarList);

            if (chbAlsoBuy.Checked)
                tovarList[42] = alsoBuyTovars(tovarList);

            if(chbCHPU.Checked)
                tovarList[1] = slug(tovarList);

            if(!errLengthMiniText)
                otv = nethouse.SaveTovar(cookie, tovarList);

            
            if (otv.Contains("errors"))
            {
                err = true;
                int g = 1;
                if (otv.Contains("slug"))
                {
                    do
                    {
                        string s = tovarList[1].ToString();
                        s = s.Remove(s.Length - 1, 1);
                        s = s + g;
                        g++;
                        tovarList[1] = s;
                        otv = nethouse.SaveTovar(cookie, tovarList);
                        err = false;
                    }
                    while (otv.Contains("errors"));
                }
            }
        }

        private string slug(List<string> tovarList)
        {
            string str = tovarList[4].ToString();
            if (chbUrlArticle.Checked)
            {
                string chpuArticle = chpu.vozvr(tovarList[6].ToString());
                str = chpu.vozvr(str) + "-" + chpuArticle;
            }
            else
                str = chpu.vozvr(str);

            return str;
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
                case 40:
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
                case 194:
                    countImages = 12;
                    break;
                case 208:
                    countImages = 13;
                    break;
                case 222:
                    countImages = 14;
                    break;
            }
            return countImages;
        }

        #region//Обработка текста
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

        private string mini_Text_tovar(List<string> tovarList, string url)
        {
            string miniText = miniTextTemplate();
            miniText = AutoCorrect(url, miniText, "", tovarList);
            miniText = autoCrop(miniText, 10000);
            return miniText;
        }

        private string full_Text_tovar(List<string> tovarList, string url)
        {
            string fullText = fullTextTemplate();
            fullText = AutoCorrect(url, fullText, "", tovarList);
            return fullText;
        }

        private void altText(CookieContainer cookie, string url, List<string> tovarList)
        {
            List<string> imagesId = webRequest.ReturnImagesId(cookie, url);
            string altText = "";
            if(imagesId.Count > 0)
            {
                foreach (string str in imagesId)
                {
                    altText = returnAltText();
                    altText = AutoCorrect(url, altText, "seo", tovarList);
                    webRequest.loadAltTextImage(cookie, str, altText);
                }
            }
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
                for (int i = 0; 4 > i; i++)
                {

                    alsoBuy += "&alsoBuy[" + count + "]=" + searchTovars[i].ToString();
                    count++;
                }
            }
            return alsoBuy;
        }
        #endregion

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

                    if (str.Contains("<align center>"))
                        str = str.Replace("<align center>", "<p style=\"text-align: center;\">");

                    if (str.Contains("<align rigth>"))
                        str = str.Replace("<align rigth>", "<p style=\"text-align: right;\">");

                    if (str.Contains("</align>"))
                        str = str.Replace("</align>", "</p>");

                    if (str.Contains("<b>"))
                        str = str.Replace("<b>", "<span style=\"font-weight: bold; font-weight: bold;\">");

                    if (str.Contains("</b>"))
                        str = str.Replace("</b>", "</span>");

                    if (str.Contains("<em>"))
                        str = str.Replace("<em>", "<span style=\"font - style: italic; \">");

                    if (str.Contains("</em>"))
                        str = str.Replace("</em>", "</span>");

                    if (!str.Contains("<p"))
                        miniText += "<p>" + str + "</p>";
                    else
                        miniText += str;
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

                    if (str.Contains("<align center>"))
                        str = str.Replace("<align center>", "<p style=\"text-align: center;\">");

                    if (str.Contains("<align rigth>"))
                        str = str.Replace("<align rigth>", "<p style=\"text-align: right;\">");

                    if (str.Contains("</align>"))
                        str = str.Replace("</align>", "</p>");

                    if (str.Contains("<b>"))
                        str = str.Replace("<b>", "<span style=\"font-weight: bold; font-weight: bold;\">");

                    if (str.Contains("</b>"))
                        str = str.Replace("</b>", "</span>");

                    if (str.Contains("<em>"))
                        str = str.Replace("<em>", "<span style=\"font-style: italic;\">");

                    if (str.Contains("</em>"))
                        str = str.Replace("</em>", "</span>");

                    if (!str.Contains("<p"))
                        fullText += "<p>" + str + "</p>";
                    else
                        fullText += str;
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
            if (countCategories == 1)
            {
                category1 = categories[0].ToString();
                category1 = category1.Remove(0, category1.IndexOf(">") + 1);
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
            text = specChar(text);
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

        public void ShowTemplate(string fileTemplate)
        {
            if (File.Exists(fileTemplate))
            {
                string[] templateString = File.ReadAllLines(fileTemplate, Encoding.GetEncoding(1251));
                if (templateString.Length == 6)
                {
                    rtbFullText.Clear();
                    rtbMiniText.Clear();
                    rtbAltText.Clear();

                    tbTitle.Text = templateString[2].ToString().Replace("\\r\\n", "");
                    tbDescription.Text = templateString[3].ToString().Replace("\\r\\n", "");
                    tbKeywords.Text = templateString[4].ToString().Replace("\\r\\n", "");

                    string miniTextString = templateString[0].ToString().Replace("\\r\\n", "†");
                    miniTextString = miniTextString.TrimEnd('†');
                    string[] miniText = miniTextString.Split('†');
                    foreach (string str in miniText)
                    {
                        rtbMiniText.AppendText(str + "\n");
                    }

                    string fullTextString = templateString[1].ToString().Replace("\\r\\n", "†");
                    fullTextString = fullTextString.TrimEnd('†');
                    string[] fullText = fullTextString.Split('†');
                    foreach (string str in fullText)
                    {
                        rtbFullText.AppendText(str + "\n");
                    }
                    string altTextString = templateString[5].ToString().Replace("\\r\\n", "†");
                    altTextString = altTextString.TrimEnd('†');
                    string[] altText = altTextString.Split('†');
                    foreach (string str in altText)
                    {
                        rtbAltText.AppendText(str + "\n");
                    }
                    if (File.Exists(fileTemplate))
                        File.Delete(fileTemplate);
                    StreamWriter writers = new StreamWriter(fileTemplate, true, Encoding.GetEncoding(1251));
                    writers.WriteLine(miniTextString.Replace("†", "\\r\\n"));
                    writers.WriteLine(fullTextString.Replace("†", "\\r\\n"));
                    writers.WriteLine(tbTitle.Text);
                    writers.WriteLine(tbDescription.Text);
                    writers.WriteLine(tbKeywords.Text);
                    writers.WriteLine(altTextString.Replace("†", "\\r\\n"));
                    writers.Close();
                }
                else
                {
                    MessageBox.Show("Некорректный файл, выберите другой");
                    return;
                }
            }
            else
            {
                Properties.Settings.Default.template = "";
                Properties.Settings.Default.Save();
            }
        }

        public string specChar(string text)
        {
            text = text.Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&laquo;", "«").Replace("&raquo;", "»").Replace("&ndash;", "-").Replace("&mdash;", "-").Replace("&lsquo;", "‘").Replace("&rsquo;", "’").Replace("&sbquo;", "‚").Replace("&ldquo;", "\"").Replace("&rdquo;", "”").Replace("&bdquo;", "„").Replace("&#43;", "+").Replace("&#40;", "(").Replace("&nbsp;", " ").Replace("&#41;", ")").Replace("&amp;quot;", "").Replace("&#039;", "'").Replace("&amp;gt;", ">").Replace("&#43;", "+").Replace("&#40;", "(").Replace("&nbsp;", " ").Replace("&#41;", ")").Replace("&#39;", "'").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&laquo;", "«").Replace("&raquo;", "»").Replace("&ndash;", "-").Replace("&mdash;", "-").Replace("&lsquo;", "‘").Replace("&rsquo;", "’").Replace("&sbquo;", "‚").Replace("&ldquo;", "\"").Replace("&rdquo;", "”").Replace("&bdquo;", "„").Replace("&#43;", "+").Replace("&#40;", "(").Replace("&nbsp;", " ").Replace("&#41;", ")").Replace("&amp;quot;", "").Replace("&#039;", "'").Replace("&amp;gt;", ">").Replace("&#43;", "+").Replace("&#40;", "(").Replace("&nbsp;", " ").Replace("&#41;", ")").Replace("&#39;", "'").Replace(",", "").Replace("\"", "");

            return text;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработка программы: al-metal\ne-mail: al-metal@bk.ru", "О программе");
        }

        private void btnLoadURLs_Click(object sender, EventArgs e)
        {
            ofdLoadURLs.ShowDialog();

            string fileUrls = ofdLoadURLs.FileName.ToString();

            if (ofdLoadURLs.FileName != "openFileDialog1" & ofdLoadURLs.FileName != "")
            {
                label4.Visible = true;
                label5.Visible = true;
                lblUrlAllCount.Visible = true;
                lblUrlCount.Visible = true;

                urls = new List<string>();
                urlsBad = new List<string>();

                FileInfo file = new FileInfo(fileUrls);
                ExcelPackage p = new ExcelPackage(file);

                ExcelWorksheet w = p.Workbook.Worksheets[1];
                int q = w.Dimension.Rows;
                btnLoadURLs.Text = "Идет разбор списка...";
                for (int i = 1; q >= i; i++)
                {
                    try
                    {
                        string url = w.Cells[i, 2].Value.ToString();
                        if (url != null)
                        {
                            if (url.Contains("category") || !url.Contains("products/"))
                                urlsBad.Add(url);
                            else
                                urls.Add(url);
                        }
                    }
                    catch
                    {

                    }
                    
                }
                lblUrlCount.Text = urls.Count.ToString();
                lblUrlAllCount.Text = q.ToString();

                btnLoadURLs.Text = "Загрузить список ссылок";
            }
        }

        private void rbString_CheckedChanged(object sender, EventArgs e)
        {
            if (rbString.Checked)
            {
                btnLoadURLs.Visible = false;
                lblUrlAllCount.Visible = false;
                lblUrlCount.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                tbURL.Enabled = true;
            }
        }

        private void rbFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiles.Checked)
            {
                btnLoadURLs.Visible = true;
                lblUrlAllCount.Visible = true;
                lblUrlCount.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                tbURL.Enabled = false;
            }
        }

    }
}
