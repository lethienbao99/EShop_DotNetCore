using System;
using System.Collections.Generic;
using System.Text;
using EShop_DotNetCore.DAL.Enums;

namespace EShop_DotNetCore.DAL.Models
{
    public class Transaction
    {
        public int TransactionId { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }

        public Guid user_id { get; set; }

    }
}
