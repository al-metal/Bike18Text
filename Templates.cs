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
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if(tbNameTemplate.Text == "")
            {
                MessageBox.Show("Не введено имя шаблона!");
                return;
            }

            string nameFile = "files\\" + tbNameTemplate.Text + ".template";

            if (File.Exists(nameFile))
            {
                File.Delete(nameFile);
            }

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

        private void btnBoldMini_Click(object sender, EventArgs e)
        {
            if (rtbMiniText.SelectedText != null)
            {
                if (rtbMiniText.SelectionFont.Bold != true)
                {
                    rtbMiniText.SelectedText = rtbMiniText.SelectedText.Replace(rtbMiniText.SelectedText, "<b>" + rtbMiniText.SelectedText + "</b>");
                }
            }
        }



        public void ShowTemplate(string fileTemplate)
        {
            string[] templateString = File.ReadAllLines(fileTemplate, Encoding.GetEncoding(1251));
            if (templateString.Length == 5)
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
            }
            else
                MessageBox.Show("Некорректный файл, выберите другой");
        }

        
    }
}
