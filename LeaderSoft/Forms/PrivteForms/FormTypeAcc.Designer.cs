namespace LeaderSoft
{
    partial class FormTypeAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypeAcc));
            this.TreeViewMain = new System.Windows.Forms.TreeView();
            this.lableTitle = new System.Windows.Forms.Label();
            this.LableID = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.LabelGroupID = new System.Windows.Forms.Label();
            this.TextBoxGroupID = new System.Windows.Forms.TextBox();
            this.LabelGroupName = new System.Windows.Forms.Label();
            this.LableNameLng1 = new System.Windows.Forms.Label();
            this.TextBoxGroupName = new System.Windows.Forms.TextBox();
            this.TextBoxNameLng1 = new System.Windows.Forms.TextBox();
            this.LableLableNameLng2 = new System.Windows.Forms.Label();
            this.TextBoxNameLng2 = new System.Windows.Forms.TextBox();
            this.Pan = new System.Windows.Forms.Panel();
            this.re = new System.Windows.Forms.PictureBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.PictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.RadioBtnNotGroup = new System.Windows.Forms.RadioButton();
            this.RadioBtnGroup = new System.Windows.Forms.RadioButton();
            this.buttonGroupSearch = new System.Windows.Forms.Button();
            this.Pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewMain
            // 
            this.TreeViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeViewMain.Location = new System.Drawing.Point(-1, 0);
            this.TreeViewMain.Name = "TreeViewMain";
            this.TreeViewMain.Size = new System.Drawing.Size(263, 472);
            this.TreeViewMain.TabIndex = 0;
            this.TreeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewMain_AfterSelect);
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Location = new System.Drawing.Point(630, 68);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(49, 13);
            this.lableTitle.TabIndex = 2;
            this.lableTitle.Text = "lableTitle";
            // 
            // LableID
            // 
            this.LableID.AutoSize = true;
            this.LableID.Location = new System.Drawing.Point(605, 171);
            this.LableID.Name = "LableID";
            this.LableID.Size = new System.Drawing.Size(52, 13);
            this.LableID.TabIndex = 3;
            this.LableID.Text = "رقم الكود ";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(438, 168);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(161, 20);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.Leave += new System.EventHandler(this.TextBoxID_Leave);
            // 
            // LabelGroupID
            // 
            this.LabelGroupID.AutoSize = true;
            this.LabelGroupID.Location = new System.Drawing.Point(605, 204);
            this.LabelGroupID.Name = "LabelGroupID";
            this.LabelGroupID.Size = new System.Drawing.Size(75, 13);
            this.LabelGroupID.TabIndex = 3;
            this.LabelGroupID.Text = "رقم المجموعة ";
            // 
            // TextBoxGroupID
            // 
            this.TextBoxGroupID.Location = new System.Drawing.Point(438, 201);
            this.TextBoxGroupID.Name = "TextBoxGroupID";
            this.TextBoxGroupID.Size = new System.Drawing.Size(161, 20);
            this.TextBoxGroupID.TabIndex = 2;
            this.TextBoxGroupID.Leave += new System.EventHandler(this.TextBoxGroupID_Leave);
            // 
            // LabelGroupName
            // 
            this.LabelGroupName.AutoSize = true;
            this.LabelGroupName.Location = new System.Drawing.Point(605, 238);
            this.LabelGroupName.Name = "LabelGroupName";
            this.LabelGroupName.Size = new System.Drawing.Size(80, 13);
            this.LabelGroupName.TabIndex = 3;
            this.LabelGroupName.Text = "اسم المجموعة ";
            // 
            // LableNameLng1
            // 
            this.LableNameLng1.AutoSize = true;
            this.LableNameLng1.Location = new System.Drawing.Point(605, 271);
            this.LableNameLng1.Name = "LableNameLng1";
            this.LableNameLng1.Size = new System.Drawing.Size(73, 13);
            this.LableNameLng1.TabIndex = 3;
            this.LableNameLng1.Text = "الاسم العربي ";
            // 
            // TextBoxGroupName
            // 
            this.TextBoxGroupName.Location = new System.Drawing.Point(438, 235);
            this.TextBoxGroupName.Name = "TextBoxGroupName";
            this.TextBoxGroupName.Size = new System.Drawing.Size(161, 20);
            this.TextBoxGroupName.TabIndex = 3;
            // 
            // TextBoxNameLng1
            // 
            this.TextBoxNameLng1.Location = new System.Drawing.Point(438, 268);
            this.TextBoxNameLng1.Name = "TextBoxNameLng1";
            this.TextBoxNameLng1.Size = new System.Drawing.Size(161, 20);
            this.TextBoxNameLng1.TabIndex = 4;
            // 
            // LableLableNameLng2
            // 
            this.LableLableNameLng2.AutoSize = true;
            this.LableLableNameLng2.Location = new System.Drawing.Point(605, 304);
            this.LableLableNameLng2.Name = "LableLableNameLng2";
            this.LableLableNameLng2.Size = new System.Drawing.Size(85, 13);
            this.LableLableNameLng2.TabIndex = 3;
            this.LableLableNameLng2.Text = "الاسم الانجليزي ";
            // 
            // TextBoxNameLng2
            // 
            this.TextBoxNameLng2.Location = new System.Drawing.Point(438, 301);
            this.TextBoxNameLng2.Name = "TextBoxNameLng2";
            this.TextBoxNameLng2.Size = new System.Drawing.Size(161, 20);
            this.TextBoxNameLng2.TabIndex = 5;
            // 
            // Pan
            // 
            this.Pan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pan.Controls.Add(this.re);
            this.Pan.Controls.Add(this.ButtonExit);
            this.Pan.Controls.Add(this.ButtonCancel);
            this.Pan.Controls.Add(this.ButtonSearch);
            this.Pan.Controls.Add(this.ButtonDelete);
            this.Pan.Controls.Add(this.ButtonEdit);
            this.Pan.Controls.Add(this.ButtonPrint);
            this.Pan.Controls.Add(this.ButtonSave);
            this.Pan.Controls.Add(this.ButtonNew);
            this.Pan.Location = new System.Drawing.Point(868, 0);
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(32, 470);
            this.Pan.TabIndex = 5;
            // 
            // re
            // 
            this.re.Image = ((System.Drawing.Image)(resources.GetObject("re.Image")));
            this.re.Location = new System.Drawing.Point(3, 0);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(26, 25);
            this.re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.re.TabIndex = 8;
            this.re.TabStop = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(3, 395);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(153, 37);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "خروج";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(3, 356);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(153, 37);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "الغاء";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(3, 317);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(153, 37);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "بحث";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(3, 240);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(153, 37);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "حذف";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(3, 164);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(153, 37);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "تعديل";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(3, 278);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(153, 37);
            this.ButtonPrint.TabIndex = 7;
            this.ButtonPrint.Text = "طباعة";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(3, 203);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(153, 37);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "حفظ";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(3, 127);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(153, 37);
            this.ButtonNew.TabIndex = 7;
            this.ButtonNew.Text = "جديد";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // PictureBoxTitle
            // 
            this.PictureBoxTitle.Location = new System.Drawing.Point(461, 24);
            this.PictureBoxTitle.Name = "PictureBoxTitle";
            this.PictureBoxTitle.Size = new System.Drawing.Size(119, 114);
            this.PictureBoxTitle.TabIndex = 1;
            this.PictureBoxTitle.TabStop = false;
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.FlatAppearance.BorderSize = 0;
            this.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.Location = new System.Drawing.Point(409, 380);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(25, 52);
            this.ButtonPrevious.TabIndex = 44;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.Location = new System.Drawing.Point(600, 380);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(25, 52);
            this.ButtonNext.TabIndex = 45;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.FlatAppearance.BorderSize = 0;
            this.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFirst.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFirst.Image")));
            this.ButtonFirst.Location = new System.Drawing.Point(316, 385);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(53, 43);
            this.ButtonFirst.TabIndex = 46;
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.FlatAppearance.BorderSize = 0;
            this.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLast.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLast.Image")));
            this.ButtonLast.Location = new System.Drawing.Point(656, 389);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(53, 43);
            this.ButtonLast.TabIndex = 47;
            this.ButtonLast.UseVisualStyleBackColor = true;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // RadioBtnNotGroup
            // 
            this.RadioBtnNotGroup.AutoSize = true;
            this.RadioBtnNotGroup.Location = new System.Drawing.Point(438, 337);
            this.RadioBtnNotGroup.Name = "RadioBtnNotGroup";
            this.RadioBtnNotGroup.Size = new System.Drawing.Size(50, 17);
            this.RadioBtnNotGroup.TabIndex = 49;
            this.RadioBtnNotGroup.TabStop = true;
            this.RadioBtnNotGroup.Text = "فردي";
            this.RadioBtnNotGroup.UseVisualStyleBackColor = true;
            // 
            // RadioBtnGroup
            // 
            this.RadioBtnGroup.AutoSize = true;
            this.RadioBtnGroup.Location = new System.Drawing.Point(536, 337);
            this.RadioBtnGroup.Name = "RadioBtnGroup";
            this.RadioBtnGroup.Size = new System.Drawing.Size(63, 17);
            this.RadioBtnGroup.TabIndex = 48;
            this.RadioBtnGroup.TabStop = true;
            this.RadioBtnGroup.Text = "مجموعة";
            this.RadioBtnGroup.UseVisualStyleBackColor = true;
            // 
            // buttonGroupSearch
            // 
            this.buttonGroupSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGroupSearch.Image = global::LeaderSoft.Properties.Resources.More_20px;
            this.buttonGroupSearch.Location = new System.Drawing.Point(413, 201);
            this.buttonGroupSearch.Name = "buttonGroupSearch";
            this.buttonGroupSearch.Size = new System.Drawing.Size(19, 20);
            this.buttonGroupSearch.TabIndex = 50;
            this.buttonGroupSearch.UseVisualStyleBackColor = true;
            this.buttonGroupSearch.Click += new System.EventHandler(this.buttonGroupSearch_Click);
            // 
            // FormTypeAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.buttonGroupSearch);
            this.Controls.Add(this.RadioBtnNotGroup);
            this.Controls.Add(this.RadioBtnGroup);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.Pan);
            this.Controls.Add(this.TextBoxNameLng2);
            this.Controls.Add(this.TextBoxNameLng1);
            this.Controls.Add(this.TextBoxGroupName);
            this.Controls.Add(this.LableLableNameLng2);
            this.Controls.Add(this.TextBoxGroupID);
            this.Controls.Add(this.LableNameLng1);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.LabelGroupName);
            this.Controls.Add(this.LabelGroupID);
            this.Controls.Add(this.LableID);
            this.Controls.Add(this.lableTitle);
            this.Controls.Add(this.PictureBoxTitle);
            this.Controls.Add(this.TreeViewMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTypeAcc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormTypeAcc";
            this.Load += new System.EventHandler(this.FormTypeAcc_Load);
            this.Pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewMain;
        private System.Windows.Forms.PictureBox PictureBoxTitle;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Label LableID;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label LabelGroupID;
        private System.Windows.Forms.TextBox TextBoxGroupID;
        private System.Windows.Forms.Label LabelGroupName;
        private System.Windows.Forms.Label LableNameLng1;
        private System.Windows.Forms.TextBox TextBoxGroupName;
        private System.Windows.Forms.TextBox TextBoxNameLng1;
        private System.Windows.Forms.Label LableLableNameLng2;
        private System.Windows.Forms.TextBox TextBoxNameLng2;
        private System.Windows.Forms.Panel Pan;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonLast;
        private System.Windows.Forms.RadioButton RadioBtnNotGroup;
        private System.Windows.Forms.RadioButton RadioBtnGroup;
        private System.Windows.Forms.Button buttonGroupSearch;
        private System.Windows.Forms.PictureBox re;
    }
}