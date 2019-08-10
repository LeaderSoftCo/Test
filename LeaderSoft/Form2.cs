using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeaderSoft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void FormTypeAcc_Click(object sender, EventArgs e)
        {
            FormTypeAcc _FormTypeAcc = new FormTypeAcc();
            _FormTypeAcc.Show();
        }
    }
}
