using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike18Text
{
    public partial class Templates : Form
    {
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
                MessageBox.Show("Данный шаблон уже существует");
                return;
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
    }
}
