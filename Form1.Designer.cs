﻿namespace Bike18Text
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMiniTextBold = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbAltText
            // 
            this.chbAltText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAltText.AutoSize = true;
            this.chbAltText.Location = new System.Drawing.Point(3, 3);
            this.chbAltText.Name = "chbAltText";
            this.chbAltText.Size = new System.Drawing.Size(142, 17);
            this.chbAltText.TabIndex = 0;
            this.chbAltText.Text = "Альтернативный текст";
            this.chbAltText.UseVisualStyleBackColor = true;
            this.chbAltText.CheckedChanged += new System.EventHandler(this.chbAltText_CheckedChanged);
            // 
            // rtbAltText
            // 
            this.rtbAltText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAltText.Enabled = false;
            this.rtbAltText.Location = new System.Drawing.Point(3, 26);
            this.rtbAltText.Name = "rtbAltText";
            this.rtbAltText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbAltText.Size = new System.Drawing.Size(307, 421);
            this.rtbAltText.TabIndex = 1;
            this.rtbAltText.Text = "";
            // 
            // chbFullText
            // 
            this.chbFullText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFullText.AutoSize = true;
            this.chbFullText.Location = new System.Drawing.Point(3, 3);
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
            this.chbSEO.Location = new System.Drawing.Point(3, 9);
            this.chbSEO.Name = "chbSEO";
            this.chbSEO.Size = new System.Drawing.Size(113, 17);
            this.chbSEO.TabIndex = 3;
            this.chbSEO.Text = "СЕО поля товара";
            this.chbSEO.UseVisualStyleBackColor = true;
            this.chbSEO.CheckedChanged += new System.EventHandler(this.chbSEO_CheckedChanged);
            // 
            // rtbMiniText
            // 
            this.rtbMiniText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMiniText.Enabled = false;
            this.rtbMiniText.Location = new System.Drawing.Point(0, 26);
            this.rtbMiniText.Name = "rtbMiniText";
            this.rtbMiniText.Size = new System.Drawing.Size(305, 173);
            this.rtbMiniText.TabIndex = 4;
            this.rtbMiniText.Text = "";
            // 
            // rtbFullText
            // 
            this.rtbFullText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFullText.Enabled = false;
            this.rtbFullText.Location = new System.Drawing.Point(3, 26);
            this.rtbFullText.Name = "rtbFullText";
            this.rtbFullText.Size = new System.Drawing.Size(302, 175);
            this.rtbFullText.TabIndex = 5;
            this.rtbFullText.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Enabled = false;
            this.tbTitle.Location = new System.Drawing.Point(11, 55);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(274, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(11, 94);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(274, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // tbKeywords
            // 
            this.tbKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeywords.Enabled = false;
            this.tbKeywords.Location = new System.Drawing.Point(11, 133);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(274, 20);
            this.tbKeywords.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ключевые слова";
            // 
            // chbTitle
            // 
            this.chbTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbTitle.AutoSize = true;
            this.chbTitle.Enabled = false;
            this.chbTitle.Location = new System.Drawing.Point(291, 64);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 12;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.chbTitle_CheckedChanged);
            // 
            // chbDescription
            // 
            this.chbDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbDescription.AutoSize = true;
            this.chbDescription.Enabled = false;
            this.chbDescription.Location = new System.Drawing.Point(291, 103);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(15, 14);
            this.chbDescription.TabIndex = 13;
            this.chbDescription.UseVisualStyleBackColor = true;
            this.chbDescription.CheckedChanged += new System.EventHandler(this.chbDescription_CheckedChanged);
            this.chbDescription.EnabledChanged += new System.EventHandler(this.chbDescription_EnabledChanged);
            // 
            // chbKeywords
            // 
            this.chbKeywords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbKeywords.AutoSize = true;
            this.chbKeywords.Enabled = false;
            this.chbKeywords.Location = new System.Drawing.Point(291, 139);
            this.chbKeywords.Name = "chbKeywords";
            this.chbKeywords.Size = new System.Drawing.Size(15, 14);
            this.chbKeywords.TabIndex = 14;
            this.chbKeywords.UseVisualStyleBackColor = true;
            this.chbKeywords.CheckedChanged += new System.EventHandler(this.chbKeywords_CheckedChanged);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveText.Location = new System.Drawing.Point(0, 0);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(315, 20);
            this.btnSaveText.TabIndex = 15;
            this.btnSaveText.Text = "Сохранить текст";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(3, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(309, 35);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Обработать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbURL
            // 
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbURL.Location = new System.Drawing.Point(0, 0);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(632, 20);
            this.tbURL.TabIndex = 17;
            this.tbURL.Text = "http://bike18.nethouse.ru/products/category/1364365";
            // 
            // chbMiniText
            // 
            this.chbMiniText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMiniText.AutoSize = true;
            this.chbMiniText.Location = new System.Drawing.Point(0, 3);
            this.chbMiniText.Name = "chbMiniText";
            this.chbMiniText.Size = new System.Drawing.Size(157, 17);
            this.chbMiniText.TabIndex = 18;
            this.chbMiniText.Text = "Краткое описание товара";
            this.chbMiniText.UseVisualStyleBackColor = true;
            this.chbMiniText.CheckedChanged += new System.EventHandler(this.chbFullText_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbAltText);
            this.panel2.Controls.Add(this.rtbAltText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(313, 450);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMiniTextBold);
            this.panel3.Controls.Add(this.chbMiniText);
            this.panel3.Controls.Add(this.rtbMiniText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(322, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 222);
            this.panel3.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 482);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tbURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 20);
            this.panel1.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(641, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 222);
            this.panel5.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chbKeywords);
            this.panel4.Controls.Add(this.chbDescription);
            this.panel4.Controls.Add(this.chbTitle);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbKeywords);
            this.panel4.Controls.Add(this.tbDescription);
            this.panel4.Controls.Add(this.tbTitle);
            this.panel4.Controls.Add(this.chbSEO);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(641, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 222);
            this.panel4.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSaveText);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(641, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 20);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rtbFullText);
            this.panel7.Controls.Add(this.chbFullText);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(322, 231);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(313, 222);
            this.panel7.TabIndex = 26;
            // 
            // btnMiniTextBold
            // 
            this.btnMiniTextBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMiniTextBold.Location = new System.Drawing.Point(3, 199);
            this.btnMiniTextBold.Name = "btnMiniTextBold";
            this.btnMiniTextBold.Size = new System.Drawing.Size(21, 20);
            this.btnMiniTextBold.TabIndex = 19;
            this.btnMiniTextBold.Text = "B";
            this.btnMiniTextBold.UseVisualStyleBackColor = true;
            this.btnMiniTextBold.Click += new System.EventHandler(this.btnMiniTextBold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(975, 423);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Текст на сайте Bike18.ru";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMiniTextBold;
    }
}

