namespace Bike18Text
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbAltText = new System.Windows.Forms.CheckBox();
            this.rtbAltText = new System.Windows.Forms.RichTextBox();
            this.chbFullText = new System.Windows.Forms.CheckBox();
            this.chbSEO = new System.Windows.Forms.CheckBox();
            this.rtbMiniText = new System.Windows.Forms.RichTextBox();
            this.rtbFullText = new System.Windows.Forms.RichTextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.chbDescription = new System.Windows.Forms.CheckBox();
            this.chbKeywords = new System.Windows.Forms.CheckBox();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.chbMiniText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbAltText
            // 
            this.chbAltText.AutoSize = true;
            this.chbAltText.Location = new System.Drawing.Point(12, 12);
            this.chbAltText.Name = "chbAltText";
            this.chbAltText.Size = new System.Drawing.Size(142, 17);
            this.chbAltText.TabIndex = 0;
            this.chbAltText.Text = "Альтернативный текст";
            this.chbAltText.UseVisualStyleBackColor = true;
            this.chbAltText.CheckedChanged += new System.EventHandler(this.chbAltText_CheckedChanged);
            // 
            // rtbAltText
            // 
            this.rtbAltText.Enabled = false;
            this.rtbAltText.Location = new System.Drawing.Point(12, 35);
            this.rtbAltText.Name = "rtbAltText";
            this.rtbAltText.Size = new System.Drawing.Size(310, 281);
            this.rtbAltText.TabIndex = 1;
            this.rtbAltText.Text = "";
            // 
            // chbFullText
            // 
            this.chbFullText.AutoSize = true;
            this.chbFullText.Location = new System.Drawing.Point(339, 168);
            this.chbFullText.Name = "chbFullText";
            this.chbFullText.Size = new System.Drawing.Size(153, 17);
            this.chbFullText.TabIndex = 2;
            this.chbFullText.Text = "Полное описание товара";
            this.chbFullText.UseVisualStyleBackColor = true;
            this.chbFullText.CheckedChanged += new System.EventHandler(this.chbAddTextTovar_CheckedChanged);
            // 
            // chbSEO
            // 
            this.chbSEO.AutoSize = true;
            this.chbSEO.Location = new System.Drawing.Point(663, 12);
            this.chbSEO.Name = "chbSEO";
            this.chbSEO.Size = new System.Drawing.Size(113, 17);
            this.chbSEO.TabIndex = 3;
            this.chbSEO.Text = "СЕО поля товара";
            this.chbSEO.UseVisualStyleBackColor = true;
            this.chbSEO.CheckedChanged += new System.EventHandler(this.chbSEO_CheckedChanged);
            // 
            // rtbMiniText
            // 
            this.rtbMiniText.Enabled = false;
            this.rtbMiniText.Location = new System.Drawing.Point(339, 35);
            this.rtbMiniText.Name = "rtbMiniText";
            this.rtbMiniText.Size = new System.Drawing.Size(310, 127);
            this.rtbMiniText.TabIndex = 4;
            this.rtbMiniText.Text = "";
            // 
            // rtbFullText
            // 
            this.rtbFullText.Enabled = false;
            this.rtbFullText.Location = new System.Drawing.Point(339, 189);
            this.rtbFullText.Name = "rtbFullText";
            this.rtbFullText.Size = new System.Drawing.Size(310, 127);
            this.rtbFullText.TabIndex = 5;
            this.rtbFullText.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Enabled = false;
            this.tbTitle.Location = new System.Drawing.Point(673, 50);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(242, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(673, 96);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(242, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // tbKeywords
            // 
            this.tbKeywords.Enabled = false;
            this.tbKeywords.Location = new System.Drawing.Point(673, 142);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(242, 20);
            this.tbKeywords.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ключевые слова";
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Enabled = false;
            this.chbTitle.Location = new System.Drawing.Point(921, 53);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 12;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.chbTitle_CheckedChanged);
            // 
            // chbDescription
            // 
            this.chbDescription.AutoSize = true;
            this.chbDescription.Enabled = false;
            this.chbDescription.Location = new System.Drawing.Point(921, 99);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(15, 14);
            this.chbDescription.TabIndex = 13;
            this.chbDescription.UseVisualStyleBackColor = true;
            this.chbDescription.CheckedChanged += new System.EventHandler(this.chbDescription_CheckedChanged);
            this.chbDescription.EnabledChanged += new System.EventHandler(this.chbDescription_EnabledChanged);
            // 
            // chbKeywords
            // 
            this.chbKeywords.AutoSize = true;
            this.chbKeywords.Enabled = false;
            this.chbKeywords.Location = new System.Drawing.Point(921, 145);
            this.chbKeywords.Name = "chbKeywords";
            this.chbKeywords.Size = new System.Drawing.Size(15, 14);
            this.chbKeywords.TabIndex = 14;
            this.chbKeywords.UseVisualStyleBackColor = true;
            this.chbKeywords.CheckedChanged += new System.EventHandler(this.chbKeywords_CheckedChanged);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(675, 194);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(239, 37);
            this.btnSaveText.TabIndex = 15;
            this.btnSaveText.Text = "Сохранить текст";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(676, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 37);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Обработать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 338);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(637, 20);
            this.tbURL.TabIndex = 17;
            this.tbURL.Text = "http://bike18.nethouse.ru/products/category/1364365";
            // 
            // chbMiniText
            // 
            this.chbMiniText.AutoSize = true;
            this.chbMiniText.Location = new System.Drawing.Point(339, 12);
            this.chbMiniText.Name = "chbMiniText";
            this.chbMiniText.Size = new System.Drawing.Size(157, 17);
            this.chbMiniText.TabIndex = 18;
            this.chbMiniText.Text = "Краткое описание товара";
            this.chbMiniText.UseVisualStyleBackColor = true;
            this.chbMiniText.CheckedChanged += new System.EventHandler(this.chbFullText_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 384);
            this.Controls.Add(this.chbMiniText);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.chbKeywords);
            this.Controls.Add(this.chbDescription);
            this.Controls.Add(this.chbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.rtbFullText);
            this.Controls.Add(this.rtbMiniText);
            this.Controls.Add(this.chbSEO);
            this.Controls.Add(this.chbFullText);
            this.Controls.Add(this.rtbAltText);
            this.Controls.Add(this.chbAltText);
            this.Name = "Form1";
            this.Text = "Текст на сайте Bike18.ru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbAltText;
        private System.Windows.Forms.RichTextBox rtbAltText;
        private System.Windows.Forms.CheckBox chbFullText;
        private System.Windows.Forms.CheckBox chbSEO;
        private System.Windows.Forms.RichTextBox rtbMiniText;
        private System.Windows.Forms.RichTextBox rtbFullText;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.CheckBox chbDescription;
        private System.Windows.Forms.CheckBox chbKeywords;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.CheckBox chbMiniText;
    }
}

