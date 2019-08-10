namespace LeaderSoft
{
    partial class Form2
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
            this.FormTypeAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormTypeAcc
            // 
            this.FormTypeAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FormTypeAcc.Location = new System.Drawing.Point(435, 201);
            this.FormTypeAcc.Name = "FormTypeAcc";
            this.FormTypeAcc.Size = new System.Drawing.Size(111, 23);
            this.FormTypeAcc.TabIndex = 9;
            this.FormTypeAcc.Text = "TypeAccount";
            this.FormTypeAcc.UseVisualStyleBackColor = true;
            this.FormTypeAcc.Click += new System.EventHandler(this.FormTypeAcc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 431);
            this.Controls.Add(this.FormTypeAcc);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormTypeAcc;
    }
}