namespace LeaderSoft
{
    partial class Formcurency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcurency));
            this.ButtonNew = new System.Windows.Forms.Button();
            this.TreeViewMain = new System.Windows.Forms.TreeView();
            this.Pan = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.PictureBox();
            this.lableTitle = new System.Windows.Forms.Label();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.PictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGroupSearch = new System.Windows.Forms.Button();
            this.labelFor = new System.Windows.Forms.Label();
            this.labelNumberParts = new System.Windows.Forms.Label();
            this.TextBoxCurrencyID = new System.Windows.Forms.TextBox();
            this.LableID = new System.Windows.Forms.Label();
            this.LabelGroupID = new System.Windows.Forms.Label();
            this.LabelGroupName = new System.Windows.Forms.Label();
            this.TextBoxNumberParts = new System.Windows.Forms.TextBox();
            this.TextBoxNameCurrency = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxNameLng1 = new System.Windows.Forms.TextBox();
            this.LableLableNameLng2 = new System.Windows.Forms.Label();
            this.TextBoxNameLng2 = new System.Windows.Forms.TextBox();
            this.LableNameLng1 = new System.Windows.Forms.Label();
            this.RadioBtnNotGroup = new System.Windows.Forms.RadioButton();
            this.RadioBtnGroup = new System.Windows.Forms.RadioButton();
            this.Pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(8, 125);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(153, 37);
            this.ButtonNew.TabIndex = 7;
            this.ButtonNew.Text = "جديد";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // TreeViewMain
            // 
            this.TreeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeViewMain.Location = new System.Drawing.Point(0, 0);
            this.TreeViewMain.Name = "TreeViewMain";
            this.TreeViewMain.Size = new System.Drawing.Size(207, 448);
            this.TreeViewMain.TabIndex = 39;
            this.TreeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewMain_AfterSelect);
            // 
            // Pan
            // 
            this.Pan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pan.Controls.Add(this.ButtonExit);
            this.Pan.Controls.Add(this.ButtonCancel);
            this.Pan.Controls.Add(this.ButtonSearch);
            this.Pan.Controls.Add(this.ButtonDelete);
            this.Pan.Controls.Add(this.ButtonEdit);
            this.Pan.Controls.Add(this.ButtonPrint);
            this.Pan.Controls.Add(this.ButtonSave);
            this.Pan.Controls.Add(this.ButtonNew);
            this.Pan.Controls.Add(this.re);
            this.Pan.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pan.Location = new System.Drawing.Point(856, 0);
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(33, 448);
            this.Pan.TabIndex = 38;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(8, 393);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(153, 37);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "خروج";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(8, 354);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(153, 37);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "الغاء";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(8, 315);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(153, 37);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "بحث";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(8, 238);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(153, 37);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "حذف";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(8, 162);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(153, 37);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "تعديل";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(8, 276);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(153, 37);
            this.ButtonPrint.TabIndex = 7;
            this.ButtonPrint.Text = "طباعة";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(8, 201);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(153, 37);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "حفظ";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // re
            // 
            this.re.Image = ((System.Drawing.Image)(resources.GetObject("re.Image")));
            this.re.Location = new System.Drawing.Point(5, 3);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(26, 25);
            this.re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.re.TabIndex = 6;
            this.re.TabStop = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Location = new System.Drawing.Point(557, 21);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(43, 13);
            this.lableTitle.TabIndex = 27;
            this.lableTitle.Text = "العملات";
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.FlatAppearance.BorderSize = 0;
            this.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.Location = new System.Drawing.Point(402, 360);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(25, 52);
            this.ButtonPrevious.TabIndex = 40;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.Location = new System.Drawing.Point(593, 360);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(25, 52);
            this.ButtonNext.TabIndex = 41;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.FlatAppearance.BorderSize = 0;
            this.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFirst.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFirst.Image")));
            this.ButtonFirst.Location = new System.Drawing.Point(309, 365);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(53, 43);
            this.ButtonFirst.TabIndex = 42;
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.FlatAppearance.BorderSize = 0;
            this.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLast.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLast.Image")));
            this.ButtonLast.Location = new System.Drawing.Point(649, 369);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(53, 43);
            this.ButtonLast.TabIndex = 43;
            this.ButtonLast.UseVisualStyleBackColor = true;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // PictureBoxTitle
            // 
            this.PictureBoxTitle.Location = new System.Drawing.Point(464, 12);
            this.PictureBoxTitle.Name = "PictureBoxTitle";
            this.PictureBoxTitle.Size = new System.Drawing.Size(87, 34);
            this.PictureBoxTitle.TabIndex = 26;
            this.PictureBoxTitle.TabStop = false;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(11, 174);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(306, 20);
            this.textBoxRate.TabIndex = 7;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(324, 183);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(62, 13);
            this.labelRate.TabIndex = 45;
            this.labelRate.Text = "سعر الصرف";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGroupSearch);
            this.panel1.Controls.Add(this.labelFor);
            this.panel1.Controls.Add(this.labelNumberParts);
            this.panel1.Controls.Add(this.TextBoxCurrencyID);
            this.panel1.Controls.Add(this.LableID);
            this.panel1.Controls.Add(this.labelRate);
            this.panel1.Controls.Add(this.LabelGroupID);
            this.panel1.Controls.Add(this.textBoxRate);
            this.panel1.Controls.Add(this.LabelGroupName);
            this.panel1.Controls.Add(this.TextBoxNumberParts);
            this.panel1.Controls.Add(this.TextBoxNameCurrency);
            this.panel1.Controls.Add(this.TextBoxID);
            this.panel1.Controls.Add(this.TextBoxNameLng1);
            this.panel1.Controls.Add(this.LableLableNameLng2);
            this.panel1.Controls.Add(this.TextBoxNameLng2);
            this.panel1.Controls.Add(this.LableNameLng1);
            this.panel1.Location = new System.Drawing.Point(288, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 204);
            this.panel1.TabIndex = 45;
            // 
            // buttonGroupSearch
            // 
            this.buttonGroupSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGroupSearch.Image = global::LeaderSoft.Properties.Resources.More_20px;
            this.buttonGroupSearch.Location = new System.Drawing.Point(9, 17);
            this.buttonGroupSearch.Name = "buttonGroupSearch";
            this.buttonGroupSearch.Size = new System.Drawing.Size(19, 20);
            this.buttonGroupSearch.TabIndex = 53;
            this.buttonGroupSearch.UseVisualStyleBackColor = true;
            this.buttonGroupSearch.Click += new System.EventHandler(this.buttonGroupSearch_Click);
            // 
            // labelFor
            // 
            this.labelFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFor.Location = new System.Drawing.Point(169, 81);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(39, 21);
            this.labelFor.TabIndex = 48;
            this.labelFor.Text = "لكل 1";
            this.labelFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberParts
            // 
            this.labelNumberParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberParts.Location = new System.Drawing.Point(319, 79);
            this.labelNumberParts.Name = "labelNumberParts";
            this.labelNumberParts.Size = new System.Drawing.Size(63, 19);
            this.labelNumberParts.TabIndex = 46;
            this.labelNumberParts.Text = "عدد الأجزاء";
            this.labelNumberParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxCurrencyID
            // 
            this.TextBoxCurrencyID.Location = new System.Drawing.Point(28, 17);
            this.TextBoxCurrencyID.Name = "TextBoxCurrencyID";
            this.TextBoxCurrencyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxCurrencyID.Size = new System.Drawing.Size(97, 20);
            this.TextBoxCurrencyID.TabIndex = 2;
            this.TextBoxCurrencyID.Leave += new System.EventHandler(this.TextBoxCurrencyID_Leave);
            // 
            // LableID
            // 
            this.LableID.AutoSize = true;
            this.LableID.Location = new System.Drawing.Point(334, 20);
            this.LableID.Name = "LableID";
            this.LableID.Size = new System.Drawing.Size(52, 13);
            this.LableID.TabIndex = 30;
            this.LableID.Text = "رقم الكود ";
            // 
            // LabelGroupID
            // 
            this.LabelGroupID.AutoSize = true;
            this.LabelGroupID.Location = new System.Drawing.Point(131, 20);
            this.LabelGroupID.Name = "LabelGroupID";
            this.LabelGroupID.Size = new System.Drawing.Size(56, 13);
            this.LabelGroupID.TabIndex = 29;
            this.LabelGroupID.Text = "رقم العملة";
            // 
            // LabelGroupName
            // 
            this.LabelGroupName.AutoSize = true;
            this.LabelGroupName.Location = new System.Drawing.Point(320, 46);
            this.LabelGroupName.Name = "LabelGroupName";
            this.LabelGroupName.Size = new System.Drawing.Size(64, 13);
            this.LabelGroupName.TabIndex = 31;
            this.LabelGroupName.Text = "اسم العملة ";
            // 
            // TextBoxNumberParts
            // 
            this.TextBoxNumberParts.Location = new System.Drawing.Point(214, 82);
            this.TextBoxNumberParts.Name = "TextBoxNumberParts";
            this.TextBoxNumberParts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxNumberParts.Size = new System.Drawing.Size(103, 20);
            this.TextBoxNumberParts.TabIndex = 4;
            // 
            // TextBoxNameCurrency
            // 
            this.TextBoxNameCurrency.Location = new System.Drawing.Point(11, 46);
            this.TextBoxNameCurrency.Name = "TextBoxNameCurrency";
            this.TextBoxNameCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxNameCurrency.Size = new System.Drawing.Size(306, 20);
            this.TextBoxNameCurrency.TabIndex = 3;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(214, 17);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxID.Size = new System.Drawing.Size(103, 20);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.Leave += new System.EventHandler(this.TextBoxID_Leave);
            // 
            // TextBoxNameLng1
            // 
            this.TextBoxNameLng1.Location = new System.Drawing.Point(11, 115);
            this.TextBoxNameLng1.Name = "TextBoxNameLng1";
            this.TextBoxNameLng1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxNameLng1.Size = new System.Drawing.Size(306, 20);
            this.TextBoxNameLng1.TabIndex = 5;
            // 
            // LableLableNameLng2
            // 
            this.LableLableNameLng2.AutoSize = true;
            this.LableLableNameLng2.Location = new System.Drawing.Point(319, 144);
            this.LableLableNameLng2.Name = "LableLableNameLng2";
            this.LableLableNameLng2.Size = new System.Drawing.Size(85, 13);
            this.LableLableNameLng2.TabIndex = 32;
            this.LableLableNameLng2.Text = "الاسم الانجليزي ";
            // 
            // TextBoxNameLng2
            // 
            this.TextBoxNameLng2.Location = new System.Drawing.Point(11, 141);
            this.TextBoxNameLng2.Name = "TextBoxNameLng2";
            this.TextBoxNameLng2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxNameLng2.Size = new System.Drawing.Size(306, 20);
            this.TextBoxNameLng2.TabIndex = 6;
            // 
            // LableNameLng1
            // 
            this.LableNameLng1.AutoSize = true;
            this.LableNameLng1.Location = new System.Drawing.Point(323, 118);
            this.LableNameLng1.Name = "LableNameLng1";
            this.LableNameLng1.Size = new System.Drawing.Size(73, 13);
            this.LableNameLng1.TabIndex = 28;
            this.LableNameLng1.Text = "الاسم العربي ";
            // 
            // RadioBtnNotGroup
            // 
            this.RadioBtnNotGroup.AutoSize = true;
            this.RadioBtnNotGroup.Location = new System.Drawing.Point(387, 286);
            this.RadioBtnNotGroup.Name = "RadioBtnNotGroup";
            this.RadioBtnNotGroup.Size = new System.Drawing.Size(50, 17);
            this.RadioBtnNotGroup.TabIndex = 57;
            this.RadioBtnNotGroup.TabStop = true;
            this.RadioBtnNotGroup.Text = "فردي";
            this.RadioBtnNotGroup.UseVisualStyleBackColor = true;
            // 
            // RadioBtnGroup
            // 
            this.RadioBtnGroup.AutoSize = true;
            this.RadioBtnGroup.Location = new System.Drawing.Point(485, 286);
            this.RadioBtnGroup.Name = "RadioBtnGroup";
            this.RadioBtnGroup.Size = new System.Drawing.Size(63, 17);
            this.RadioBtnGroup.TabIndex = 56;
            this.RadioBtnGroup.TabStop = true;
            this.RadioBtnGroup.Text = "مجموعة";
            this.RadioBtnGroup.UseVisualStyleBackColor = true;
            // 
            // Formcurency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 448);
            this.Controls.Add(this.RadioBtnNotGroup);
            this.Controls.Add(this.RadioBtnGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.TreeViewMain);
            this.Controls.Add(this.Pan);
            this.Controls.Add(this.lableTitle);
            this.Controls.Add(this.PictureBoxTitle);
            this.Name = "Formcurency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formcurency";
            this.Load += new System.EventHandler(this.Formcurency_Load);
            this.Pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.PictureBox re;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonLast;
        private System.Windows.Forms.TreeView TreeViewMain;
        private System.Windows.Forms.Panel Pan;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.PictureBox PictureBoxTitle;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxCurrencyID;
        private System.Windows.Forms.Label LableID;
        private System.Windows.Forms.Label LabelGroupID;
        private System.Windows.Forms.TextBox TextBoxNameCurrency;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxNameLng1;
        private System.Windows.Forms.Label LableLableNameLng2;
        private System.Windows.Forms.TextBox TextBoxNameLng2;
        private System.Windows.Forms.Label LableNameLng1;
        private System.Windows.Forms.Label LabelGroupName;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label labelNumberParts;
        private System.Windows.Forms.TextBox TextBoxNumberParts;
        private System.Windows.Forms.RadioButton RadioBtnNotGroup;
        private System.Windows.Forms.RadioButton RadioBtnGroup;
        private System.Windows.Forms.Button buttonGroupSearch;

    }
}