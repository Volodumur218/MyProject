using System.Collections.Generic;
using System.Linq;
using BankManagementSystem.Models;

namespace BankManagementSystem.Repositories
{
    public class BankRepository
    {
        private List<Bank> _banks;

        public BankRepository()
        {
            _banks = new List<Bank>();
        }

        public void AddBank(Bank bank)
        {
            _banks.Add(bank);
        }

        public Bank GetBankByCode(string bankCode)
        {
            return _banks.FirstOrDefault(b => b.BankCode == bankCode);
        }
    }
}

