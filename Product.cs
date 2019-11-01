using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace Bike18Text
{
    public class Product
    {
        NehouseLibrary.nethouse nethouse = new NehouseLibrary.nethouse();

        private string article;
        private string id;
        private string productId;
        private string name;
        private string categoryName;
        private string imageId;
        private string description;
        private string descriptionFull;
        private string seoDescription;
        private string seoKeywords;
        private string seoTitle;
        private string coast;
        private string discount;
        private string slug;
        private string customGroup;
        private string strGroup;
        private string advertising;
        private string markers;
        private string balance;
        private string serial;
        private string categoryId;
        private string productGroup;
        private string haveDetail;
        private string canMakeOrder;
        private string showOnMain;
        private string customDays;
        private string isCustom;
        private string atribut;
        private string attributes;
        private string alsoBuy;
        private string alsoBuyStr;
        private string avatarId;
        private string objectId;
        private string timestamp;
        private string imageType;
        private string imageName;
        private string imageDesc;
        private string imageExt;
        private string imageRaw;
        private string imageW215;
        private string image150x120;
        private string image104x82;
        private string imageFileSize;
        private string imageAlt;
        private string imageIsVisibleOnMain;
        private string imagePriority;
        private string imageAvatar;
        private string imageAvatarUrl;
        private string imageLeft;
        private string imageTop;
        private string imageRight;
        private string imageBottom;
        private string image;
        private string parametrsTovar;
        private MatchCollection categories;
        private string productUrl;
        private string allAttributes;
        private string parametrs;

    public Product()
        {
        }
        public Product(CookieDictionary cookie, string urlProduct)
        {
            string response = "";

            if (!urlProduct.Contains("nethouse"))
                urlProduct = urlProduct.Replace(".ru/", ".nethouse.ru/");

            nethouse.Internet();
            try
            {
                ProductUrl = urlProduct;
                response = nethouse.getRequest(cookie, urlProduct);
                if (response == "err")
                {
                    return;
                }

                Id = new Regex("(?<=data-product-id=\").*?(?=\">)").Match(response).ToString();
                
                ProductId = new Regex("(?<=data-product-id=\").*?(?=\">)").Match(response).ToString();
                if (ProductId == "")
                    ProductId = new Regex("(?<=data-id=\").*?(?=\")").Match(response).ToString();

                MatchCollection articlArray = new Regex("(?<=Артикул: )[\\w\\W]*?(?=</div>)").Matches(response);
                for (int i = 0; articlArray.Count > i; i++)
                {
                    string str = articlArray[i].ToString().Trim();
                    if (str.Length > 128)
                    {
                        Article = new Regex("(?<=Артикул:)[\\w\\W]*(?=</title>)").Match(response).ToString().Trim();
                        if (article.Length > 128)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Article = str;
                        break;
                    }
                }

                Name = new Regex("(?<=<h1>).*(?=</h1>)").Match(response).Value;
                Name = nethouse.ReplaceAmpersandsChar(Name);
                Name = Name.Replace(';', '-');

                Categories = new Regex("(?<=<div class=\"bread-crumbs__item bread-crumbs__text\">).*?(?=</div></a></div>)").Matches(response);
                CategoryName = Categories[Categories.Count - 1].ToString();

                ImageId = new Regex("(?<=<div id=\"avatar-).*(?=\")").Match(response).Value;

                Description = new Regex("(?<=<div class=\"product__desc show-for-large user-inner\">)[\\w\\W]*?(?=</div>)").Match(response).Value;
                Description = nethouse.ReplaceAmpersandsChar(Description);

                DescriptionFull = new Regex("(?<=<div class=\"user-inner\" data-ng-non-bindable id=\"product-full-desc\">)[\\w\\W]*?(?=</div>)").Match(response).Value.Trim();
                if (DescriptionFull.Length == 0)
                {
                    DescriptionFull = new Regex("(?<=<div id=\"product-full-desc\")[\\w\\W]*?(?=</div>)").Match(response).ToString();
                    DescriptionFull = DescriptionFull.Remove(0, DescriptionFull.IndexOf('>') + 1);
                }
                DescriptionFull = nethouse.ReplaceAmpersandsChar(DescriptionFull);

                SeoDescription = new Regex("(?<=<meta name=\"description\" content=\").*?(?=\" >)").Match(response).Value;
                SeoKeywords= new Regex("(?<=<meta name=\"keywords\" content=\").*?(?=\" >)").Match(response).Value;
                SeoTitle = new Regex("(?<=<title>).*?(?=</title>)").Match(response).Value;

                MatchCollection paramsTovar = new Regex("(?<=<label class=\"ptype-view-title infoDigits\">)[\\w\\W]*?(?=</select></li>)").Matches(response);
                ParametrsTovar = "";

                nethouse.Internet();

                response = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/getproduct?id=" + ProductId);

                if (response == "err")
                {
                    return;
                }

                Coast = new Regex("(?<=\"cost\":\").*?(?=\")").Match(response).Value;
                if (Coast == "") 
                    Coast = "0";
                
                Discount = new Regex("(?<=\"discountCost\":\").*?(?=\")").Match(response).Value;

                Slug = new Regex("(?<=\",\"slug\":\").*?(?=\")").Match(response).ToString();

                CustomGroup = new Regex("(?<=productCustomGroup\":)[\\w\\W]*?(?=,\")").Match(response).ToString();

                dynamic stuff1 = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response);
                string ssss = stuff1.ToString();
                string groupeBranch = new Regex("(?<=productGroupBranch\":)[\\w\\W]*(?=\"name\":)").Match(ssss).ToString();
                MatchCollection groupes = new Regex("(?<=name\": \")[\\w\\W]*?(?=\")").Matches(groupeBranch);
                foreach (Match s in groupes)
                {
                    StrGroup += s + "/";
                }
                if (StrGroup != null && StrGroup != "")
                    StrGroup = StrGroup.Substring(0, StrGroup.Length - 1);

                Markers = new Regex("(?<=markers\":{\").*?(?=\")").Match(response).ToString();
                if (Markers == "1")
                    Advertising = "&markers[1]=1";
                else
                if (Markers == "2")
                    Advertising = "&markers[2]=1";
                else
                if (Markers == "3")
                    Advertising = "&markers[3]=1";
                else
                if (Markers == "4")
                    Advertising = "&markers[4]=1";
                else
                if (Markers == "5")
                    Advertising = "&markers[5]=1";
                else
                if (Markers == "6")
                    Advertising = "&markers[6]=1";
                else
                if (Markers == "7")
                    Advertising = "&markers[7]=1";

                Balance = new Regex("(?<=,\"balance\":).*?(?=,\")").Match(response).ToString();
                if (Balance.Contains("\""))
                    Balance = Balance.Replace("\"", "");

                Serial = new Regex("(?<=serial\":\").*?(?=\")").Match(response).Value;
                CategoryId = new Regex("(?<=\",\"categoryId\":\").*?(?=\")").Match(response).Value;
                if (CategoryId == "")
                    CategoryId = new Regex("(?<=categoryId\":\").*?(?=\")").Match(response).ToString();
               
                ProductGroup = new Regex("(?<=productGroup\":).*?(?=,\")").Match(response).Value;
                HaveDetail = new Regex("(?<=haveDetail\".).*?(?=,\")").Match(response).Value;
                CanMakeOrder = new Regex("(?<=canMakeOrder\".).*?(?=,\")").Match(response).Value;
                CanMakeOrder = canMakeOrder.Replace("false", "0").Replace("true", "1");
                ShowOnMain = new Regex("(?<=showOnMain\".).*?(?=,\")").Match(response).Value;
                CustomDays = new Regex("(?<=,\"customDays\":\").*?(?=\")").Match(response).Value;
                IsCustom = new Regex("(?<=\",\"isCustom\":).*?(?=,)").Match(response).Value;

                string allParametrs = new Regex("(?<=\"params\":).*?}],").Match(response).ToString();
                MatchCollection parametrs = new Regex("{\"id\".*?}]}").Matches(allParametrs);
                for(int i =0; i <parametrs.Count; i++)
                {
                    string id = new Regex("(?<={\"id\":).*?(?=,\"name\")").Match(parametrs[i].ToString()).Value;
                    string name = new Regex("(?<=name\":\").*?(?=\")").Match(parametrs[i].ToString()).Value;
                    name = UnicodeToUTF8(name);
                    name = WebUtility.UrlEncode(name);
                    string valuesString = new Regex("(?<=\"values\":).*?(?=]})").Match(parametrs[i].ToString()).Value;

                    Parametrs += "&params[" + i + "][id]=" + id + "&params[" + i + "][name]=" + name;

                    MatchCollection values = new Regex("{\"id\".*?}").Matches(valuesString);
                    for(int j = 0; j < values.Count; j++)
                    {
                        string valId = new Regex("(?<=\"id\":).*?(?=,\"value\")").Match(values[i].ToString()).Value;
                        string valValue = new Regex("(?<=\"value\":\").*?(?=\",\")").Match(values[i].ToString()).Value;
                        valValue = UnicodeToUTF8(valValue);
                        valValue = WebUtility.UrlEncode(valValue);
                        string valImpact = new Regex("(?<=impact\":\").*?(?=\")").Match(values[i].ToString()).Value;

                        Parametrs += "&params[" + i + "][values][" + j + "][id]=" + valId + "&params[" + i + "][values][" + j + "][value]=" + valValue + "&params[" + i + "][values][" + j + "][impact]=" + valImpact;
                    }
                }

                Attributes = new Regex("(?<=attributes\":{\").*?(?=,\"customDays)").Match(response).Value;
                MatchCollection stringAtributes = new Regex("(?<=\":{\").*?(?=])").Matches(Attributes);
                for (int i = 0; stringAtributes.Count > i; i++)
                {
                    string mid = new Regex("(?<=primaryKey\":\").*?(?=\",\")").Match(stringAtributes[i].ToString()).Value;
                    if (mid == "")
                        mid = new Regex("(?<=primaryKey\":).*?(?=,\")").Match(stringAtributes[i].ToString()).Value;
                    string valueId = new Regex("(?<=\"valueId\":\").*?(?=\")").Match(stringAtributes[i].ToString()).Value;
                    string valueText = new Regex("(?<=valueText\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;
                    string text = new Regex("(?<=\"text\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;
                    string checkBox = new Regex("(?<=checkbox\":).*?(?=})").Match(stringAtributes[i].ToString()).Value;

                    if (valueId != "")
                    {
                        Atribut = Atribut + "&attributes[" + i + "][primaryKey]=" + mid + "&attributes[" + i + "][attributeId]=" + mid + "&attributes[" + i + "][values][0][valueId]=" + valueId + "&attributes[" + i + "][values][0][valueText]=" + valueText;
                    }
                    else
                    {
                        bool valId = false;
                        if (text != "")
                        {
                            Atribut = Atribut + "&attributes[" + i + "][primaryKey]=" + mid + "&attributes[" + i + "][attributeId]=" + mid + "&attributes[" + i + "][values][0][text]=" + text;
                            valId = true;
                        }
                        if (checkBox != "")
                        {
                            Atribut = Atribut + "&attributes[" + i + "][primaryKey]=" + mid + "&attributes[" + i + "][attributeId]=" + mid + "&attributes[" + i + "][values][0][checkbox]=" + checkBox;
                            valId = true;
                        }
                        if (!valId)
                        {
                            Atribut = Atribut + "&attributes[" + i + "][primaryKey]=" + mid + "&attributes[" + i + "][attributeId]=" + mid + "&attributes[" + i + "][values][0][valueId]=" + valueId + "&attributes[" + i + "][values][0][valueText]=" + valueText;
                        }
                    }
                }
                Atribut = Atribut.Replace("true", "1").Replace("\"", "");
                AlsoBuy = new Regex("(?<=alsoBuy\":).*?(?=,\"markers)").Match(response).ToString();
                AlsoBuy = AlsoBuy.Remove(AlsoBuy.Length - 1, 1).Remove(0, 1);
                string[] alsoBuyArray = AlsoBuy.Split(',');
                if (alsoBuyArray.Length > 0)
                {
                    for (int i = 0; alsoBuyArray.Length > i; i++)
                    {
                        AlsoBuyStr += "&alsoBuy[" + i + "]=" + alsoBuyArray[i].ToString();
                    }
                }

                nethouse.Internet();

                response = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/productmedia?id=" + productId);

                if (response == "err")
                {
                    return;
                }

                AvatarId = new Regex("(?<=\"id\":\").*?(?=\")").Match(response).Value;
                ObjectId = new Regex("(?<=\"objectId\":\").*?(?=\")").Match(response).Value;
                Timestamp = new Regex("(?<=\"timestamp\":\").*?(?=\")").Match(response).Value;
                ImageType = new Regex("(?<=\"type\":\").*?(?=\")").Match(response).Value;
                ImageName = new Regex("(?<=\",\"name\":\").*?(?=\")").Match(response).Value;
                ImageDesc = new Regex("(?<=\"desc\":\").*?(?=\")").Match(response).Value;
                ImageExt = new Regex("(?<=\"ext\":\").*?(?=\")").Match(response).Value;
                ImageRaw = new Regex("(?<=\"raw\":\").*?(?=\")").Match(response).Value;
                ImageW215 = new Regex("(?<=\"W215\":\").*?(?=\")").Match(response).Value;
                Image150x120 = new Regex("(?<=\"150x120\":\").*?(?=\")").Match(response).Value;
                Image104x82 = new Regex("(?<=\"104x82\":\").*?(?=\")").Match(response).Value;
                ImageFileSize = new Regex("(?<=\"fileSize\":).*?(?=})").Match(response).Value;
                ImageAlt = new Regex("(?<=\"alt\":\").*?(?=\")").Match(response).Value;
                ImageIsVisibleOnMain = new Regex("(?<=\"isVisibleOnMain\".).*?(?=,)").Match(response).Value;
                ImagePriority = new Regex("(?<=\"priority\":\").*?(?=\")").Match(response).Value;
                ImageAvatar = new Regex("(?<=avatar).*?(?=alsoBuy)").Match(response).Value;
                ImageAvatarUrl = new Regex("(?<=url\":\").*?(?=\")").Match(ImageAvatar).ToString();
                if (ImageAvatarUrl == "")
                {
                    ImageAvatarUrl = new Regex("(?<=src\":\").*?(?=\")").Match(ImageAvatar).ToString();
                }
                ImageLeft = new Regex("(?<=\"left\":).*?(?=,)").Match(response).Value;
                ImageTop = new Regex("(?<=\"top\":).*?(?=,)").Match(response).Value;
                ImageRight = new Regex("(?<=\"right\":).*?(?=,)").Match(response).Value;
                ImageBottom = new Regex("(?<=\"bottom\":).*?(?=})").Match(response).Value;

                MatchCollection allImages = new Regex("(?<=:{\"id\":\").*?(?=format\\(png\\))").Matches(response);
                if (allImages.Count != 0)
                {
                    foreach (Match img in allImages)
                    {
                        string str = img.ToString();
                        MatchCollection urlImg = new Regex("(?<=\"src\":\").*?.jpg").Matches(str);
                        if (urlImg.Count == 0)
                        {
                            urlImg = new Regex("(?<=\"src\":\").*?.JPG").Matches(str);
                        }
                        foreach (Match img2 in urlImg)
                        {
                            string s = img2.ToString();
                            s = s.Replace("\\/", "/").Replace("//", "");
                            Image = Image + ";" + s;
                        }
                    }
                }
                if (Image.Contains('}') || Image.Contains('{'))
                    Image = "";
                if (Image == "")
                {
                    allImages = new Regex("(?<=\"src\":\").*?(?=\")").Matches(response);
                    if (allImages.Count != 0)
                    {
                        foreach (Match imgUrl in allImages)
                        {
                            string str = imgUrl.ToString();
                            str = str.Replace("\\/", "/").Replace("//", "");
                            Image = Image + ";" + str;
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        static string UnicodeToUTF8(string from)
        {
            return Regex.Replace(from, @"\\u([\da-f]{4})", m => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());
        }

        public void alsoByUpdate()
        {
            string name = Name;

            nethouse.Internet();

            string response = nethouse.getRequest("https://bike18.ru/products/search?sort=0&balance=&categoryId=&min_cost=&max_cost=&page=1&text=" + name);
            MatchCollection searchTovars = new Regex("(?<=id=\"item).*?(?=\">)").Matches(response);
            string alsoBuy = "";
            int count = 0;
            if (searchTovars.Count >= 5)
            {
                int countSearch = searchTovars.Count;
                if (countSearch > 5)
                    countSearch = 5;

                for (int i = 1; countSearch > i; i++)
                {
                    alsoBuy += "&alsoBuy[" + count + "]=" + searchTovars[i].ToString();
                    count++;
                }
            }
            else
            {
                nethouse.Internet();

                response = nethouse.getRequest("https://bike18.ru/products/category/" + CategoryId);
                string nameCategory = new Regex("(?<=<h1 class=\"category-name\">).*(?=</h1>)").Match(response).ToString();

                nethouse.Internet();

                response = nethouse.getRequest("https://bike18.ru/products/search/page/1?sort=0&balance=&categoryId=&min_cost=&max_cost=&text=" + nameCategory);
                searchTovars = new Regex("(?<=id=\"item).*?(?=\">)").Matches(response);
                if (searchTovars.Count > 2)
                {
                    int countSearch = searchTovars.Count;
                    if (countSearch > 5)
                        countSearch = 5;

                    for (int i = 1; countSearch > i; i++)
                    {

                        alsoBuy += "&alsoBuy[" + count + "]=" + searchTovars[i].ToString();
                        count++;
                    }
                }
            }
            AlsoBuy = alsoBuy;
        }

        public void updateChpu(CookieDictionary cookie, string oldCHPU, string newCHPU)
        {
            byte[] saveImg = Encoding.ASCII.GetBytes("fromlink=/products/" + oldCHPU + "&tolink=/products/" + newCHPU);

            nethouse.Internet();

            var request = new HttpRequest();
            request.UserAgent = Http.FirefoxUserAgent();

            request.Cookies = cookie;
            request["X-Requested-With"] = "XMLHttpRequest";
            HttpResponse response = request.Post("https://bike18.nethouse.ru/redirect/savelink", saveImg);
        }

        public List<string> ReturnImagesId(CookieDictionary cookie, Product product)
        {
            List<string> imagesTovar = new List<string>();

            string otv = "";

                string productId = product.Id;

                otv = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/getproduct?id=" + productId);

                otv = nethouse.getRequest(cookie, "https://bike18.nethouse.ru/api/catalog/productmedia?id=" + productId);
                string objektId = new Regex("(?<=\"objectId\":\").*?(?=\")").Match(otv).Value;

                MatchCollection imagesStrTovat = new Regex("(?<=\"id\":\").*?(?=filters)").Matches(otv);
                if (imagesStrTovat.Count == 0)
                    imagesStrTovat = new Regex("(?<=\"id\":\").*?(?=})").Matches(otv);
                foreach (Match str in imagesStrTovat)
                {
                    if (str.ToString().Contains("type\":\"4\"") || str.ToString().Contains("type\":\"5\""))
                    {
                        string s = str.ToString();
                        string imageId = new Regex("(?<=:\").*?(?=\",\"objectId)").Match(str.ToString()).ToString();
                        if (imageId == "")
                            imageId = new Regex(".*?(?=\",\"objectId\":\")").Match(str.ToString()).ToString();
                        imagesTovar.Add(imageId);
                    }
                }
            return imagesTovar;
        }

        public string save(CookieDictionary cookie)
        {
            string hasSale = "0";
            if (Discount != "")
                hasSale = "1";
            
            string requestStr = "id=" + Id +
                "&slug=" + Slug +
                "&categoryId=" + CategoryId +
                "&productCustomGroup=" + CustomGroup +
                "&productGroup=" + ProductGroup +
                "&name=" + WebUtility.UrlEncode(Name) +
                "&serial=" + Serial +
                "&serialByUser=" + Article +
                "&desc=" + WebUtility.UrlEncode(Description) +
                "&descFull=" + WebUtility.UrlEncode(DescriptionFull) +
                "&cost=" + Coast +
                "&discountCost=" + Discount +
                "&seoMetaDesc=" + WebUtility.UrlEncode(SeoDescription) +
                "&seoMetaKeywords=" + WebUtility.UrlEncode(SeoKeywords) +
                "&seoTitle=" + WebUtility.UrlEncode(SeoTitle) +
                "&haveDetail=" + HaveDetail +
                "&canMakeOrder=" + CanMakeOrder +
                "&balance=" + Balance +
                "&showOnMain=" + ShowOnMain +
                "&isVisible=1" +
                "&hasSale=" + hasSale +
                Parametrs + 
                "&customDays=" + CustomDays +
                "&isCustom=" + IsCustom +
                  Atribut +
                 AlsoBuy +
                "&alsoBuyLabel=%D0%9F%D0%BE%D1%85%D0%BE%D0%B6%D0%B8%D0%B5%20%D1%82%D0%BE%D0%B2%D0%B0%D1%80%D1%8B%20%D0%B2%20%D0%BD%D0%B0%D1%88%D0%B5%D0%BC%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%D0%B5";
            requestStr = requestStr.Replace("false", "0").Replace("true", "1").Replace("+", "%20");

            return nethouse.SaveTovar(cookie, requestStr);
        }
        public string Article { get => article; set => article = value; }
        public string Id { get => id; set => id = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string ImageId { get => imageId; set => imageId = value; }
        public string Description { get => description; set => description = value; }
        public string DescriptionFull { get => descriptionFull; set => descriptionFull = value; }
        public string SeoDescription { get => seoDescription; set => seoDescription = value; }
        public string SeoKeywords { get => seoKeywords; set => seoKeywords = value; }
        public string SeoTitle { get => seoTitle; set => seoTitle = value; }
        public string Coast { get => coast; set => coast = value; }
        public string Discount { get => discount; set => discount = value; }
        public string Slug { get => slug; set => slug = value; }
        public string CustomGroup { get => customGroup; set => customGroup = value; }
        public string StrGroup { get => strGroup; set => strGroup = value; }
        public string Advertising { get => advertising; set => advertising = value; }
        public string Markers { get => markers; set => markers = value; }
        public string Balance { get => balance; set => balance = value; }
        public string Serial { get => serial; set => serial = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string ProductGroup { get => productGroup; set => productGroup = value; }
        public string HaveDetail { get => haveDetail; set => haveDetail = value; }
        public string CanMakeOrder { get => canMakeOrder; set => canMakeOrder = value; }
        public string ShowOnMain { get => showOnMain; set => showOnMain = value; }
        public string CustomDays { get => customDays; set => customDays = value; }
        public string Atribut { get => atribut; set => atribut = value; }
        public string Attributes { get => attributes; set => attributes = value; }
        public string AlsoBuy { get => alsoBuy; set => alsoBuy = value; }
        public string AlsoBuyStr { get => alsoBuyStr; set => alsoBuyStr = value; }
        public string AvatarId { get => avatarId; set => avatarId = value; }
        public string ObjectId { get => objectId; set => objectId = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
        public string ImageType { get => imageType; set => imageType = value; }
        public string ImageLeft { get => imageLeft; set => imageLeft = value; }
        public string ImageTop { get => imageTop; set => imageTop = value; }
        public string ImageRight { get => imageRight; set => imageRight = value; }
        public string ImageBottom { get => imageBottom; set => imageBottom = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public string ImageDesc { get => imageDesc; set => imageDesc = value; }
        public string ImageExt { get => imageExt; set => imageExt = value; }
        public string ImageRaw { get => imageRaw; set => imageRaw = value; }
        public string ImageW215 { get => imageW215; set => imageW215 = value; }
        public string Image150x120 { get => image150x120; set => image150x120 = value; }
        public string Image104x82 { get => image104x82; set => image104x82 = value; }
        public string ImageFileSize { get => imageFileSize; set => imageFileSize = value; }
        public string ImageAlt { get => imageAlt; set => imageAlt = value; }
        public string ImageIsVisibleOnMain { get => imageIsVisibleOnMain; set => imageIsVisibleOnMain = value; }
        public string ImagePriority { get => imagePriority; set => imagePriority = value; }
        public string ImageAvatar { get => imageAvatar; set => imageAvatar = value; }
        public string ImageAvatarUrl { get => imageAvatarUrl; set => imageAvatarUrl = value; }
        public string Image { get => image; set => image = value; }
        public string ParametrsTovar { get => parametrsTovar; set => parametrsTovar = value; }
        public string IsCustom { get => isCustom; set => isCustom = value; }
        public MatchCollection Categories { get => categories; set => categories = value; }
        public string ProductUrl { get => productUrl; set => productUrl = value; }
        public string AllAttributes { get => allAttributes; set => allAttributes = value; }
        public string Parametrs { get => parametrs; set => parametrs = value; }
    }
}