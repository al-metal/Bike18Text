namespace Bike18
{
    partial class Templates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templates));
            this.rtbMiniText = new System.Windows.Forms.RichTextBox();
            this.rtbFullText = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.tbNameTemplate = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnOpenTemplate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBoldMini = new System.Windows.Forms.Button();
            this.btnCenterMini = new System.Windows.Forms.Button();
            this.btnRigthMini = new System.Windows.Forms.Button();
            this.btnURLMini = new System.Windows.Forms.Button();
            this.tbURLMini = new System.Windows.Forms.TextBox();
            this.tbURLFull = new System.Windows.Forms.TextBox();
            this.btnURLFull = new System.Windows.Forms.Button();
            this.btnRigthFull = new System.Windows.Forms.Button();
            this.btnCenterFull = new System.Windows.Forms.Button();
            this.btnBoldFull = new System.Windows.Forms.Button();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblArticl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbAltText = new System.Windows.Forms.RichTextBox();
            this.btnEmMini = new System.Windows.Forms.Button();
            this.btnEmFull = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rtbMiniText
            // 
            this.rtbMiniText.Location = new System.Drawing.Point(12, 20);
            this.rtbMiniText.Name = "rtbMiniText";
            this.rtbMiniText.Size = new System.Drawing.Size(607, 205);
            this.rtbMiniText.TabIndex = 0;
            this.rtbMiniText.Text = "";
            this.toolTip1.SetToolTip(this.rtbMiniText, "Краткий текст карточки товара");
            // 
            // rtbFullText
            // 
            this.rtbFullText.Location = new System.Drawing.Point(12, 274);
            this.rtbFullText.Name = "rtbFullText";
            this.rtbFullText.Size = new System.Drawing.Size(607, 211);
            this.rtbFullText.TabIndex = 1;
            this.rtbFullText.Text = "";
            this.toolTip1.SetToolTip(this.rtbFullText, "Полный текст карточки товара");
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(628, 24);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(365, 20);
            this.tbTitle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbTitle, "Заголовок товара (title)");
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(628, 70);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(365, 20);
            this.tbDescription.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbDescription, "Описание товара (description)");
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(628, 111);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(365, 20);
            this.tbKeywords.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbKeywords, "Ключевые слова товара (keywords)");
            // 
            // tbNameTemplate
            // 
            this.tbNameTemplate.Location = new System.Drawing.Point(628, 151);
            this.tbNameTemplate.Name = "tbNameTemplate";
            this.tbNameTemplate.Size = new System.Drawing.Size(192, 20);
            this.tbNameTemplate.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbNameTemplate, "Название шаблона");
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(826, 149);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(167, 23);
            this.btnSaveTemplate.TabIndex = 6;
            this.btnSaveTemplate.Text = "Сохранить шаблон";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnOpenTemplate
            // 
            this.btnOpenTemplate.Location = new System.Drawing.Point(826, 178);
            this.btnOpenTemplate.Name = "btnOpenTemplate";
            this.btnOpenTemplate.Size = new System.Drawing.Size(167, 23);
            this.btnOpenTemplate.TabIndex = 7;
            this.btnOpenTemplate.Text = "Открыть шаблон";
            this.btnOpenTemplate.UseVisualStyleBackColor = true;
            this.btnOpenTemplate.Click += new System.EventHandler(this.btnOpenTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Шаблон|*.template";
            // 
            // btnBoldMini
            // 
            this.btnBoldMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoldMini.Location = new System.Drawing.Point(12, 231);
            this.btnBoldMini.Name = "btnBoldMini";
            this.btnBoldMini.Size = new System.Drawing.Size(30, 23);
            this.btnBoldMini.TabIndex = 8;
            this.btnBoldMini.Text = "b";
            this.toolTip1.SetToolTip(this.btnBoldMini, "Текст который был выделен в карточке товара быдет жирным");
            this.btnBoldMini.UseVisualStyleBackColor = true;
            this.btnBoldMini.Click += new System.EventHandler(this.btnBoldMini_Click);
            // 
            // btnCenterMini
            // 
            this.btnCenterMini.Location = new System.Drawing.Point(84, 231);
            this.btnCenterMini.Name = "btnCenterMini";
            this.btnCenterMini.Size = new System.Drawing.Size(30, 23);
            this.btnCenterMini.TabIndex = 9;
            this.btnCenterMini.Text = "C";
            this.toolTip1.SetToolTip(this.btnCenterMini, "Текст который был выделен в карточке товара быдет расположен по центру");
            this.btnCenterMini.UseVisualStyleBackColor = true;
            this.btnCenterMini.Click += new System.EventHandler(this.btnCenterMini_Click);
            // 
            // btnRigthMini
            // 
            this.btnRigthMini.Location = new System.Drawing.Point(120, 231);
            this.btnRigthMini.Name = "btnRigthMini";
            this.btnRigthMini.Size = new System.Drawing.Size(30, 23);
            this.btnRigthMini.TabIndex = 10;
            this.btnRigthMini.Text = "R";
            this.toolTip1.SetToolTip(this.btnRigthMini, "Текст который был выделен в карточке товара быдет расположен справа");
            this.btnRigthMini.UseVisualStyleBackColor = true;
            this.btnRigthMini.Click += new System.EventHandler(this.btnRigthMini_Click);
            // 
            // btnURLMini
            // 
            this.btnURLMini.Location = new System.Drawing.Point(156, 231);
            this.btnURLMini.Name = "btnURLMini";
            this.btnURLMini.Size = new System.Drawing.Size(30, 23);
            this.btnURLMini.TabIndex = 11;
            this.btnURLMini.Text = "U";
            this.toolTip1.SetToolTip(this.btnURLMini, "Выделенный текст будет ссылкой");
            this.btnURLMini.UseVisualStyleBackColor = true;
            this.btnURLMini.Click += new System.EventHandler(this.btnURLMini_Click);
            // 
            // tbURLMini
            // 
            this.tbURLMini.Location = new System.Drawing.Point(192, 233);
            this.tbURLMini.Name = "tbURLMini";
            this.tbURLMini.Size = new System.Drawing.Size(427, 20);
            this.tbURLMini.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tbURLMini, "Данный текст является ссылкой для выделенного текста в редакторе и должен начинат" +
        "ься с \"http://\" или \"https://\".");
            // 
            // tbURLFull
            // 
            this.tbURLFull.Location = new System.Drawing.Point(192, 491);
            this.tbURLFull.Name = "tbURLFull";
            this.tbURLFull.Size = new System.Drawing.Size(427, 20);
            this.tbURLFull.TabIndex = 17;
            this.toolTip1.SetToolTip(this.tbURLFull, "Данный текст является ссылкой для выделенного текста в редакторе и должен начинат" +
        "ься с \"http://\" или \"https://\".");
            // 
            // btnURLFull
            // 
            this.btnURLFull.Location = new System.Drawing.Point(156, 489);
            this.btnURLFull.Name = "btnURLFull";
            this.btnURLFull.Size = new System.Drawing.Size(30, 23);
            this.btnURLFull.TabIndex = 16;
            this.btnURLFull.Text = "U";
            this.toolTip1.SetToolTip(this.btnURLFull, "Выделенный текст будет ссылкой");
            this.btnURLFull.UseVisualStyleBackColor = true;
            this.btnURLFull.Click += new System.EventHandler(this.btnURLFull_Click);
            // 
            // btnRigthFull
            // 
            this.btnRigthFull.Location = new System.Drawing.Point(120, 489);
            this.btnRigthFull.Name = "btnRigthFull";
            this.btnRigthFull.Size = new System.Drawing.Size(30, 23);
            this.btnRigthFull.TabIndex = 15;
            this.btnRigthFull.Text = "R";
            this.toolTip1.SetToolTip(this.btnRigthFull, "Текст который был выделен в карточке товара быдет расположен справа");
            this.btnRigthFull.UseVisualStyleBackColor = true;
            this.btnRigthFull.Click += new System.EventHandler(this.btnRigthFull_Click);
            // 
            // btnCenterFull
            // 
            this.btnCenterFull.Location = new System.Drawing.Point(84, 489);
            this.btnCenterFull.Name = "btnCenterFull";
            this.btnCenterFull.Size = new System.Drawing.Size(30, 23);
            this.btnCenterFull.TabIndex = 14;
            this.btnCenterFull.Text = "C";
            this.toolTip1.SetToolTip(this.btnCenterFull, "Текст который был выделен в карточке товара быдет расположен по центру");
            this.btnCenterFull.UseVisualStyleBackColor = true;
            this.btnCenterFull.Click += new System.EventHandler(this.btnCenterFull_Click);
            // 
            // btnBoldFull
            // 
            this.btnBoldFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoldFull.Location = new System.Drawing.Point(12, 489);
            this.btnBoldFull.Name = "btnBoldFull";
            this.btnBoldFull.Size = new System.Drawing.Size(30, 23);
            this.btnBoldFull.TabIndex = 13;
            this.btnBoldFull.Text = "b";
            this.toolTip1.SetToolTip(this.btnBoldFull, "Текст который был выделен в карточке товара быдет жирным");
            this.btnBoldFull.UseVisualStyleBackColor = true;
            this.btnBoldFull.Click += new System.EventHandler(this.btnBoldFull_Click);
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Location = new System.Drawing.Point(628, 274);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(258, 13);
            this.lblCategory2.TabIndex = 26;
            this.lblCategory2.Text = "РАЗДЕЛ2 - раздел в котором находится раздел1";
            this.toolTip1.SetToolTip(this.lblCategory2, "При нажатии на данную строку в буфер будет добавлено слово \"РАЗДЕЛ2\"");
            this.lblCategory2.Click += new System.EventHandler(this.lblCategory2_Click_1);
            this.lblCategory2.DoubleClick += new System.EventHandler(this.lblCategory2_DoubleClick);
            // 
            // lblCategory1
            // 
            this.lblCategory1.AutoSize = true;
            this.lblCategory1.Location = new System.Drawing.Point(628, 251);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(245, 13);
            this.lblCategory1.TabIndex = 25;
            this.lblCategory1.Text = "РАЗДЕЛ1 - раздел в котором находится товар";
            this.toolTip1.SetToolTip(this.lblCategory1, "При нажатии на данную строку в буфер будет добавлено слово \"РАЗДЕЛ1\"");
            this.lblCategory1.Click += new System.EventHandler(this.lblCategory1_Click_1);
            this.lblCategory1.DoubleClick += new System.EventHandler(this.lblCategory1_DoubleClick);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(628, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 13);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "ЦЕНА - стоимость товара";
            this.toolTip1.SetToolTip(this.lblPrice, "При нажатии на данную строку в буфер будет добавлено слово \"ЦЕНА\"");
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click_1);
            this.lblPrice.DoubleClick += new System.EventHandler(this.lblPrice_DoubleClick);
            // 
            // lblArticl
            // 
            this.lblArticl.AutoSize = true;
            this.lblArticl.Location = new System.Drawing.Point(628, 207);
            this.lblArticl.Name = "lblArticl";
            this.lblArticl.Size = new System.Drawing.Size(146, 13);
            this.lblArticl.TabIndex = 23;
            this.lblArticl.Text = "АРТИКУЛ - артикул товара";
            this.toolTip1.SetToolTip(this.lblArticl, "При нажатии на данную строку в буфер будет добавлено слово \"АРТИКУЛ\"");
            this.lblArticl.Click += new System.EventHandler(this.lblArticl_Click_1);
            this.lblArticl.DoubleClick += new System.EventHandler(this.lblArticl_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(628, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "НАЗВАНИЕ - наименование товара";
            this.toolTip1.SetToolTip(this.lblName, "При нажатии на данную строку в буфер будет добавлено слово \"НАЗВАНИЕ\"");
            this.lblName.Click += new System.EventHandler(this.lblName_Click_1);
            this.lblName.DoubleClick += new System.EventHandler(this.lblName_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ключевые слова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Заголовок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Название шаблона";
            // 
            // rtbAltText
            // 
            this.rtbAltText.Location = new System.Drawing.Point(628, 310);
            this.rtbAltText.Name = "rtbAltText";
            this.rtbAltText.Size = new System.Drawing.Size(365, 202);
            this.rtbAltText.TabIndex = 31;
            this.rtbAltText.Text = "";
            this.toolTip1.SetToolTip(this.rtbAltText, "Каждая строка является отдльным текстом для картинки");
            // 
            // btnEmMini
            // 
            this.btnEmMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmMini.Location = new System.Drawing.Point(48, 231);
            this.btnEmMini.Name = "btnEmMini";
            this.btnEmMini.Size = new System.Drawing.Size(30, 23);
            this.btnEmMini.TabIndex = 32;
            this.btnEmMini.Text = "em";
            this.toolTip1.SetToolTip(this.btnEmMini, "Текст который был выделен в карточке товара быдет курсивом");
            this.btnEmMini.UseVisualStyleBackColor = true;
            this.btnEmMini.Click += new System.EventHandler(this.btnEmMini_Click);
            // 
            // btnEmFull
            // 
            this.btnEmFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmFull.Location = new System.Drawing.Point(48, 489);
            this.btnEmFull.Name = "btnEmFull";
            this.btnEmFull.Size = new System.Drawing.Size(30, 23);
            this.btnEmFull.TabIndex = 33;
            this.btnEmFull.Text = "em";
            this.toolTip1.SetToolTip(this.btnEmFull, "Текст который был выделен в карточке товара быдет курсивом");
            this.btnEmFull.UseVisualStyleBackColor = true;
            this.btnEmFull.Click += new System.EventHandler(this.btnEmFull_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Альтернативный текст для изображений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Краткий текст карточки товара";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Полный текст карточки товара";
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEmFull);
            this.Controls.Add(this.btnEmMini);
            this.Controls.Add(this.rtbAltText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory2);
            this.Controls.Add(this.lblCategory1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArticl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbURLFull);
            this.Controls.Add(this.btnURLFull);
            this.Controls.Add(this.btnRigthFull);
            this.Controls.Add(this.btnCenterFull);
            this.Controls.Add(this.btnBoldFull);
            this.Controls.Add(this.tbURLMini);
            this.Controls.Add(this.btnURLMini);
            this.Controls.Add(this.btnRigthMini);
            this.Controls.Add(this.btnCenterMini);
            this.Controls.Add(this.btnBoldMini);
            this.Controls.Add(this.btnOpenTemplate);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.tbNameTemplate);
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.rtbFullText);
            this.Controls.Add(this.rtbMiniText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с шаблоном";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMiniText;
        private System.Windows.Forms.RichTextBox rtbFullText;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.TextBox tbNameTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnOpenTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBoldMini;
        private System.Windows.Forms.Button btnCenterMini;
        private System.Windows.Forms.Button btnRigthMini;
        private System.Windows.Forms.Button btnURLMini;
        private System.Windows.Forms.TextBox tbURLMini;
        private System.Windows.Forms.TextBox tbURLFull;
        private System.Windows.Forms.Button btnURLFull;
        private System.Windows.Forms.Button btnRigthFull;
        private System.Windows.Forms.Button btnCenterFull;
        private System.Windows.Forms.Button btnBoldFull;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblArticl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbAltText;
        private System.Windows.Forms.Button btnEmMini;
        private System.Windows.Forms.Button btnEmFull;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}