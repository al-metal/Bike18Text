﻿using Bike18Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web
{
    class WebRequest
    {
        

        public string getRequestEncod(string url)
        {
            HttpWebResponse res = null;
            HttpWebRequest req = (HttpWebRequest)System.Net.WebRequest.Create(url);
            req.Proxy = null;
            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            res = (HttpWebResponse)req.GetResponse();
            StreamReader ressr = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding(1251));
            String otv = ressr.ReadToEnd();
            res.Close();

            return otv;
        }

        public string getRequest(string url)
        {
            HttpWebResponse res = null;
            HttpWebRequest req = (HttpWebRequest)System.Net.WebRequest.Create(url);
            req.Proxy = null;
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            res = (HttpWebResponse)req.GetResponse();
            StreamReader ressr = new StreamReader(res.GetResponseStream());
            string otv = ressr.ReadToEnd();
            res.GetResponseStream().Close();
            req.GetResponse().Close();
            res.Close();

            return otv;
        }

        public string PostRequest(CookieContainer cookie, string nethouseTovar)
        {
            string otv = null;

                HttpWebResponse res = null;

                HttpWebRequest req = (HttpWebRequest)System.Net.WebRequest.Create(nethouseTovar);
                req.Proxy = null;
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.CookieContainer = cookie;
                    res = (HttpWebResponse)req.GetResponse();
                    StreamReader ressr = new StreamReader(res.GetResponseStream());
                    otv = ressr.ReadToEnd();
            res.Close();
            return otv;
        }


        public CookieContainer webCookieBike18()
        {
            Form1 form = new Form1();
            string login = form.textLogin;
            string pass = form.textPass;
            CookieContainer cooc = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://nethouse.ru/signin");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cooc;
            byte[] ms = Encoding.ASCII.GetBytes("login=" + login + "&password=" + pass + "&quick_expire=0&submit=%D0%92%D0%BE%D0%B9%D1%82%D0%B8");
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return cooc;
        }

        public CookieContainer webCookie(string url)
        {
            CookieContainer cooc = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cooc;
            Stream stre = req.GetRequestStream();
            stre.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return cooc;
        }

        public CookieContainer webCookievk()
        {
            CookieContainer cooc = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://oauth.vk.com/authorize?client_id=5464980&display=popup&redirect_uri=http://api.vk.com/blank.html&scope=market,photos&response_type=token&v=5.52");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cooc;
            Stream stre = req.GetRequestStream();
            stre.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return cooc;
        }


        

        internal int price(double priceTovarRacerMotors, double discount)
        {
            priceTovarRacerMotors = priceTovarRacerMotors - (priceTovarRacerMotors * discount);
            priceTovarRacerMotors = Math.Round(priceTovarRacerMotors);
            int price = Convert.ToInt32(priceTovarRacerMotors);
            price = (price / 10) * 10;
            return price;
        }

        internal List<string> arraySaveimage(string urlTovar)
        {
            WebRequest webRequest = new WebRequest();
            CookieContainer cookie = webRequest.webCookieBike18();
            List <string> saveImage = new List<string>();

            string otv = webRequest.PostRequest(cookie, urlTovar);
            if (otv != null)
            {
                string productId = new Regex("(?<=<section class=\"comment\" id=\").*?(?=\">)").Match(otv).ToString();
                String article = new Regex("(?<=Артикул:)[\\w\\W]*(?=</div><div><div class)").Match(otv).Value.Trim();
                if (article.Length > 11)
                {
                    article = new Regex("(?<=Артикул:)[\\w\\W]*(?=</title>)").Match(otv).ToString().Trim();
                }
                String prodName = new Regex("(?<=<h1>).*(?=</h1>)").Match(otv).Value;
                String price = new Regex("(?<=<span class=\"product-price-data\" data-cost=\").*?(?=\">)").Match(otv).Value;
                String imgId = new Regex("(?<=<div id=\"avatar-).*(?=\")").Match(otv).Value;
                String desc = new Regex("(?<=<div class=\"user-inner\">).*?(?=</div>)").Match(otv).Value;
                String fulldesc = new Regex("(?<=<div id=\"product-full-desc\" data-ng-non-bindable class=\"user-inner\">).*?(?=</div>)").Match(otv).Value.Replace("&nbsp;&nbsp;", " ").Replace("&deg;", "°");
                String seometa = new Regex("(?<=<meta name=\"description\" content=\").*?(?=\" >)").Match(otv).Value;
                String keywords = new Regex("(?<=<meta name=\"keywords\" content=\").*?(?=\" >)").Match(otv).Value;
                String title = new Regex("(?<=<title>).*?(?=</title>)").Match(otv).Value;
                String visible = new Regex("(?<=,\"balance\":).*?(?=,\")").Match(otv).Value;
                string reklama = new Regex("(?<=<div class=\"marker-icon size-big type-4\"><div class=\"left\"></div><div class=\"center\"><div class=\"text\">).*?(?=</div></div>)").Match(otv).ToString();
                    if(reklama == "акция")
                {
                    reklama = "&markers[3]=1";
                }
                if (reklama == "новинка")
                {
                    reklama = "&markers[1]=1";
                }

                otv = webRequest.PostRequest(cookie, "http://bike18.nethouse.ru/api/catalog/getproduct?id=" + productId);
                string slug = new Regex("(?<=\",\"slug\":\").*?(?=\")").Match(otv).ToString();
                string productCastomGroup = new Regex("(?<=productCustomGroup\":).*?(?=,\")").Match(otv).ToString();
                String discountCoast = new Regex("(?<=discountCost\":\").*?(?=\")").Match(otv).Value;
                String serial = new Regex("(?<=serial\":\").*?(?=\")").Match(otv).Value;
                String categoryId = new Regex("(?<=\",\"categoryId\":\").*?(?=\")").Match(otv).Value;
                String productGroup = new Regex("(?<=productGroup\":).*?(?=,\")").Match(otv).Value;
                String havenDetail = new Regex("(?<=haveDetail\".).*?(?=,\")").Match(otv).Value;
                String canMakeOrder = new Regex("(?<=canMakeOrder\".).*?(?=,\")").Match(otv).Value;
                canMakeOrder = canMakeOrder.Replace("false", "0");
                canMakeOrder = canMakeOrder.Replace("true", "1");
                //String balance = new Regex("(?<=,\"balance\":).*?(?=,\")").Match(otv).ToString();
                String showOnMain = new Regex("(?<=showOnMain\".).*?(?=,\")").Match(otv).Value;
                String customDays = new Regex("(?<=,\"customDays\":\").*?(?=\")").Match(otv).Value;
                String isCustom = new Regex("(?<=\",\"isCustom\":).*?(?=,)").Match(otv).Value;
                string atribut = "";
                string atributes = new Regex("(?<=attributes\":{\").*?(?=,\"customDays)").Match(otv).Value;
                MatchCollection stringAtributes = new Regex("(?<=\":{\").*?(?=])").Matches(atributes);
                for(int i = 0; stringAtributes.Count > i; i++)
                {
                    string id = new Regex("(?<=primaryKey\":).*?(?=,\")").Match(stringAtributes[i].ToString()).Value;
                    string valueId = new Regex("(?<=\"valueId\":\").*?(?=\")").Match(stringAtributes[i].ToString()).Value;
                    string valueText = new Regex("(?<=valueText\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;
                    string text = new Regex("(?<=\"text\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;
                    string checkBox = new Regex("(?<=checkbox\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;

                    if (valueId != "")
                    {
                        atribut = atribut + "&attributes[" + i + "][primaryKey]=" + id + "&attributes[" + i + "][attributeId]=" + id + "&attributes[" + i + "][values][0][empty]=0&attributes[" + i + "][values][0][valueId]=" + valueId;
                    }
                    else
                    {
                        if(text != "")
                            atribut = atribut + "&attributes[" + i + "][primaryKey]=" + id + "&attributes[" + i + "][attributeId]=" + id + "&attributes[" + i + "][values][0][empty]=0&attributes[" + i + "][values][0][text]=" + text;
                        if(checkBox != "")
                            atribut = atribut + "&attributes[" + i + "][primaryKey]=" + id + "&attributes[" + i + "][attributeId]=" + id + "&attributes[" + i + "][values][0][empty]=0&attributes[" + i + "][values][0][checkbox]=" + checkBox;
                    }
                }
                atribut = atribut.Replace("true", "1");
                string alsoBuy = new Regex("(?<=alsoBuy\":).*?(?=,\"markers)").Match(otv).ToString();
                alsoBuy = alsoBuy.Remove(alsoBuy.Length - 1, 1).Remove(0, 1);
                string[] alsoBuyArray = alsoBuy.Split(',');
                string alsoBuyStr = "";

                if (alsoBuyArray.Length > 0)
                {
                    for (int i = 0; alsoBuyArray.Length > i; i++)
                    {
                        alsoBuyStr += "&alsoBuy[" + i + "]=" + alsoBuyArray[i].ToString();
                    }
                }

                otv = webRequest.PostRequest(cookie, "http://bike18.nethouse.ru/api/catalog/productmedia?id=" + productId);
                String avatarId = new Regex("(?<=\"id\":\").*?(?=\")").Match(otv).Value;
                String objektId = new Regex("(?<=\"objectId\":\").*?(?=\")").Match(otv).Value;
                String timestamp = new Regex("(?<=\"timestamp\":\").*?(?=\")").Match(otv).Value;
                String type = new Regex("(?<=\"type\":\").*?(?=\")").Match(otv).Value;
                String name = new Regex("(?<=\",\"name\":\").*?(?=\")").Match(otv).Value;
                String descimg = new Regex("(?<=\"desc\":\").*?(?=\")").Match(otv).Value;
                String ext = new Regex("(?<=\"ext\":\").*?(?=\")").Match(otv).Value;
                String raw = new Regex("(?<=\"raw\":\").*?(?=\")").Match(otv).Value;
                String W215 = new Regex("(?<=\"W215\":\").*?(?=\")").Match(otv).Value;
                String srimg = new Regex("(?<=\"150x120\":\").*?(?=\")").Match(otv).Value;
                String minimg = new Regex("(?<=\"104x82\":\").*?(?=\")").Match(otv).Value;
                String filesize = new Regex("(?<=\"fileSize\":).*?(?=})").Match(otv).Value;
                String alt = new Regex("(?<=\"alt\":\").*?(?=\")").Match(otv).Value;
                String isvisibleonmain = new Regex("(?<=\"isVisibleOnMain\".).*?(?=,)").Match(otv).Value;
                String prioriti = new Regex("(?<=\"priority\":\").*?(?=\")").Match(otv).Value;
                String avatarurl = new Regex("(?<=\"url\":\").*?(?=\")").Match(otv).Value;
                String filtersleft = new Regex("(?<=\"left\":).*?(?=,)").Match(otv).Value;
                String filterstop = new Regex("(?<=\"top\":).*?(?=,)").Match(otv).Value;
                String filtersright = new Regex("(?<=\"right\":).*?(?=,)").Match(otv).Value;
                String filtersbottom = new Regex("(?<=\"bottom\":).*?(?=})").Match(otv).Value;

                saveImage.Add(productId);       //0
                saveImage.Add(slug);            //1
                saveImage.Add(categoryId);      //2
                saveImage.Add(productGroup);    //3
                saveImage.Add(prodName);        //4
                saveImage.Add(serial);          //5
                saveImage.Add(article);         //6
                saveImage.Add(desc);            //7
                saveImage.Add(fulldesc);        //8
                saveImage.Add(price);           //9
                saveImage.Add(discountCoast);   //10
                saveImage.Add(seometa);         //11
                saveImage.Add(keywords);        //12
                saveImage.Add(title);           //13
                saveImage.Add(havenDetail);     //14
                saveImage.Add(canMakeOrder);    //15 купить с сайта в 1 клик
                                                //saveImage.Add(balance);
                saveImage.Add(showOnMain);      //16
                saveImage.Add(avatarId);        //17
                saveImage.Add(objektId);        //18
                saveImage.Add(timestamp);       //19
                saveImage.Add(type);            //20
                saveImage.Add(name);            //21
                saveImage.Add(descimg);         //22
                saveImage.Add(ext);             //23
                saveImage.Add(raw);             //24
                saveImage.Add(W215);            //25
                saveImage.Add(srimg);           //26
                saveImage.Add(minimg);          //27
                saveImage.Add(filesize);        //28
                saveImage.Add(alt);             //29
                saveImage.Add(isvisibleonmain); //30
                saveImage.Add(prioriti);        //31
                saveImage.Add(avatarurl);       //32
                saveImage.Add(filtersleft);     //33
                saveImage.Add(filterstop);      //34
                saveImage.Add(filtersright);    //35
                saveImage.Add(filtersbottom);   //36
                saveImage.Add(customDays);      //37
                saveImage.Add(isCustom);        //38
                saveImage.Add(reklama);         //39
                saveImage.Add(atribut);         //40
                saveImage.Add(productCastomGroup); //41
                saveImage.Add(alsoBuyStr);      //42
            }
            return saveImage;
        }

        internal void altTextImage(List<string> tovarList, string altText)
        {
            CookieContainer cookie = webCookieBike18();
            string idImage = tovarList[17].ToString();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/images/savealt");
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = Encoding.ASCII.GetBytes("id=" + idImage +"&alt=" + altText);
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
            StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
        } // Удалить

        internal void loadAltTextImage(CookieContainer cookie, string idImg, string altText)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://bike18.nethouse.ru/api/images/savealt");
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36";
            req.Method = "POST";
            req.Proxy = null;
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = Encoding.GetEncoding("utf-8").GetBytes("id=" + idImg + "&alt=" + altText);
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
            StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
            res1.Close();
            ressr1.Close();
        }

        internal void deleteProduct(List<string> getProduct)
        {
            CookieContainer cookie = webCookieBike18();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/catalog/deleteproduct");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = System.Text.Encoding.GetEncoding("utf-8").GetBytes("id=" + getProduct[0] + "&slug=" + getProduct[1] + "&categoryId=" + getProduct[2] + "&productGroup=" + getProduct[3] + "&name=" + getProduct[4] + "&serial=" + getProduct[5] + "&serialByUser=" + getProduct[6] + "&desc=" + getProduct[7] + "&descFull=" + getProduct[8] + "&cost=" + getProduct[9] + "&discountCost=" + getProduct[10] + "&seoMetaDesc=" + getProduct[11] + "&seoMetaKeywords=" + getProduct[12] + "&seoTitle=" + getProduct[13] + "&haveDetail=" + getProduct[14] + "&canMakeOrder=" + getProduct[15] + "&balance=100&showOnMain=" + getProduct[16] + "&isVisible=1&hasSale=0&avatar[id]=" + getProduct[17] + "&avatar[objectId]=" + getProduct[18] + "&avatar[timestamp]=" + getProduct[19] + "&avatar[type]=" + getProduct[20] + "&avatar[name]=" + getProduct[21] + "&avatar[desc]=" + getProduct[22] + "&avatar[ext]=" + getProduct[23] + "&avatar[formats][raw]=" + getProduct[24] + "&avatar[formats][W215]=" + getProduct[25] + "&avatar[formats][150x120]=" + getProduct[26] + "&avatar[formats][104x82]=" + getProduct[27] + "&avatar[formatParams][raw][fileSize]=" + getProduct[28] + "&avatar[alt]=" + getProduct[29] + "&avatar[isVisibleOnMain]=" + getProduct[30] + "&avatar[priority]=" + getProduct[31] + "&avatar[url]=" + getProduct[32] + "&avatar[filters][crop][left]=" + getProduct[33] + "&avatar[filters][crop][top]=" + getProduct[34] + "&avatar[filters][crop][right]=" + getProduct[35] + "&avatar[filters][crop][bottom]=" + getProduct[36] + "&customDays=" + getProduct[37] + "&isCustom=" + getProduct[38]);
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
            StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
        }

        internal void saveImage(List<string> getProduct)
        {
            CookieContainer cookie = webCookieBike18();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/catalog/saveproduct");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            string descFull = getProduct[8].ToString();
            descFull = descFull.Replace("&laquo;", "«").Replace("&raquo;", "»");
            byte[] ms = System.Text.Encoding.GetEncoding("utf-8").GetBytes("id=" + getProduct[0] + "&slug=" + getProduct[1] + "&categoryId=" + getProduct[2] + "&productGroup=" + getProduct[3] + "&name=" + getProduct[4] + "&serial=" + getProduct[5] + "&serialByUser=" + getProduct[6] + "&desc=" + getProduct[7] + "&descFull=" + descFull + "&cost=" + getProduct[9] + "&discountCost=" + getProduct[10] + "&seoMetaDesc=" + getProduct[11] + "&seoMetaKeywords=" + getProduct[12] + "&seoTitle=" + getProduct[13] + "&haveDetail=" + getProduct[14] + "&canMakeOrder=" + getProduct[15] + "&balance=100&showOnMain=" + getProduct[16] + "&isVisible=1&hasSale=0&avatar[id]=" + getProduct[17] + "&avatar[objectId]=" + getProduct[18] + "&avatar[timestamp]=" + getProduct[19] + "&avatar[type]=" + getProduct[20] + "&avatar[name]=" + getProduct[21] + "&avatar[desc]=" + getProduct[22] + "&avatar[ext]=" + getProduct[23] + "&avatar[formats][raw]=" + getProduct[24] + "&avatar[formats][W215]=" + getProduct[25] + "&avatar[formats][150x120]=" + getProduct[26] + "&avatar[formats][104x82]=" + getProduct[27] + "&avatar[formatParams][raw][fileSize]=" + getProduct[28] + "&avatar[alt]=" + getProduct[29] + "&avatar[isVisibleOnMain]=" + getProduct[30] + "&avatar[priority]=" + getProduct[31] + "&avatar[url]=" + getProduct[32] + "&avatar[filters][crop][left]=" + getProduct[33] + "&avatar[filters][crop][top]=" + getProduct[34] + "&avatar[filters][crop][right]=" + getProduct[35] + "&avatar[filters][crop][bottom]=" + getProduct[36] + "&customDays=" + getProduct[37] + "&isCustom=" + getProduct[38] + getProduct[39] + getProduct[40] + "&alsoBuyLabel=%D0%9F%D0%BE%D1%85%D0%BE%D0%B6%D0%B8%D0%B5%20%D1%82%D0%BE%D0%B2%D0%B0%D1%80%D1%8B%20%D0%B2%20%D0%BD%D0%B0%D1%88%D0%B5%D0%BC%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D0%B5");
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            try
            {
            HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
            StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
            }
            catch
            {

            }
            }

        internal string saveTovar(List<string> getProduct)
        {
            string otv = "";
            CookieContainer cookie = webCookieBike18();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/catalog/saveproduct");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            string descFull = getProduct[8].ToString();
            descFull = descFull.Replace("&laquo;", "«").Replace("&raquo;", "»").Replace("&ndash;", "-");
            getProduct[8] = descFull;
            string request = "id=" + getProduct[0] + "&slug=" + getProduct[1] + "&categoryId=" + getProduct[2] + "&productCustomGroup=" + getProduct[41] + "&productGroup=" + getProduct[3] + "&name=" + getProduct[4] + "&serial=" + getProduct[5] + "&serialByUser=" + getProduct[6] + "&desc=" + getProduct[7] + "&descFull=" + getProduct[8] + "&cost=" + getProduct[9] + "&discountCost=" + getProduct[10] + "&seoMetaDesc=" + getProduct[11] + "&seoMetaKeywords=" + getProduct[12] + "&seoTitle=" + getProduct[13] + "&haveDetail=" + getProduct[14] + "&canMakeOrder=" + getProduct[15] + "&balance=100&showOnMain=" + getProduct[16] + "&isVisible=1&hasSale=0" + "&customDays=" + getProduct[37] + "&isCustom=" + getProduct[38] + getProduct[39] + getProduct[40] + getProduct[42] + "&alsoBuyLabel=%D0%9F%D0%BE%D1%85%D0%BE%D0%B6%D0%B8%D0%B5%20%D1%82%D0%BE%D0%B2%D0%B0%D1%80%D1%8B%20%D0%B2%20%D0%BD%D0%B0%D1%88%D0%B5%D0%BC%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D0%B5";
            request = request.Replace("false", "0").Replace("true", "1").Replace("&mdash;", "-").Replace("&laquo;", "\"").Replace("&raquo;", "\"").Replace("&mdash;", "-");

            request = request.Replace("false", "0").Replace("true", "1");
            byte[] ms = System.Text.Encoding.GetEncoding("utf-8").GetBytes(request);
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            try
            {
                HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
                StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
                otv = ressr1.ReadToEnd();
            }
            catch
            {

            }
            return otv;
        }

        internal void savePrice(CookieContainer cookie, string urlTovar, MatchCollection articl, double priceTrue, WebRequest webRequest)
        {
            string otv = webRequest.PostRequest(cookie, urlTovar);
            string productId = new Regex("(?<=<section class=\"comment\" id=\").*?(?=\">)").Match(otv).ToString();
            otv = webRequest.PostRequest(cookie, "http://bike18.nethouse.ru/api/catalog/getproduct?id=" + productId);
        }

        internal void DeleteImage(CookieContainer cookie, string productId, string objectId, string type, string name, string desc, string alt, string priority)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/images/delete");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = Encoding.GetEncoding("utf-8").GetBytes("id=" + productId + "&objectId=" + objectId + "&type=" + type + "&name=" + name + "&desc=" + desc + "&alt=" + alt + "&isVisibleOnMain=0&priority=" + priority);
            req.ContentLength = ms.Length;
            Stream stre6 = req.GetRequestStream();
            stre6.Write(ms, 0, ms.Length);
            stre6.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader ressr = new StreamReader(res.GetResponseStream());
        }

        internal string loadImage(string imgDirectory, string imgName, string startFile, string endFile)
        {
            string otv = null;
            CookieContainer coockie = new CookieContainer();
            WebRequest webRequest = new WebRequest();
            CookieContainer cookie = webRequest.webCookieBike18();

            string epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString().Replace(",", "");
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/putimg?fileapi" + epoch);
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=---------------------------12709277337355";
            req.CookieContainer = cookie;
            req.Headers.Add("X-Requested-With", "XMLHttpRequest");
            byte[] pic = File.ReadAllBytes(imgDirectory + imgName);
            byte[] end = Encoding.ASCII.GetBytes("\r\n-----------------------------12709277337355\r\nContent-Disposition: form-data; name=\"_files\"\r\n\r\n" + imgName + "\r\n-----------------------------12709277337355--\r\n");
            byte[] ms1 = Encoding.ASCII.GetBytes("-----------------------------12709277337355\r\nContent-Disposition: form-data; name=\"files\"; filename=\"" + imgName + "\"\r\nContent-Type: image/jpeg\r\n\r\n");
            req.ContentLength = ms1.Length + pic.Length + end.Length;
            Stream stre1 = req.GetRequestStream();
            stre1.Write(ms1, 0, ms1.Length);
            stre1.Write(pic, 0, pic.Length);
            stre1.Write(end, 0, end.Length);
            stre1.Close();
            HttpWebResponse resimg = (HttpWebResponse)req.GetResponse();
            StreamReader ressrImg = new StreamReader(resimg.GetResponseStream());
            otv = ressrImg.ReadToEnd();

            return otv;
        }

        internal string saveImg(string url, string productId, double widthImg, double heigthImg)
        {
            CookieContainer coockie = new CookieContainer();
            WebRequest webRequest = new WebRequest();
            CookieContainer cookie = webRequest.webCookieBike18();
            string otv = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/catalog/save-image");
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] saveImg = Encoding.ASCII.GetBytes("url=" + url + "&id=0&type=4&objectId=" + productId + "&imgCrop[x]=0&imgCrop[y]=0&imgCrop[width]=" + widthImg + "&imgCrop[height]=" + heigthImg + "&imageId=0&iObjectId=" + productId + "&iImageType=4&replacePhoto=0");
            req.ContentLength = saveImg.Length;
            Stream srSave = req.GetRequestStream();
            srSave.Write(saveImg, 0, saveImg.Length);
            srSave.Close();
            HttpWebResponse resSave = (HttpWebResponse)req.GetResponse();
            StreamReader ressrSave = new StreamReader(resSave.GetResponseStream());
            otv = ressrSave.ReadToEnd();

            return otv;
        }

        internal string loadCSV(string csvName, string csvStart, string csvEnd)
        {
            string otv = null;
            CookieContainer coockie = new CookieContainer();
            WebRequest webRequest = new WebRequest();
            CookieContainer cookie = webRequest.webCookieBike18();

            string epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString().Replace(",", "");
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/export-import/import-from-csv?fileapi" + epoch);
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=---------------------------12709277337355";
            req.CookieContainer = cookie;
            req.Headers.Add("X-Requested-With", "XMLHttpRequest");
            byte[] csv = File.ReadAllBytes("naSitePrice.csv");
            byte[] end = Encoding.ASCII.GetBytes("\r\n-----------------------------12709277337355\r\nContent-Disposition: form-data; name=\"_catalog_file\"\r\n\r\nnaSitePrice.csv\r\n-----------------------------12709277337355--\r\n");
            byte[] ms1 = Encoding.ASCII.GetBytes("-----------------------------12709277337355\r\nContent-Disposition: form-data; name=\"catalog_file\"; filename=\"naSitePrice.csv\"\r\nContent-Type: text/csv\r\n\r\n");
            req.ContentLength = ms1.Length + csv.Length + end.Length;
            Stream stre1 = req.GetRequestStream();
            stre1.Write(ms1, 0, ms1.Length);
            stre1.Write(csv, 0, csv.Length);
            stre1.Write(end, 0, end.Length);
            stre1.Close();
            HttpWebResponse resimg = (HttpWebResponse)req.GetResponse();
            StreamReader ressrImg = new StreamReader(resimg.GetResponseStream());
            otv = ressrImg.ReadToEnd();
            return otv;
        }

        internal string chekedCSV()
        {
            string otv = null;
            CookieContainer coockie = new CookieContainer();
            WebRequest webRequest = new WebRequest();
            CookieContainer cookie = webRequest.webCookieBike18();

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/export-import/check-import");
            req.Accept = "application/json, text/plain, */*";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentLength = 0;
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            Stream stre1 = req.GetRequestStream();
            stre1.Close();
            HttpWebResponse resimg = (HttpWebResponse)req.GetResponse();
            StreamReader ressrImg = new StreamReader(resimg.GetResponseStream());
            otv = ressrImg.ReadToEnd();
            return otv;
        }

        internal void saveProductAlsoBuy(CookieContainer cookie, List<string> getProduct, List<string> alsoBuy)
        {
            string alsoBuyStr = null;
            foreach (string element in alsoBuy)
            {
                alsoBuyStr += element;
            }
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/api/catalog/saveproduct");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = System.Text.Encoding.GetEncoding("utf-8").GetBytes("id=" + getProduct[0] + "&slug=" + getProduct[1] + "&categoryId=" + getProduct[2] + "&productGroup=" + getProduct[3] + "&name=" + getProduct[4] + "&serial=" + getProduct[5] + "&serialByUser=" + getProduct[6] + "&desc=" + getProduct[7] + "&descFull=" + getProduct[8] + "&cost=" + getProduct[9] + "&discountCost=" + getProduct[10] + "&seoMetaDesc=" + getProduct[11] + "&seoMetaKeywords=" + getProduct[12] + "&seoTitle=" + getProduct[13] + "&haveDetail=" + getProduct[14] + "&canMakeOrder=" + getProduct[15] + "&balance=100&showOnMain=" + getProduct[16] + "&isVisible=1&hasSale=0&avatar[id]=" + getProduct[17] + "&avatar[objectId]=" + getProduct[18] + "&avatar[timestamp]=" + getProduct[19] + "&avatar[type]=" + getProduct[20] + "&avatar[name]=" + getProduct[21] + "&avatar[desc]=" + getProduct[22] + "&avatar[ext]=" + getProduct[23] + "&avatar[formats][raw]=" + getProduct[24] + "&avatar[formats][W215]=" + getProduct[25] + "&avatar[formats][150x120]=" + getProduct[26] + "&avatar[formats][104x82]=" + getProduct[27] + "&avatar[formatParams][raw][fileSize]=" + getProduct[28] + "&avatar[alt]=" + getProduct[29] + "&avatar[isVisibleOnMain]=" + getProduct[30] + "&avatar[priority]=" + getProduct[31] + "&avatar[url]=" + getProduct[32] + "&avatar[filters][crop][left]=" + getProduct[33] + "&avatar[filters][crop][top]=" + getProduct[34] + "&avatar[filters][crop][right]=" + getProduct[35] + "&avatar[filters][crop][bottom]=" + getProduct[36] + "&customDays=" + getProduct[37] + "&isCustom=" + getProduct[38] + alsoBuyStr + "&alsoBuyLabel=%D0%9F%D0%BE%D1%85%D0%BE%D0%B6%D0%B8%D0%B5%20%D1%82%D0%BE%D0%B2%D0%B0%D1%80%D1%8B%20%D0%B2%20%D0%BD%D0%B0%D1%88%D0%B5%D0%BC%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D0%B5");
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res1 = (HttpWebResponse)req.GetResponse();
            StreamReader ressr1 = new StreamReader(res1.GetResponseStream());
        }

        internal void fileWriter(string v1, string v2)
        {

            StreamWriter writers = new StreamWriter(v1 + ".txt", true, Encoding.GetEncoding("windows-1251"));
            writers.WriteLine(v2 + "\n");
            writers.Close();
        }

        internal void fileWriterCSV(List<string> newProduct, string nameFile)
        {
            StreamWriter newProductcsv = new StreamWriter(nameFile + ".csv", true, Encoding.GetEncoding("windows-1251"));
            int count = newProduct.Count - 1;
            for (int i = 0; count > i; i++)
            {
                newProductcsv.Write(newProduct[i], Encoding.GetEncoding("windows-1251"));
                newProductcsv.Write(";");
            }
            newProductcsv.Write(newProduct[count], Encoding.GetEncoding("windows-1251"));
            newProductcsv.WriteLine();
            newProductcsv.Close();
        }

        internal void writerCSV(string v, string section1, string section2)
        {
            StreamWriter newProductcsv = new StreamWriter("fullProducts.csv", true, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(v, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.Write(section1, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.Write(section2, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.WriteLine();
            newProductcsv.Close();
        }

        internal void writerCSV(string v1, string v2, string section1, string section2)
        {
            StreamWriter newProductcsv = new StreamWriter("fullProducts.csv", true, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(v1, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.Write(v2, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.Write(section1, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.Write(section2, Encoding.GetEncoding("windows-1251"));
            newProductcsv.Write(";");
            newProductcsv.WriteLine();
            newProductcsv.Close();
        }

        internal void doubleTovar(string v, string dblProduct, int i, int section)
        {

        }

        public string downloadImage(string articlProduct)
        {
            WebRequest webRequest = new WebRequest();

            CookieContainer cookie = webRequest.webCookieBike18();
            string otv = null;
            string boundary = "173292644617537";
            string epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString().Replace(",", "");
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bike18.nethouse.ru/putimg?fileapi" + epoch);
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=---------------------------" + boundary;
            req.CookieContainer = cookie;
            req.Headers.Add("X-Requested-With", "XMLHttpRequest");
            byte[] pic = File.ReadAllBytes("Pic\\" + articlProduct + ".jpg");
            byte[] end = Encoding.ASCII.GetBytes("\r\n-----------------------------" + boundary + "\r\nContent-Disposition: form-data; name=\"_file\"\r\n\r\n" + articlProduct + ".jpg\r\n-----------------------------" + boundary + "--\r\n");
            byte[] ms1 = Encoding.ASCII.GetBytes("-----------------------------" + boundary + "\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" + articlProduct + ".jpg\"\r\nContent-Type: image/jpeg\r\n\r\n");
            req.ContentLength = ms1.Length + pic.Length + end.Length;
            Stream stre1 = req.GetRequestStream();
            stre1.Write(ms1, 0, ms1.Length);
            stre1.Write(pic, 0, pic.Length);
            stre1.Write(end, 0, end.Length);
            stre1.Close();
            HttpWebResponse resimg = (HttpWebResponse)req.GetResponse();
            StreamReader ressrImg = new StreamReader(resimg.GetResponseStream());
            otv = ressrImg.ReadToEnd();

            return otv;
        }

        internal List<string> listTovarImages(CookieContainer cookie, string url)
        {
            WebRequest webRequest = new WebRequest();
            List<string> listTovar = new List<string>();

            if (!url.Contains("nethouse"))
                url = url.Replace("http://bike18.ru/", "http://bike18.nethouse.ru/");

            string otv = webRequest.PostRequest(cookie, url);
            if (otv != null)
            {
                string productId = new Regex("(?<=<section class=\"comment\" id=\").*?(?=\">)").Match(otv).ToString();
                string article = new Regex("(?<=Артикул:)[\\w\\W]*(?=</div><div><div class)").Match(otv).Value.Trim();
                if (article.Length > 11)
                {
                    article = new Regex("(?<=Артикул:)[\\w\\W]*(?=</title>)").Match(otv).ToString().Trim();
                }
                string prodName = new Regex("(?<=<h1>).*(?=</h1>)").Match(otv).Value;
                string price = new Regex("(?<=<span class=\"product-price-data\" data-cost=\").*?(?=\">)").Match(otv).Value;
                string imgId = new Regex("(?<=<div id=\"avatar-).*(?=\")").Match(otv).Value;
                string desc = new Regex("(?<=<div class=\"user-inner\">).*?(?=</div>)").Match(otv).Value;
                string fulldesc = new Regex("(?<=<div id=\"product-full-desc\" data-ng-non-bindable class=\"user-inner\">).*?(?=</div>)").Match(otv).Value.Replace("&nbsp;&nbsp;", " ");
                string seometa = new Regex("(?<=<meta name=\"description\" content=\").*?(?=\" >)").Match(otv).Value;
                string keywords = new Regex("(?<=<meta name=\"keywords\" content=\").*?(?=\" >)").Match(otv).Value;
                string title = new Regex("(?<=<title>).*?(?=</title>)").Match(otv).Value;
                string visible = new Regex("(?<=,\"balance\":).*?(?=,\")").Match(otv).Value;
                string reklama = new Regex("(?<=<div class=\"text\">).*?(?=</div>)").Match(otv).ToString();
                if (reklama == "акция")
                {
                    reklama = "&markers[3]=1";
                }
                if (reklama == "новинка")
                {
                    reklama = "&markers[1]=1";
                }

                otv = webRequest.PostRequest(cookie, "http://bike18.nethouse.ru/api/catalog/getproduct?id=" + productId);
                string slug = new Regex("(?<=\",\"slug\":\").*?(?=\")").Match(otv).ToString();
                string discountCoast = new Regex("(?<=discountCost\":\").*?(?=\")").Match(otv).Value;
                string serial = new Regex("(?<=serial\":\").*?(?=\")").Match(otv).Value;
                string categoryId = new Regex("(?<=\",\"categoryId\":\").*?(?=\")").Match(otv).Value;
                string productGroup = new Regex("(?<=\",\"productGroup\":).*?(?=,\")").Match(otv).Value;
                string havenDetail = new Regex("(?<=haveDetail\".).*?(?=,\")").Match(otv).Value;
                string canMakeOrder = new Regex("(?<=canMakeOrder\".).*?(?=,\")").Match(otv).Value;
                canMakeOrder = canMakeOrder.Replace("false", "0");
                canMakeOrder = canMakeOrder.Replace("true", "1");
                //String balance = new Regex("(?<=,\"balance\":).*?(?=,\")").Match(otv).ToString();
                string showOnMain = new Regex("(?<=showOnMain\".).*?(?=,\")").Match(otv).Value;
                string customDays = new Regex("(?<=,\"customDays\":\").*?(?=\")").Match(otv).Value;
                string isCustom = new Regex("(?<=\",\"isCustom\":).*?(?=,)").Match(otv).Value;

                otv = webRequest.PostRequest(cookie, "http://bike18.nethouse.ru/api/catalog/productmedia?id=" + productId);
                MatchCollection avatarId = new Regex("(?<=\"id\":\").*?(?=\")").Matches(otv);
                string objektId = new Regex("(?<=\"objectId\":\").*?(?=\")").Match(otv).Value;
                MatchCollection timestamp = new Regex("(?<=\"timestamp\":\").*?(?=\")").Matches(otv);
                MatchCollection type = new Regex("(?<=\"type\":\").*?(?=\")").Matches(otv);
                MatchCollection name = new Regex("(?<=\",\"name\":\").*?(?=\")").Matches(otv);
                MatchCollection descimg = new Regex("(?<=\"desc\":\").*?(?=\")").Matches(otv);
                MatchCollection ext = new Regex("(?<=\"ext\":\").*?(?=\")").Matches(otv);
                MatchCollection raw = new Regex("(?<=\"raw\":\").*?(?=\")").Matches(otv);
                MatchCollection W215 = new Regex("(?<=\"W215\":\").*?(?=\")").Matches(otv);
                MatchCollection srimg = new Regex("(?<=\"150x120\":\").*?(?=\")").Matches(otv);
                MatchCollection minimg = new Regex("(?<=\"104x82\":\").*?(?=\")").Matches(otv);
                MatchCollection filesize = new Regex("(?<=\"fileSize\":).*?(?=})").Matches(otv);
                MatchCollection alt = new Regex("(?<=\"alt\":\").*?(?=\")").Matches(otv);
                MatchCollection isvisibleonmain = new Regex("(?<=\"isVisibleOnMain\".).*?(?=,)").Matches(otv);
                string prioriti = new Regex("(?<=\"priority\":\").*?(?=\")").Match(otv).Value;
                MatchCollection avatarurl = new Regex("(?<=\"url\":\").*?(?=\")").Matches(otv);
                string filtersleft = new Regex("(?<=\"left\":).*?(?=,)").Match(otv).Value;
                string filterstop = new Regex("(?<=\"top\":).*?(?=,)").Match(otv).Value;
                string filtersright = new Regex("(?<=\"right\":).*?(?=,)").Match(otv).Value;
                string filtersbottom = new Regex("(?<=\"bottom\":).*?(?=})").Match(otv).Value;

                listTovar.Add(productId);       //0
                listTovar.Add(slug);            //1
                listTovar.Add(categoryId);      //2
                listTovar.Add(productGroup);    //3
                listTovar.Add(prodName);        //4
                listTovar.Add(serial);          //5
                listTovar.Add(article);         //6
                listTovar.Add(desc);            //7
                listTovar.Add(fulldesc);        //8
                listTovar.Add(price);           //9
                listTovar.Add(discountCoast);   //10
                listTovar.Add(seometa);         //11
                listTovar.Add(keywords);        //12
                listTovar.Add(title);           //13
                listTovar.Add(havenDetail);     //14
                listTovar.Add(canMakeOrder);    //15 купить с сайта в 1 клик
                                                //listTovar.Add(balance);
                listTovar.Add(showOnMain);      //16
                listTovar.Add(avatarId[0].ToString());        //17
                listTovar.Add(objektId);        //18
                listTovar.Add(timestamp[0].ToString());       //19
                listTovar.Add(type[0].ToString());            //20
                listTovar.Add(name[0].ToString());            //21
                listTovar.Add(descimg[0].ToString());         //22
                listTovar.Add(ext[0].ToString());             //23
                listTovar.Add(raw[0].ToString());             //24
                listTovar.Add(W215[0].ToString());            //25
                listTovar.Add(srimg[0].ToString());           //26
                listTovar.Add(minimg[0].ToString());          //27
                listTovar.Add(filesize[0].ToString());        //28
                listTovar.Add(alt[0].ToString());             //29
                listTovar.Add(isvisibleonmain[0].ToString()); //30
                listTovar.Add(prioriti);        //31
                listTovar.Add(avatarurl[0].ToString());       //32
                listTovar.Add(filtersleft);     //33
                listTovar.Add(filterstop);      //34
                listTovar.Add(filtersright);    //35
                listTovar.Add(filtersbottom);   //36
                listTovar.Add(customDays);      //37
                listTovar.Add(isCustom);        //38
                listTovar.Add(reklama);         //39

                for(int i = 0; ext.Count > i; i++)
                {
                    listTovar.Add(avatarId[i].ToString());        //40 54 68 82 96 110 124 138 152 166 180 194 208
                    listTovar.Add(timestamp[i].ToString());       //41
                    listTovar.Add(type[i].ToString());            //42
                    listTovar.Add(name[i].ToString());            //43
                    listTovar.Add(descimg[i].ToString());         //44
                    listTovar.Add(ext[i].ToString());             //45
                    listTovar.Add(raw[i].ToString());             //46
                    listTovar.Add(W215[i].ToString());            //47
                    listTovar.Add(srimg[i].ToString());           //48
                    listTovar.Add(minimg[i].ToString());          //49
                    listTovar.Add(filesize[i].ToString());        //50
                    listTovar.Add(alt[i].ToString());             //51 65 79 93 107 121 135 149 163 177 191 205 219 233
                    listTovar.Add(isvisibleonmain[i].ToString()); //52
                    listTovar.Add(avatarurl[i].ToString());       //53
                }
                
            }
            return listTovar;
        }
    }
}
