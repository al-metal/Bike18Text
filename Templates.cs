using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bike18Text
{
    public partial class Templates : Form
    {
        string pathDirectory = Environment.CurrentDirectory + "\\files";
        string template = Properties.Settings.Default.template.ToString();

        public Templates()
        {
            InitializeComponent();
            if (template == "openFileDialog1")
                template = "";

            if (template != "")
                ShowTemplate(template);
            else
                MessageBox.Show("Проблема с шаблоном, он потерялся, выберите его в ручную!");
            if (template != "")
            {
                string ss = template.Remove(0, (template.LastIndexOf('\\')) + 1);
                ss = ss.Remove(ss.IndexOf('.'));
                tbNameTemplate.Text = ss;
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (tbNameTemplate.Text == "")
            {
                MessageBox.Show("Не введено имя шаблона!");
                return;
            }

            string nameFile = "files\\" + tbNameTemplate.Text + ".template";

            if (File.Exists(nameFile))
                File.Delete(nameFile);

            int count = 0;
            StreamWriter writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            count = rtbMiniText.Lines.Length;
            for (int i = 0; rtbMiniText.Lines.Length > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbMiniText.Lines[i] == "")
                        break;
                }
                if (count - 1 == i)
                    writers.Write(rtbMiniText.Lines[i].ToString());
                else
                    writers.Write(rtbMiniText.Lines[i].ToString() + "\\r\\n");
            }
            writers.WriteLine("");
            writers.Close();

            writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            count = rtbFullText.Lines.Length;
            for (int i = 0; rtbFullText.Lines.Length > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbFullText.Lines[i] == "")
                        break;
                }
                if(count - 1 == i)
                    writers.Write(rtbFullText.Lines[i].ToString());
                else
                    writers.Write(rtbFullText.Lines[i].ToString() + "\\r\\n");
            }
            writers.WriteLine("");
            writers.Close();

            writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            writers.WriteLine(tbTitle.Lines[0] + "\\r\\n");
            writers.Close();

            writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            writers.WriteLine(tbDescription.Lines[0] + "\\r\\n");
            writers.Close();

            writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            writers.WriteLine(tbKeywords.Lines[0] + "\\r\\n");
            writers.Close();

            writers = new StreamWriter(nameFile, true, Encoding.GetEncoding(1251));
            count = rtbAltText.Lines.Length;
            for (int i = 0; rtbAltText.Lines.Length > i; i++)
            {
                if (count - 1 == i)
                {
                    if (rtbAltText.Lines[i] == "")
                        break;
                }
                if (count - 1 == i)
                    writers.Write(rtbAltText.Lines[i].ToString());
                else
                    writers.Write(rtbAltText.Lines[i].ToString() + "\\r\\n");
            }
            writers.WriteLine("");
            writers.Close();

            MessageBox.Show("OK");
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = pathDirectory;
            openFileDialog1.ShowDialog();
            string fileTemplate = openFileDialog1.FileName.ToString();
            tbNameTemplate.Text = Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName);
            ShowTemplate(fileTemplate);
        }

        #region///Кнопки редактирования шаблона
        private void btnBoldMini_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                rtbMiniText.SelectedText = rtbMiniText.SelectedText.Replace(rtbMiniText.SelectedText, "<b>" + rtbMiniText.SelectedText + "</b>");
            }
        }

        private void btnCenterMini_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                rtbMiniText.SelectedText = rtbMiniText.SelectedText.Replace(rtbMiniText.SelectedText, "<align center>" + rtbMiniText.SelectedText + "</align>");
            }
        }

        private void btnRigthMini_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                rtbMiniText.SelectedText = rtbMiniText.SelectedText.Replace(rtbMiniText.SelectedText, "<align rigth>" + rtbMiniText.SelectedText + "</align>");
            }
        }

        private void btnRigthFull_Click(object sender, EventArgs e)
        {
            if (rtbFullText.SelectedText != null)
            {
                rtbFullText.SelectedText = rtbFullText.SelectedText.Replace(rtbFullText.SelectedText, "<align rigth>" + rtbFullText.SelectedText + "</align>");
            }
        }

        private void btnCenterFull_Click(object sender, EventArgs e)
        {
            if (rtbFullText.SelectedText != null)
            {
                rtbFullText.SelectedText = rtbFullText.SelectedText.Replace(rtbFullText.SelectedText, "<align center>" + rtbFullText.SelectedText + "</align>");
            }
        }

        private void btnBoldFull_Click(object sender, EventArgs e)
        {
            if (rtbFullText.SelectedText != null)
            {
                rtbFullText.SelectedText = rtbFullText.SelectedText.Replace(rtbFullText.SelectedText, "<b>" + rtbFullText.SelectedText + "</b>");
            }
        }

        private void btnURLMini_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != "" & tbURLMini.Text != "" & tbURLMini.Text.Contains("http://"))
            {
                rtbMiniText.SelectedText = "<ссылка на =\"" + tbURLMini.Text + "\">" + rtbMiniText.SelectedText + "</ссылка>";
            }
            else
            {
                MessageBox.Show("Проверте выделен ли текст и заполнена ли ссылка");
            }
        }

        private void btnURLFull_Click(object sender, EventArgs e)
        {
            if (rtbFullText.SelectedText != "" & tbURLFull.Text != "" & tbURLFull.Text.Contains("http://"))
            {
                rtbFullText.SelectedText = "<ссылка на =\"" + tbURLFull.Text + "\">" + rtbFullText.SelectedText + "</ссылка>";
            }
            else
            {
                MessageBox.Show("Проверте выделен ли текст и заполнена ли ссылка");
            }
        }
        #endregion

        #region//Копирование ключевых слов в буфер обмена
        private void lblName_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("НАЗВАНИЕ");
        }

        private void lblArticl_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("АРТИКУЛ");
        }

        private void lblPrice_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("ЦЕНА");
        }

        private void lblCategory1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("РАЗДЕЛ1");
        }

        private void lblCategory2_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("РАЗДЕЛ2");
        }
        #endregion

        public void ShowTemplate(string fileTemplate)
        {
            string[] templateString = File.ReadAllLines(fileTemplate, Encoding.GetEncoding(1251));
            if (templateString.Length == 6)
            {
                rtbFullText.Clear();
                rtbMiniText.Clear();

                tbTitle.Text = templateString[2].ToString().Replace("\\r\\n", "");
                tbDescription.Text = templateString[3].ToString().Replace("\\r\\n", "");
                tbKeywords.Text = templateString[4].ToString().Replace("\\r\\n", "");
                string miniTextString = templateString[0].ToString().Replace("\\r\\n", "†");
                string[] miniText = miniTextString.Split('†');
                foreach (string str in miniText)
                {
                    rtbMiniText.AppendText(str + "\n");
                }
                string fullTextString = templateString[1].ToString().Replace("\\r\\n", "†");
                string[] fullText = fullTextString.Split('†');
                foreach (string str in fullText)
                {
                    rtbFullText.AppendText(str + "\n");
                }
                string altTextString = templateString[5].ToString().Replace("\\r\\n", "†");
                string[] altText = altTextString.Split('†');
                foreach (string str in altText)
                {
                    rtbAltText.AppendText(str + "\n");
                }
            }
            else
                MessageBox.Show("Некорректный файл, выберите другой");
        }
    }
}
