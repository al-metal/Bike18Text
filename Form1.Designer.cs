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
            this.chbAddTextTovar = new System.Windows.Forms.CheckBox();
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
            // 
            // rtbAltText
            // 
            this.rtbAltText.Location = new System.Drawing.Point(12, 35);
            this.rtbAltText.Name = "rtbAltText";
            this.rtbAltText.Size = new System.Drawing.Size(310, 281);
            this.rtbAltText.TabIndex = 1;
            this.rtbAltText.Text = "";
            // 
            // chbAddTextTovar
            // 
            this.chbAddTextTovar.AutoSize = true;
            this.chbAddTextTovar.Location = new System.Drawing.Point(339, 12);
            this.chbAddTextTovar.Name = "chbAddTextTovar";
            this.chbAddTextTovar.Size = new System.Drawing.Size(202, 17);
            this.chbAddTextTovar.TabIndex = 2;
            this.chbAddTextTovar.Text = "Добавить текст в карточку товара";
            this.chbAddTextTovar.UseVisualStyleBackColor = true;
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
            // 
            // rtbMiniText
            // 
            this.rtbMiniText.Location = new System.Drawing.Point(339, 35);
            this.rtbMiniText.Name = "rtbMiniText";
            this.rtbMiniText.Size = new System.Drawing.Size(310, 127);
            this.rtbMiniText.TabIndex = 4;
            this.rtbMiniText.Text = "";
            // 
            // rtbFullText
            // 
            this.rtbFullText.Location = new System.Drawing.Point(339, 189);
            this.rtbFullText.Name = "rtbFullText";
            this.rtbFullText.Size = new System.Drawing.Size(310, 127);
            this.rtbFullText.TabIndex = 5;
            this.rtbFullText.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(673, 50);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(242, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(673, 96);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(242, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // tbKeywords
            // 
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
            this.chbTitle.Location = new System.Drawing.Point(921, 53);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 12;
            this.chbTitle.UseVisualStyleBackColor = true;
            // 
            // chbDescription
            // 
            this.chbDescription.AutoSize = true;
            this.chbDescription.Location = new System.Drawing.Point(921, 99);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(15, 14);
            this.chbDescription.TabIndex = 13;
            this.chbDescription.UseVisualStyleBackColor = true;
            // 
            // chbKeywords
            // 
            this.chbKeywords.AutoSize = true;
            this.chbKeywords.Location = new System.Drawing.Point(921, 145);
            this.chbKeywords.Name = "chbKeywords";
            this.chbKeywords.Size = new System.Drawing.Size(15, 14);
            this.chbKeywords.TabIndex = 14;
            this.chbKeywords.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 384);
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
            this.Controls.Add(this.chbAddTextTovar);
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
        private System.Windows.Forms.CheckBox chbAddTextTovar;
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
    }
}

