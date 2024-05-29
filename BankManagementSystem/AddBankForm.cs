using System;
using System.Windows.Forms;
using BankManagementSystem.Models;
using BankManagementSystem.Repositories;

namespace BankManagementSystem
{
    public partial class AddBankForm : Form
    {
        private BankRepository _bankRepository;

        public AddBankForm(BankRepository bankRepository)
        {
            InitializeComponent();
            _bankRepository = bankRepository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var bank = new Bank(txtBankCode.Text, txtBankName.Text, txtBankStatus.Text, txtMFO.Text);
            _bankRepository.AddBank(bank);
            MessageBox.Show("Bank added successfully");
            this.Close();
        }
    }
}

