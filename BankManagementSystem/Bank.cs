using System;
using System.Collections.Generic;

namespace BankManagementSystem.Models
{
    public class Bank
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankStatus { get; set; }
        public string MFO { get; set; }
        public Dictionary<DateTime, decimal> QuarterlyData { get; set; }

        public Bank(string bankCode, string bankName, string bankStatus, string mfo)
        {
            BankCode = bankCode;
            BankName = bankName;
            BankStatus = bankStatus;
            MFO = mfo;
            QuarterlyData = new Dictionary<DateTime, decimal>();
        }

        public Bank() { }
    }
}

