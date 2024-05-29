using System;
using System.Windows.Forms;
using BankManagementSystem.Models;
using BankManagementSystem.Repositories;

namespace BankManagementSystem
{
    public partial class MainForm : Form
    {
        private BankRepository _bankRepository;

        public MainForm()
        {
            InitializeComponent();
            _bankRepository = new BankRepository();
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            var addBankForm = new AddBankForm(_bankRepository);
            addBankForm.ShowDialog();
        }

        private void btnGetBankInfo_Click(object sender, EventArgs e)
        {
            var bankCode = txtBankCode.Text;
            var bank = _bankRepository.GetBankByCode(bankCode);

            if (bank != null)
            {
                DisplayBankInfo(bank);
            }
            else
            {
                MessageBox.Show("Bank not found");
            }
        }

        private void DisplayBankInfo(Bank bank)
        {
            lstBankInfo.Items.Clear();
            lstBankInfo.Items.Add($"Code: {bank.BankCode}");
            lstBankInfo.Items.Add($"Name: {bank.BankName}");
            lstBankInfo.Items.Add($"Status: {bank.BankStatus}");
            lstBankInfo.Items.Add($"MFO: {bank.MFO}");
            foreach (var indicator in bank.QuarterlyData)
            {
                lstBankInfo.Items.Add($"{indicator.Key.ToShortDateString()}: {indicator.Value}");
            }
        }
    }
}


