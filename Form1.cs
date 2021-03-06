﻿using Bike18Text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xNet;
using Формирование_ЧПУ;

namespace Bike18
{
    public partial class Form1 : Form
    {
        web.WebRequest webRequest = new web.WebRequest();
        CHPU chpu = new CHPU();
        NehouseLibrary.nethouse nethouse = new NehouseLibrary.nethouse();
        List<string> urls = new List<string>();
        List<string> urlsBad = new List<string>();
        Product product;
        
        string otv = null;
        string pathDirectory = Environment.CurrentDirectory + "\\files";
        string boldOpen = "<span style=\"font-weight: bold; font-weight: bold; \">";
        string boldClose = "</span>";
        int countStrAltText = 0;
        bool err = false;
        bool errLengthMiniText = false;
        bool chpuCheked;
        bool loadCategoriesCheked;

        public Dictionary<string, string> ampersands = new Dictionary<string, string>();

        public Form1()
        {
            string template = Properties.Settings.Default.template.ToString();
            InitializeComponent();

            #region ampersand
            ampersands.Add("&bull;", "·");
            ampersands.Add("&#32;", " ");
            ampersands.Add("&#33;", "!");
            ampersands.Add("&#34;", "\"");
            ampersands.Add("&quot;", "\"");
            ampersands.Add("&#35;", "#");
            ampersands.Add("&#36;", "$");
            ampersands.Add("&#37;", "%");
            ampersands.Add("&#38;", "&");
            ampersands.Add("&amp;", "&");
            ampersands.Add("&#39;", "'");
            ampersands.Add("&#40", "(");
            ampersands.Add("&#41;", ")");
            ampersands.Add("&#42;", "*");
            ampersands.Add("&#43;", "+");
            ampersands.Add("&#44;", ",");
            ampersands.Add("&#45;", "-");
            ampersands.Add("&#46;", ".");
            ampersands.Add("&#47;", "/");
            ampersands.Add("&#48;", "0");
            ampersands.Add("&#49;", "1");
            ampersands.Add("&#50;", "2");
            ampersands.Add("&#51;", "3");
            ampersands.Add("&#52;", "4");
            ampersands.Add("&#53;", "5");
            ampersands.Add("&#54;", "6");
            ampersands.Add("&#55;", "7");
            ampersands.Add("&#56;", "8");
            ampersands.Add("&#57;", "9");
            ampersands.Add("&#58;", ":");
            ampersands.Add("&#59;", ";");
            ampersands.Add("&#60;", "<");
            ampersands.Add("&lt;", "<");
            ampersands.Add("&#61;", "=");
            ampersands.Add("&#62;", ">");
            ampersands.Add("&gt;", ">");
            ampersands.Add("&#63;", "?");
            ampersands.Add("&#64;", "@");
            ampersands.Add("&#65;", "A");
            ampersands.Add("&#66;", "B");
            ampersands.Add("&#67;", "C");
            ampersands.Add("&#68;", "D");
            ampersands.Add("&#69;", "E");
            ampersands.Add("&#70;", "F");
            ampersands.Add("&#71;", "G");
            ampersands.Add("&#72;", "H");
            ampersands.Add("&#73;", "I");
            ampersands.Add("&#74;", "J");
            ampersands.Add("&#75;", "K");
            ampersands.Add("&#76;", "L");
            ampersands.Add("&#77;", "-");
            ampersands.Add("&#78;", "N");
            ampersands.Add("&#79;", "O");
            ampersands.Add("&#80;", "P");
            ampersands.Add("&#81;", "Q");
            ampersands.Add("&#82;", "R");
            ampersands.Add("&#83;", "S");
            ampersands.Add("&#84;", "T");
            ampersands.Add("&#85;", "U");
            ampersands.Add("&#86;", "V");
            ampersands.Add("&#87;", "W");
            ampersands.Add("&#88;", "X");
            ampersands.Add("&#89;", "Y");
            ampersands.Add("&#90;", "Z");
            ampersands.Add("&#91;", "[");
            ampersands.Add("&#92;", "\\");
            ampersands.Add("&#93;", "]");
            ampersands.Add("&#94;", "^");
            ampersands.Add("&#95;", "_");
            ampersands.Add("&#96;", "`");
            ampersands.Add("&#97;", "a");
            ampersands.Add("&#98;", "b");
            ampersands.Add("&#99;", "c");
            ampersands.Add("&#100;", "d");
            ampersands.Add("&#101;", "e");
            ampersands.Add("&#102;", "f");
            ampersands.Add("&#103;", "g");
            ampersands.Add("&#104;", "-");
            ampersands.Add("&#105;", "i");
            ampersands.Add("&#106;", "j");
            ampersands.Add("&#107;", "k");
            ampersands.Add("&#108;", "l");
            ampersands.Add("&#109;", "m");
            ampersands.Add("&#110;", "n");
            ampersands.Add("&#111;", "o");
            ampersands.Add("&#112;", "p");
            ampersands.Add("&#113;", "q");
            ampersands.Add("&#114;", "r");
            ampersands.Add("&#115;", "s");
            ampersands.Add("&#116;", "t");
            ampersands.Add("&#117;", "u");
            ampersands.Add("&#118;", "v");
            ampersands.Add("&#119;", "w");
            ampersands.Add("&#120;", "x");
            ampersands.Add("&#121;", "y");
            ampersands.Add("&#122;", "z");
            ampersands.Add("&#123;", "{");
            ampersands.Add("&#124;", "|");
            ampersands.Add("&#125;", "}");
            ampersands.Add("&#126;", "~");
            ampersands.Add("&#161;", "¡");
            ampersands.Add("&iexcl;", "¡");
            ampersands.Add("&#160;", " ");
            ampersands.Add("&nbsp;", " ");
            ampersands.Add("&#162;", "¢");
            ampersands.Add("&cent;", "¢");
            ampersands.Add("&#163;", "£");
            ampersands.Add("&pound;", "£");
            ampersands.Add("&#164;", "¤");
            ampersands.Add("&curren;", "¤");
            ampersands.Add("&#165;", "¥");
            ampersands.Add("&yen;", "¥");
            ampersands.Add("&#166;", "¦");
            ampersands.Add("&brvbar;", "¦");
            ampersands.Add("&#167;", "§");
            ampersands.Add("&sect;", "§");
            ampersands.Add("&#168;", "¨");
            ampersands.Add("&uml;", "¨");
            ampersands.Add("&#169;", "©");
            ampersands.Add("&copy;", "©");
            ampersands.Add("&#170;", "ª");
            ampersands.Add("&ordf;", "ª");
            ampersands.Add("&#171;", "«");
            ampersands.Add("&laquo;", "«");
            ampersands.Add("&#172;", "¬");
            ampersands.Add("&not;", "¬");
            ampersands.Add("&#173;", "­ ");
            ampersands.Add("&shy;", " ");
            ampersands.Add("&#174;", "®");
            ampersands.Add("&reg;", "®");
            ampersands.Add("&#175;", "¯");
            ampersands.Add("&macr;", "¯");
            ampersands.Add("&#176;", "°");
            ampersands.Add("&deg;", "°");
            ampersands.Add("&#177;", "±");
            ampersands.Add("&plusmn;", "±");
            ampersands.Add("&#178;", "²");
            ampersands.Add("&sup2;", "²");
            ampersands.Add("&#179;", "³");
            ampersands.Add("&sup3;", "³");
            ampersands.Add("&#180;", "´");
            ampersands.Add("&acute;", "´");
            ampersands.Add("&#181;", "µ");
            ampersands.Add("&micro;", "µ");
            ampersands.Add("&#182;", "¶");
            ampersands.Add("&para;", "¶");
            ampersands.Add("&#183;", "·");
            ampersands.Add("&middot;", "·");
            ampersands.Add("&#184;", "¸");
            ampersands.Add("&cedil;", "¸");
            ampersands.Add("&#185;", "¹");
            ampersands.Add("&sup1;", "¹");
            ampersands.Add("&#186;", "º");
            ampersands.Add("&ordm;", "º");
            ampersands.Add("&#187;", "»");
            ampersands.Add("&raquo;", "»");
            ampersands.Add("&#188;", "¼");
            ampersands.Add("&frac14;", "¼");
            ampersands.Add("&#189;", "½");
            ampersands.Add("&frac12;", "½");
            ampersands.Add("&#190;", "¾");
            ampersands.Add("&frac34;", "¾");
            ampersands.Add("&#191;", "¿");
            ampersands.Add("&iquest;", "¿");
            ampersands.Add("&#192;", "À");
            ampersands.Add("&Agrave;", "À");
            ampersands.Add("&#193;", "Á");
            ampersands.Add("&Aacute;", "Á");
            ampersands.Add("&#194;", "Â");
            ampersands.Add("&Acirc;", "Â");
            ampersands.Add("&#195;", "Ã");
            ampersands.Add("&Atilde;", "Ã");
            ampersands.Add("&#196;", "Ä");
            ampersands.Add("&Auml;", "Ä");
            ampersands.Add("&#197;", "Å");
            ampersands.Add("&Aring;", "Å");
            ampersands.Add("&#198;", "Æ");
            ampersands.Add("&AElig;", "Æ");
            ampersands.Add("&#199;", "Ç");
            ampersands.Add("&Ccedil;", "Ç");
            ampersands.Add("&#200;", "È");
            ampersands.Add("&Egrave;", "È");
            ampersands.Add("&#201;", "É");
            ampersands.Add("&Eacute;", "É");
            ampersands.Add("&#202;", "Ê");
            ampersands.Add("&Ecirc;", "Ê");
            ampersands.Add("&#203;", "Ë");
            ampersands.Add("&Euml;", "Ë");
            ampersands.Add("&#204;", "Ì");
            ampersands.Add("&Igrave;", "Ì");
            ampersands.Add("&#205;", "Í");
            ampersands.Add("&Iacute;", "Í");
            ampersands.Add("&#206;", "Î");
            ampersands.Add("&Icirc;", "Î");
            ampersands.Add("&#207;", "Ï");
            ampersands.Add("&Iuml;", "Ï");
            ampersands.Add("&#208;", "Ð");
            ampersands.Add("&ETH;", "Ð");
            ampersands.Add("&#209;", "Ñ");
            ampersands.Add("&Ntilde;", "Ñ");
            ampersands.Add("&#210;", "Ò");
            ampersands.Add("&Ograve;", "Ò");
            ampersands.Add("&#211;", "Ó");
            ampersands.Add("&Oacute;", "Ó");
            ampersands.Add("&#212;", "Ô");
            ampersands.Add("&Ocirc;", "Ô");
            ampersands.Add("&#213;", "Õ");
            ampersands.Add("&Otilde;", "Õ");
            ampersands.Add("&#214;", "Ö");
            ampersands.Add("&Ouml;", "Ö");
            ampersands.Add("&#215;", "×");
            ampersands.Add("&times;", "×");
            ampersands.Add("&#216;", "Ø");
            ampersands.Add("&Oslash;", "Ø");
            ampersands.Add("&#217;", "Ù");
            ampersands.Add("&Ugrave;", "Ù");
            ampersands.Add("&#218;", "Ú");
            ampersands.Add("&Uacute;", "Ú");
            ampersands.Add("&#219;", "Û");
            ampersands.Add("&Ucirc;", "Û");
            ampersands.Add("&#220;", "Ü");
            ampersands.Add("&Uuml;", "Ü");
            ampersands.Add("&#221;", "Ý");
            ampersands.Add("&Yacute;", "Ý");
            ampersands.Add("&#222;", "Þ");
            ampersands.Add("&THORN;", "Þ");
            ampersands.Add("&#223;", "ß");
            ampersands.Add("&szlig;", "ß");
            ampersands.Add("&#224;", "à");
            ampersands.Add("&agrave;", "à");
            ampersands.Add("&#225;", "á");
            ampersands.Add("&aacute;", "á");
            ampersands.Add("&#226;", "â");
            ampersands.Add("&acirc;", "â");
            ampersands.Add("&#227;", "ã");
            ampersands.Add("&atilde;", "ã");
            ampersands.Add("&#228;", "ä");
            ampersands.Add("&auml;", "ä");
            ampersands.Add("&#229;", "å");
            ampersands.Add("&aring;", "å");
            ampersands.Add("&#230;", "æ");
            ampersands.Add("&aelig;", "æ");
            ampersands.Add("&#231;", "ç");
            ampersands.Add("&ccedil;", "ç");
            ampersands.Add("&#232;", "è");
            ampersands.Add("&egrave;", "è");
            ampersands.Add("&#233;", "é");
            ampersands.Add("&eacute;", "é");
            ampersands.Add("&#234;", "ê");
            ampersands.Add("&ecirc;", "ê");
            ampersands.Add("&#235;", "ë");
            ampersands.Add("&euml;", "ë");
            ampersands.Add("&#236;", "ì");
            ampersands.Add("&igrave;", "ì");
            ampersands.Add("&#237;", "í");
            ampersands.Add("&iacute;", "í");
            ampersands.Add("&#238;", "î");
            ampersands.Add("&icirc;", "î");
            ampersands.Add("&#239;", "ï");
            ampersands.Add("&iuml;", "ï");
            ampersands.Add("&#240;", "ð");
            ampersands.Add("&eth;", "ð");
            ampersands.Add("&#241;", "ñ");
            ampersands.Add("&ntilde;", "ñ");
            ampersands.Add("&#242;", "ò");
            ampersands.Add("&ograve;", "ò");
            ampersands.Add("&#243;", "ó");
            ampersands.Add("&oacute;", "ó");
            ampersands.Add("&#244;", "ô");
            ampersands.Add("&ocirc;", "ô");
            ampersands.Add("&#245;", "õ");
            ampersands.Add("&otilde;", "õ");
            ampersands.Add("&#246;", "ö");
            ampersands.Add("&ouml;", "ö");
            ampersands.Add("&#247;", "÷");
            ampersands.Add("&divide;", "÷");
            ampersands.Add("&#248;", "ø");
            ampersands.Add("&oslash;", "ø");
            ampersands.Add("&#249;", "ù");
            ampersands.Add("&ugrave;", "ù");
            ampersands.Add("&#250;", "ú");
            ampersands.Add("&uacute;", "ú");
            ampersands.Add("&#251;", "û");
            ampersands.Add("&ucirc;", "û");
            ampersands.Add("&#252;", "ü");
            ampersands.Add("&uuml;", "ü");
            ampersands.Add("&#253;", "ý");
            ampersands.Add("&yacute;", "ý");
            ampersands.Add("&#254;", "þ");
            ampersands.Add("&thorn;", "þ");
            ampersands.Add("&#255;", "ÿ");
            ampersands.Add("&yuml;", "ÿ");

            ampersands.Add("&hyphen;", "‐");
            ampersands.Add("&dash;", "‐");
            ampersands.Add("&ndash;", "–");
            ampersands.Add("&mdash;", "—");
            ampersands.Add("&horbar;", "―");

            #endregion

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
            //tbURL.Text = "https://bike18.ru/products/maslyanij-filjtr-hf151";
            //tbURL.Text = "https://bike18.ru/products/snegohod-shihan-d-2-d-2e";
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
            tbHistory.Clear();
            string template = Properties.Settings.Default.template.ToString();
            Properties.Settings.Default.login = tbLogin.Text;
            Properties.Settings.Default.password = tbPassword.Text;
            Properties.Settings.Default.template = template;
            Properties.Settings.Default.Save();
            File.Delete("errorFiles.txt");

            chpuCheked = chbCHPU.Checked;

            CookieDictionary cookie = nethouse.CookieNethouse(tbLogin.Text, tbPassword.Text, false);

            if (cookie.Count != 10)
            {
                MessageBox.Show("Логин или пароль введены не верно!");
                return;
            }
            if (tbURL.Lines.Length == 0 && urls.Count == 0)
            {
                MessageBox.Show("Заполните адрес раздела для работы на сайте");
                return;
            }
            tbHistory.AppendText("Логин и пароль введен верно\n");

            if (rbString.Checked)
                urls.Add(tbURL.Lines[0].ToString());

            foreach (string str in urls)
            {
                if (loadCategoriesCheked && str.Contains("/category"))
                {
                    UpdateCategory(cookie, str);
                }
                else
                {
                    product = new Product(cookie, str);

                    if (product.Article != "")
                        updateText(cookie, product);
                    else
                    {
                        otv = webRequest.getRequest(str + "?page=all");
                        MatchCollection categoryUrl = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                        MatchCollection tovarUrl = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);

                        if (tovarUrl.Count != 0)
                        {
                            for (int z = 0; tovarUrl.Count > z; z++)
                            {
                                string tovar = tovarUrl[z].ToString();
                                updateText(cookie, product);
                            }
                        }

                        if (categoryUrl.Count != 0)
                        {
                            for (int i = 0; categoryUrl.Count > i; i++)
                            {
                                otv = webRequest.getRequest(categoryUrl[i].ToString() + "?page=all");
                                MatchCollection category2Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                MatchCollection tovar2Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                if (tovar2Url.Count != 0)
                                {
                                    for (int z = 0; tovar2Url.Count > z; z++)
                                    {
                                        string tovar = tovar2Url[z].ToString();
                                        updateText(cookie, product);
                                    }
                                }
                                else
                                {
                                    for (int x = 0; category2Url.Count > x; x++)
                                    {
                                        otv = webRequest.getRequest(category2Url[i].ToString() + "?page=all");
                                        MatchCollection category3Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                        MatchCollection tovar3Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                        if (tovar3Url.Count != 0)
                                        {
                                            for (int z = 0; tovar3Url.Count > z; z++)
                                            {
                                                string tovar = tovar3Url[z].ToString();
                                                updateText(cookie, product);
                                            }
                                        }
                                        else
                                        {
                                            for (int m = 0; category3Url.Count > m; m++)
                                            {
                                                otv = webRequest.getRequest(category3Url[m].ToString() + "?page=all");
                                                MatchCollection category4Url = new Regex("(?<=<div class=\"category-capt-txt -text-center\"><a href=\").*?(?=\" class=\"blue\">)").Matches(otv);
                                                MatchCollection tovar4Url = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*?(?=\" >)").Matches(otv);
                                                if (tovar4Url.Count != 0)
                                                {
                                                    for (int z = 0; tovar4Url.Count > z; z++)
                                                    {
                                                        string tovar = tovar4Url[z].ToString();
                                                        updateText(cookie, product);
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

            if (okMessageBox == DialogResult.OK)
            {
                if (errLengthMiniText)
                    Process.Start("C:\\Windows\\System32\\notepad.exe", "errorFiles.txt");
            }
            tbHistory.AppendText("Обновление карточки закончено\n");
        }

        private void UpdateCategory(CookieDictionary cookie, string str)
        {
            tbHistory.AppendText("Получения карточки раздела\n");
            string idCategory = new Regex("(?<=category/).*").Match(str).ToString();

            otv = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/category?id=" + idCategory);

            otv = utfChar(otv);

            string parentId = new Regex("(?<=parent_id\":).*(?=,)").Match(otv).ToString().Trim();
            string name = new Regex("(?<=name\": \").*(?=\")").Match(otv).ToString().Trim();
            string slug = new Regex("(?<=slug\": \").*(?=\")").Match(otv).ToString().Trim();
            string description = new Regex("(?<=description\": \").*(?=\")").Match(otv).ToString().Trim();
            string priority = new Regex("(?<=priority\": ).*(?=,)").Match(otv).ToString().Trim();
            string visible = new Regex("(?<=visible\": ).*(?=,)").Match(otv).ToString().Trim();
            string showOnMain = new Regex("(?<=showOnMain\": ).*(?=,)").Match(otv).ToString().Trim();
            string contentType = new Regex("(?<=content_type\":).*(?=,)").Match(otv).ToString().Trim();
            string productsCount = new Regex("(?<=productsCount\": ).*(?=,)").Match(otv).ToString().Trim();
            string productsCountAll = new Regex("(?<=productsCountAll\": ).*(?=,)").Match(otv).ToString().Trim();
            string level = new Regex("(?<=level\": ).*(?=,)").Match(otv).ToString().Trim();
            string seoMetaDesc = new Regex("(?<=seoMetaDesc\": \").*(?=\")").Match(otv).ToString().Trim();
            string seoMetaKeywords = new Regex("(?<=seoMetaKeywords\": \").*(?=\")").Match(otv).ToString().Trim();
            string seoTitle = new Regex("(?<=seoTitle\": \").*(?=\")").Match(otv).ToString().Trim();

            otv = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/categorymedia?id=" + idCategory);
            otv = utfChar(otv);

            string avatarId = new Regex("(?<=\"id\":).*(?=,)").Match(otv).ToString().Trim();
            string avatarTimesap = new Regex("(?<=timestamp\":).*(?=,)").Match(otv).ToString().Trim();
            string avatarType = new Regex("(?<=type\":).*(?=,)").Match(otv).ToString().Trim();
            string avatarName = new Regex("(?<=name\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarDesc = new Regex("(?<=desc\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarExt = new Regex("(?<=ext\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarFormatsRaw = new Regex("(?<=raw\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarw215 = new Regex("(?<=W215\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarw150 = new Regex("(?<=150x120\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatar104 = new Regex("(?<=104x82\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatar156 = new Regex("(?<=156x120\":\").*(?=\")").Match(otv).ToString().Trim();
            string avatarFileSize = new Regex("(?<=fileSize\":).*?(?=})").Match(otv).ToString().Trim();
            string avatarParamw215 = new Regex("(?<=W215\":{).*?(?=})").Match(otv).ToString().Trim();
            string avatarParam150 = new Regex("(?<=150x120\":{).*?(?=})").Match(otv).ToString().Trim();
            string avatarParam104 = new Regex("(?<=104x82\":{).*?(?=})").Match(otv).ToString().Trim();
            string avatarParam156 = new Regex("(?<=156x120\":{)[\\w\\W]*(?=})").Match(otv).ToString().Trim();
            string avatarFileSizeImg = new Regex("(?<=fileSize\":).*?(?=}})").Match(otv).ToString().Trim();
            string avatarAlt = new Regex("(?<=alt\":\").*?(?=\")").Match(otv).ToString().Trim();
            string avatarVisibleOnMan = new Regex("(?<=isVisibleOnMain\":).*?(?=,)").Match(otv).ToString().Trim();
            string avatarPriority = new Regex("(?<=priority\":).*?(?=,)").Match(otv).ToString().Trim();
            string avatarURL = new Regex("(?<=url\":).*?(?=,)").Match(otv).ToString().Trim();
            string avatarFiltrs = new Regex("(?<=filters\":{).*?(?=})").Match(otv).ToString().Trim();

            string newSlug = chpu.vozvr(name);
            if (slug == newSlug)
            {
                nethouse.Redirect(cookie, slug, newSlug);
            }
            slug = newSlug;

            string strRequest = String.Format("id={0}&name={1}&avatar[id]={2}&avatar[objectId]={3}&avatar[timestamp]={4}&avatar[type]={5}&avatar[name]={6}&avatar[desc]={7}&avatar[ext]={8}&avatar[formats][raw]={9}&avatar[formats][W215]={10}&avatar[formats][150x120]={11}&avatar[formats][104x82]={12}&avatar[formats][156x120]={13}&avatar[formatParams][raw][fileSize]={14}&avatar[formatParams][156x120][fileSize]={15}&avatar[alt]={16}&avatar[isVisibleOnMain]={17}&avatar[priority]={18}&avatar[url]={19}&slug={20}&seoMetaDesc={21}&seoMetaKeywords={22}&priority={23}&showOnMain={24}&categoryId={25}&isVisible={26}&desc={27}",
                idCategory, name, avatarId, idCategory, avatarTimesap, avatarType, avatarName, avatarDesc, avatarExt, avatarFormatsRaw, avatarw215, avatarw150, avatar104, avatar156, avatarFileSize, avatarParamw215, avatarAlt, avatarVisibleOnMan, avatarPriority, avatarURL, slug, seoMetaDesc, seoMetaKeywords, priority, showOnMain, parentId, visible, description);

            nethouse.PostRequest(cookie, "https://bike18.nethouse.ru/api/catalog/savecategory", strRequest);

            tbHistory.AppendText("Обновление карточки раздела\n");

            if (otv.Contains("errors"))
            {

            }
        }

        private void updateText(CookieDictionary cookie, Product product)
        {
            err = false;
            errLengthMiniText = false;
            string response = "";

            if (chbTitle.Checked)
                product.SeoTitle = seoTitle(product);

            if (chbDescription.Checked)
                product.SeoDescription = seoDescription(product);

            if (chbKeywords.Checked)
                product.SeoKeywords = seoKeywords(product);

            if (chbFullText.Checked)
            {
                if (chbReplaceFullText.Checked)
                    product.DescriptionFull = full_Text_tovar(product);
                else
                {
                    string fullText = product.DescriptionFull;
                    fullText = DeleteSimbols(fullText);
                    int i = fullText.LastIndexOf("<p><br /></p>");
                    int length = fullText.Length - 13;
                    if (i == length)
                        fullText = fullText.Remove(i);
                    fullText += full_Text_tovar(product);
                    product.DescriptionFull = fullText;
                }
            }

            if (chbMiniText.Checked)
            {
                if (chbReplaceMiniText.Checked)
                    product.Description = mini_Text_tovar(product);
                else
                {
                    string miniText = product.Description;
                    miniText = DeleteSimbols(miniText);
                    int n = miniText.LastIndexOf("<p><br /></p>");
                    int length = miniText.Length - 13;
                    if (n == length)
                        miniText = miniText.Remove(n);
                    miniText += mini_Text_tovar(product);

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
                        sw.WriteLine("тут должна быть ссылка");
                        sw.Close();
                    }

                    product.Description = autoCrop(miniText, 16000);
                }
            }

            if (chbAltText.Checked)
            {
                altText(cookie, product);
            }

            if (chbAlsoBuy.Checked)
                product.alsoByUpdate();

            if (chpuCheked)
            {
                if (product.Slug != "")
                {
                    nethouse.Redirect(cookie, product.Slug, slug(product));
                }
                product.Slug = slug(product);
            }

            if (!errLengthMiniText)
            {
                tbHistory.AppendText("Обновление карточки товара\n");
                product = ReplaceAmpersChar(product);
                response = product.save(cookie);
                }

            if (response.Contains("errors"))
            {
                tbHistory.AppendText("Во время сохранения произошла ошибка\n");
                err = true;
                int g = 1;
                if (response.Contains("slug"))
                {
                    tbHistory.AppendText("Ошибка возникла с чпу, пытаюсь ее исправить\n");
                    Random rnd = new Random();
                    do
                    {
                        string s = product.Slug;
                        s = s.Remove(s.Length - 1, 1);
                        //Создание объекта для генерации чисел
                       
                        //Получить случайное число (в диапазоне от 0 до 10)
                        int value = rnd.Next(0, 100);
                        s = s + value;
                        g++;
                        product.Slug = s;
                        response = product.save(cookie);
                        err = false;
                    }
                    while (response.Contains("errors"));
                }
            }
        }

        private Product ReplaceAmpersChar(Product product)
        {
            product.Description = ampersChar(product.Description);
            product.DescriptionFull = ampersChar(product.DescriptionFull);
            product.SeoDescription = ampersChar(product.SeoDescription);
            product.SeoTitle = ampersChar(product.SeoTitle);
            product.SeoKeywords = ampersChar(product.SeoKeywords);
            return product;
        }

        private void RedirectURLProduct(CookieDictionary cookie, string oldCHPU, string newCHPU)
        {
            nethouse.Redirect(cookie, oldCHPU, newCHPU);
        }

        private string DeleteSimbols(string text)
        {
            text = text.Replace("&", "").Replace("  ", " ");
            return text;
        }

        private string slug(Product product)
        {
            string str = product.Name;
            if (chbUrlArticle.Checked)
            {
                string chpuArticle = chpu.vozvr(product.Article);
                str = chpu.vozvr(str) + "-" + chpuArticle;
            }
            else
                str = chpu.vozvr(str);

            str = str.Replace("[", "").Replace("]", "").Replace("#", "");

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
        private string seoKeywords(Product product)
        {
            string seoKeywordsText = tbKeywords.Lines[0];
            seoKeywordsText = AutoCorrect(seoKeywordsText, "seo", product);
            seoKeywordsText = autoCrop(seoKeywordsText, 100);
            return seoKeywordsText;
        }

        private string seoDescription(Product product)
        {
            string seoDescriptionText = tbDescription.Lines[0];
            seoDescriptionText = AutoCorrect(seoDescriptionText, "seo", product);
            seoDescriptionText = autoCrop(seoDescriptionText, 200);
            return seoDescriptionText;
        }

        private string seoTitle(Product product)
        {
            string seoTitleText = tbTitle.Lines[0];
            seoTitleText = AutoCorrect(seoTitleText, "seo", product);
            seoTitleText = autoCrop(seoTitleText, 200);
            return seoTitleText;
        }

        private string mini_Text_tovar(Product product)
        {
            string miniText = miniTextTemplate();
            miniText = AutoCorrect(miniText, "", product);
            miniText = autoCrop(miniText, 10000);
            return miniText;
        }

        private string full_Text_tovar(Product product)
        {
            string fullText = fullTextTemplate();
            fullText = AutoCorrect(fullText, "", product);
            return fullText;
        }

        private void altText(CookieDictionary cookie, Product product)
        {
            List<string> imagesId = product.ReturnImagesId(cookie, product);
            string altText = "";
            if (imagesId.Count > 0)
            {
                foreach (string str in imagesId)
                {
                    altText = returnAltText();
                    altText = AutoCorrect(altText, "seo", product);
                    nethouse.loadAltTextImage(cookie, str, altText);
                }
            }
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
                        MatchCollection urlstrings = new Regex("<ссылка.*?</ссылка>").Matches(str);
                        foreach (var urlstring in urlstrings)
                        {
                            string urlStr = urlstring.ToString();
                            string text = new Regex("(?<=\">).*?(?=</ссылка>)").Match(urlStr).ToString();
                            string url = new Regex("(?<==\").*?(?=\">)").Match(urlStr).ToString();
                            string newString = "<a href=\"" + url + "\">" + text + "</a>";
                            str = str.Replace(urlStr, newString);
                        }
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

        public string AutoCorrect(string text, string descriptionCartTovar, Product product)
        {
            string name = product.Name;
            string price = product.Coast;
            string articl = product.Article;

            string category1 = "";
            string category2 = "";

            MatchCollection categories = product.Categories;
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
                name = boldOpen + name + boldClose;
                price = boldOpen + price + boldClose;
                articl = boldOpen + articl + boldClose;
                category1 = boldOpen + category1 + boldClose;
                category2 = boldOpen + category2 + boldClose;
            }
            if (text == null)
                return text = "";
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
                    for (int i = 0; miniText.Length > i; i++)
                    {
                        string str = miniText[i];
                        if (miniText.Length - 1 == i)
                            rtbMiniText.AppendText(str);
                        else
                            rtbMiniText.AppendText(str + "\n");
                    }

                    string fullTextString = templateString[1].ToString().Replace("\\r\\n", "†");
                    fullTextString = fullTextString.TrimEnd('†');
                    string[] fullText = fullTextString.Split('†');
                    for (int i = 0; fullText.Length > i; i++)
                    {
                        string str = fullText[i];
                        if (fullText.Length - 1 == i)
                            rtbFullText.AppendText(str);
                        else
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
        private string ampersChar(string text)
        {
            if (text == null)
                return text = "";
            foreach (KeyValuePair<string, string> pair in ampersands)
            {
                text = text.Replace(pair.Key, pair.Value);
            }
            text = WebUtility.HtmlDecode(text);
            text = text.Replace("&", " ");
            return text;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработка программы: al-metal\ne-mail: al-metal@bk.ru\n\n\n" +
                "Изменения в программе:\n" +
                "16.04.2017 Обработка всех товаров в разделе\n" +
                "08.06.2017 Корректная обработка артикула товара\n" +
                "26.06.2017 Убраны лишние пробелы и переносы строк в шаблоне\n" +
                "05.07.2017 Удаление неликвидных символов\n" +
                "16.07.2017 Обработка html тэгов\n" +
                "16.07.2017 Добавление редиректа при смене ЧПУ\n" +
                "26.07.2017 Обработка спецсимволов на всей карточке товара\n" +
                "08.08.2017 Обработка разделов из списка\n" +
                "10.08.2017 Настройка под новый шаблон\n" +
                "22.08.2017 Исправление ошибок при работе с товарами\n" +
                "25.08.2017 Восстановил работу с параметрами. Исправил ссылки в редакторе шаблона\n" +
                "28.08.2017 Актуальная цена и скидки\n" +
                "05.09.2017 Дополнительно убрал html - символы\n" +
                "07.09.2017 Обработка ссылок в шаблоне\n" +
                "15.09.2017 Обновление модуля работы с альт. текстами\n" +
                "25.09.2017 Спецсимволы в названии\n" +
                "20.10.2017 Доработан метод \"С этим товаром покупают\"\n" +
                "01.11.2019 Исправления под новый nethouse\n", "Изменения в программе");
        }

        private void btnLoadURLs_Click(object sender, EventArgs e)
        {
            ofdLoadURLs.ShowDialog();

            string fileUrls = ofdLoadURLs.FileName.ToString();
            loadCategoriesCheked = cbCategories.Checked;

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
                        string url = w.Cells[i, 1].Value.ToString();
                        if (url != null)
                        {
                            if (url.Contains("category") /*|| !url.Contains("products/") */&& !loadCategoriesCheked)
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
                cbCategories.Visible = false;
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
                cbCategories.Visible = true;
                lblUrlAllCount.Visible = true;
                lblUrlCount.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                tbURL.Enabled = false;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private string utfChar(string text)
        {
            text = Regex.Replace(text, @"\\u([0-9A-Fa-f]{4})", m => "" + (char)Convert.ToInt32(m.Groups[1].Value, 16));

            return text;
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }
    }
}
