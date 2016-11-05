namespace Bike18Text
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
            this.SuspendLayout();
            // 
            // rtbMiniText
            // 
            this.rtbMiniText.Location = new System.Drawing.Point(12, 20);
            this.rtbMiniText.Name = "rtbMiniText";
            this.rtbMiniText.Size = new System.Drawing.Size(379, 205);
            this.rtbMiniText.TabIndex = 0;
            this.rtbMiniText.Text = "";
            // 
            // rtbFullText
            // 
            this.rtbFullText.Location = new System.Drawing.Point(12, 260);
            this.rtbFullText.Name = "rtbFullText";
            this.rtbFullText.Size = new System.Drawing.Size(379, 194);
            this.rtbFullText.TabIndex = 1;
            this.rtbFullText.Text = "";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(397, 20);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(365, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(397, 66);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(365, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(397, 107);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(365, 20);
            this.tbKeywords.TabIndex = 4;
            // 
            // tbNameTemplate
            // 
            this.tbNameTemplate.Location = new System.Drawing.Point(397, 147);
            this.tbNameTemplate.Name = "tbNameTemplate";
            this.tbNameTemplate.Size = new System.Drawing.Size(192, 20);
            this.tbNameTemplate.TabIndex = 5;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(595, 147);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(167, 20);
            this.btnSaveTemplate.TabIndex = 6;
            this.btnSaveTemplate.Text = "Сохранить шаблон";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnOpenTemplate
            // 
            this.btnOpenTemplate.Location = new System.Drawing.Point(397, 173);
            this.btnOpenTemplate.Name = "btnOpenTemplate";
            this.btnOpenTemplate.Size = new System.Drawing.Size(192, 23);
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
            this.btnBoldMini.Location = new System.Drawing.Point(12, 231);
            this.btnBoldMini.Name = "btnBoldMini";
            this.btnBoldMini.Size = new System.Drawing.Size(22, 23);
            this.btnBoldMini.TabIndex = 8;
            this.btnBoldMini.Text = "b";
            this.btnBoldMini.UseVisualStyleBackColor = true;
            this.btnBoldMini.Click += new System.EventHandler(this.btnBoldMini_Click);
            // 
            // btnCenterMini
            // 
            this.btnCenterMini.Location = new System.Drawing.Point(40, 231);
            this.btnCenterMini.Name = "btnCenterMini";
            this.btnCenterMini.Size = new System.Drawing.Size(22, 23);
            this.btnCenterMini.TabIndex = 9;
            this.btnCenterMini.Text = "C";
            this.btnCenterMini.UseVisualStyleBackColor = true;
            this.btnCenterMini.Click += new System.EventHandler(this.btnCenterMini_Click);
            // 
            // btnRigthMini
            // 
            this.btnRigthMini.Location = new System.Drawing.Point(68, 231);
            this.btnRigthMini.Name = "btnRigthMini";
            this.btnRigthMini.Size = new System.Drawing.Size(22, 23);
            this.btnRigthMini.TabIndex = 10;
            this.btnRigthMini.Text = "R";
            this.btnRigthMini.UseVisualStyleBackColor = true;
            this.btnRigthMini.Click += new System.EventHandler(this.btnRigthMini_Click);
            // 
            // btnURLMini
            // 
            this.btnURLMini.Location = new System.Drawing.Point(96, 231);
            this.btnURLMini.Name = "btnURLMini";
            this.btnURLMini.Size = new System.Drawing.Size(22, 23);
            this.btnURLMini.TabIndex = 11;
            this.btnURLMini.Text = "U";
            this.btnURLMini.UseVisualStyleBackColor = true;
            this.btnURLMini.Click += new System.EventHandler(this.btnURLMini_Click);
            // 
            // tbURLMini
            // 
            this.tbURLMini.Location = new System.Drawing.Point(124, 233);
            this.tbURLMini.Name = "tbURLMini";
            this.tbURLMini.Size = new System.Drawing.Size(267, 20);
            this.tbURLMini.TabIndex = 12;
            // 
            // tbURLFull
            // 
            this.tbURLFull.Location = new System.Drawing.Point(124, 460);
            this.tbURLFull.Name = "tbURLFull";
            this.tbURLFull.Size = new System.Drawing.Size(267, 20);
            this.tbURLFull.TabIndex = 17;
            // 
            // btnURLFull
            // 
            this.btnURLFull.Location = new System.Drawing.Point(96, 458);
            this.btnURLFull.Name = "btnURLFull";
            this.btnURLFull.Size = new System.Drawing.Size(22, 23);
            this.btnURLFull.TabIndex = 16;
            this.btnURLFull.Text = "U";
            this.btnURLFull.UseVisualStyleBackColor = true;
            this.btnURLFull.Click += new System.EventHandler(this.btnURLFull_Click);
            // 
            // btnRigthFull
            // 
            this.btnRigthFull.Location = new System.Drawing.Point(68, 458);
            this.btnRigthFull.Name = "btnRigthFull";
            this.btnRigthFull.Size = new System.Drawing.Size(22, 23);
            this.btnRigthFull.TabIndex = 15;
            this.btnRigthFull.Text = "R";
            this.btnRigthFull.UseVisualStyleBackColor = true;
            this.btnRigthFull.Click += new System.EventHandler(this.btnRigthFull_Click);
            // 
            // btnCenterFull
            // 
            this.btnCenterFull.Location = new System.Drawing.Point(40, 458);
            this.btnCenterFull.Name = "btnCenterFull";
            this.btnCenterFull.Size = new System.Drawing.Size(22, 23);
            this.btnCenterFull.TabIndex = 14;
            this.btnCenterFull.Text = "C";
            this.btnCenterFull.UseVisualStyleBackColor = true;
            this.btnCenterFull.Click += new System.EventHandler(this.btnCenterFull_Click);
            // 
            // btnBoldFull
            // 
            this.btnBoldFull.Location = new System.Drawing.Point(12, 458);
            this.btnBoldFull.Name = "btnBoldFull";
            this.btnBoldFull.Size = new System.Drawing.Size(22, 23);
            this.btnBoldFull.TabIndex = 13;
            this.btnBoldFull.Text = "b";
            this.btnBoldFull.UseVisualStyleBackColor = true;
            this.btnBoldFull.Click += new System.EventHandler(this.btnBoldFull_Click);
            // 
            // lblCategory2
            // 
            this.lblCategory2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Location = new System.Drawing.Point(397, 303);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(258, 13);
            this.lblCategory2.TabIndex = 26;
            this.lblCategory2.Text = "РАЗДЕЛ2 - раздел в котором находится раздел1";
            this.lblCategory2.Click += new System.EventHandler(this.lblCategory2_Click_1);
            // 
            // lblCategory1
            // 
            this.lblCategory1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategory1.AutoSize = true;
            this.lblCategory1.Location = new System.Drawing.Point(397, 280);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(245, 13);
            this.lblCategory1.TabIndex = 25;
            this.lblCategory1.Text = "РАЗДЕЛ1 - раздел в котором находится товар";
            this.lblCategory1.Click += new System.EventHandler(this.lblCategory1_Click_1);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(397, 258);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 13);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "ЦЕНА - стоимость товара";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click_1);
            // 
            // lblArticl
            // 
            this.lblArticl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArticl.AutoSize = true;
            this.lblArticl.Location = new System.Drawing.Point(397, 236);
            this.lblArticl.Name = "lblArticl";
            this.lblArticl.Size = new System.Drawing.Size(146, 13);
            this.lblArticl.TabIndex = 23;
            this.lblArticl.Text = "АРТИКУЛ - артикул товара";
            this.lblArticl.Click += new System.EventHandler(this.lblArticl_Click_1);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(397, 212);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "НАЗВАНИЕ - наименование товара";
            this.lblName.Click += new System.EventHandler(this.lblName_Click_1);
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 490);
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
            this.Name = "Templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание шаблона";
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
    }
}