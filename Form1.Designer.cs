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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.chbMiniText = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbReplaceMiniText = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chbUrlArticle = new System.Windows.Forms.CheckBox();
            this.chbAlsoBuy = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chbReplaceFullText = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьШаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьШаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.rtbAltText.Size = new System.Drawing.Size(307, 457);
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
            this.rtbMiniText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbMiniText.Size = new System.Drawing.Size(305, 211);
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
            this.rtbFullText.Size = new System.Drawing.Size(302, 211);
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
            this.chbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTitle.AutoSize = true;
            this.chbTitle.Enabled = false;
            this.chbTitle.Location = new System.Drawing.Point(291, 58);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 12;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.chbTitle_CheckedChanged);
            // 
            // chbDescription
            // 
            this.chbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbDescription.AutoSize = true;
            this.chbDescription.Enabled = false;
            this.chbDescription.Location = new System.Drawing.Point(291, 97);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(15, 14);
            this.chbDescription.TabIndex = 13;
            this.chbDescription.UseVisualStyleBackColor = true;
            this.chbDescription.CheckedChanged += new System.EventHandler(this.chbDescription_CheckedChanged);
            this.chbDescription.EnabledChanged += new System.EventHandler(this.chbDescription_EnabledChanged);
            // 
            // chbKeywords
            // 
            this.chbKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbKeywords.AutoSize = true;
            this.chbKeywords.Enabled = false;
            this.chbKeywords.Location = new System.Drawing.Point(291, 136);
            this.chbKeywords.Name = "chbKeywords";
            this.chbKeywords.Size = new System.Drawing.Size(15, 14);
            this.chbKeywords.TabIndex = 14;
            this.chbKeywords.UseVisualStyleBackColor = true;
            this.chbKeywords.CheckedChanged += new System.EventHandler(this.chbKeywords_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(3, 202);
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
            this.tbURL.Text = "http://bike18.ru/products/category/1652579";
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
            this.panel2.Size = new System.Drawing.Size(313, 486);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chbReplaceMiniText);
            this.panel3.Controls.Add(this.chbMiniText);
            this.panel3.Controls.Add(this.rtbMiniText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(322, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 240);
            this.panel3.TabIndex = 22;
            // 
            // chbReplaceMiniText
            // 
            this.chbReplaceMiniText.AutoSize = true;
            this.chbReplaceMiniText.Enabled = false;
            this.chbReplaceMiniText.Location = new System.Drawing.Point(163, 3);
            this.chbReplaceMiniText.Name = "chbReplaceMiniText";
            this.chbReplaceMiniText.Size = new System.Drawing.Size(127, 17);
            this.chbReplaceMiniText.TabIndex = 21;
            this.chbReplaceMiniText.Text = "Заменить описание";
            this.chbReplaceMiniText.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 520);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tbURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 22);
            this.panel1.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPassword);
            this.panel5.Controls.Add(this.lblLogin);
            this.panel5.Controls.Add(this.tbPassword);
            this.panel5.Controls.Add(this.tbLogin);
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(641, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 240);
            this.panel5.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(168, 3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(3, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 24;
            this.lblLogin.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(171, 19);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(135, 20);
            this.tbPassword.TabIndex = 23;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(6, 19);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(135, 20);
            this.tbLogin.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chbUrlArticle);
            this.panel4.Controls.Add(this.chbAlsoBuy);
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
            this.panel4.Size = new System.Drawing.Size(315, 240);
            this.panel4.TabIndex = 23;
            // 
            // chbUrlArticle
            // 
            this.chbUrlArticle.AutoSize = true;
            this.chbUrlArticle.Location = new System.Drawing.Point(3, 180);
            this.chbUrlArticle.Name = "chbUrlArticle";
            this.chbUrlArticle.Size = new System.Drawing.Size(186, 17);
            this.chbUrlArticle.TabIndex = 16;
            this.chbUrlArticle.Text = "Добавлять к url артикул товара";
            this.chbUrlArticle.UseVisualStyleBackColor = true;
            // 
            // chbAlsoBuy
            // 
            this.chbAlsoBuy.AutoSize = true;
            this.chbAlsoBuy.Checked = true;
            this.chbAlsoBuy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAlsoBuy.Location = new System.Drawing.Point(3, 159);
            this.chbAlsoBuy.Name = "chbAlsoBuy";
            this.chbAlsoBuy.Size = new System.Drawing.Size(158, 17);
            this.chbAlsoBuy.TabIndex = 15;
            this.chbAlsoBuy.Text = "С этим товаром покупают";
            this.chbAlsoBuy.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(641, 495);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 22);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chbReplaceFullText);
            this.panel7.Controls.Add(this.rtbFullText);
            this.panel7.Controls.Add(this.chbFullText);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(322, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(313, 240);
            this.panel7.TabIndex = 26;
            // 
            // chbReplaceFullText
            // 
            this.chbReplaceFullText.AutoSize = true;
            this.chbReplaceFullText.Enabled = false;
            this.chbReplaceFullText.Location = new System.Drawing.Point(153, 3);
            this.chbReplaceFullText.Name = "chbReplaceFullText";
            this.chbReplaceFullText.Size = new System.Drawing.Size(166, 17);
            this.chbReplaceFullText.TabIndex = 22;
            this.chbReplaceFullText.Text = "Заменить полное описание";
            this.chbReplaceFullText.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьШаблонToolStripMenuItem,
            this.открытьШаблонToolStripMenuItem,
            this.tsmExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьШаблонToolStripMenuItem
            // 
            this.создатьШаблонToolStripMenuItem.Name = "создатьШаблонToolStripMenuItem";
            this.создатьШаблонToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.создатьШаблонToolStripMenuItem.Text = "Создать шаблон";
            this.создатьШаблонToolStripMenuItem.Click += new System.EventHandler(this.создатьШаблонToolStripMenuItem_Click);
            // 
            // открытьШаблонToolStripMenuItem
            // 
            this.открытьШаблонToolStripMenuItem.Name = "открытьШаблонToolStripMenuItem";
            this.открытьШаблонToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.открытьШаблонToolStripMenuItem.Text = "Открыть шаблон";
            this.открытьШаблонToolStripMenuItem.Click += new System.EventHandler(this.открытьШаблонToolStripMenuItem_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(169, 22);
            this.tsmExit.Text = "Выход";
            this.tsmExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Шаблон|*.template";
            this.openFileDialog1.InitialDirectory = "Environment.CurrentDirectory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(975, 423);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текст на сайте Bike18.ru";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.CheckBox chbMiniText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox chbAlsoBuy;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox chbReplaceMiniText;
        private System.Windows.Forms.CheckBox chbReplaceFullText;
        private System.Windows.Forms.CheckBox chbUrlArticle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьШаблонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem открытьШаблонToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

