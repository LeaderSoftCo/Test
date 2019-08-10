using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryPublic.Table;
using LibraryPublic.PublicClass;

using LibraryConnection;
using LeaderSoft.Forms.PublicForms;
namespace LeaderSoft
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
        }

       private void FormCostCenter_Click(object sender, EventArgs e)
       {
           FormCostCenter _FormCostCenter = new FormCostCenter();
           _FormCostCenter.Show();
       }

       private void FormChatOfAccount_Click(object sender, EventArgs e)
       {
            
           FormChatOfAccount _FormChatOfAccount = new FormChatOfAccount();
           _FormChatOfAccount.Show();
       }

       private void FormBranches_Click(object sender, EventArgs e)
       {
            FormBranches _FormBranches = new FormBranches();
           _FormBranches.Show();
       }

       private void FormDebentures_Click(object sender, EventArgs e)
       {
           FormDebentures _FormDebentures = new FormDebentures();
           _FormDebentures.Show();
       }

       private void FromBanks_Click(object sender, EventArgs e)
       {
           FormBanks _FormBanks =new FormBanks () ;
           _FormBanks.Show();
       }

       private void FormFund_Click(object sender, EventArgs e)
       {
           FormFund _FormFund = new FormFund();
           _FormFund.Show();
           
       }

       private void ConcludingAcconuts_Click(object sender, EventArgs e)
       {
           FormConcludingAcconuts _FormConcludingAcconuts = new FormConcludingAcconuts();
           _FormConcludingAcconuts.Show();
       }

       private void FormCustomer_Click(object sender, EventArgs e)
       {
           FormCustomers _FormCustomer = new FormCustomers();
           _FormCustomer.Show();
       }
        
       private void FormHustingCauseways_Click(object sender, EventArgs e)
       {
           FormHustingCauseways _FormHustingCauseways = new FormHustingCauseways();
           _FormHustingCauseways.Show();
       }

       private void FormSalesMan_Click(object sender, EventArgs e)
       {
           FormSelesMan _FormSelesMan = new FormSelesMan();
           _FormSelesMan.Show();
       }

       private void FormSuppliers_Click(object sender, EventArgs e)
       {
           FormSuppliers _FormSuppliers = new FormSuppliers();
           _FormSuppliers.Show(); 
       }

       private void FormTypeAcc_Click(object sender, EventArgs e)
       {
           FormTypeAcc _FormTypeAcc = new FormTypeAcc();
           _FormTypeAcc.Show();
       }

       private void FormAcconutsTypes_Click(object sender, EventArgs e)
       {
           FormAcconutsTypes _FormAcconutsTypes = new FormAcconutsTypes();
           _FormAcconutsTypes.Show();
       }

       private void FormCurrency_Click(object sender, EventArgs e)
       {
           Formcurency _Formcurency = new Formcurency();
           _Formcurency.Show();
       }

      
       
    }
}
