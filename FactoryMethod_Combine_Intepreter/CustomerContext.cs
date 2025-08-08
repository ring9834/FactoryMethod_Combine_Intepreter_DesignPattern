using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter
{
    // Context class for Interpreter
    public class CustomerContext
    {
        public int PurchaseCount { get; set; }
        public decimal TotalSpent { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public bool IsVIP { get; set; }

        public CustomerContext(int purchaseCount, decimal totalSpent, DateTime lastPurchaseDate, bool isVIP)
        {
            PurchaseCount = purchaseCount;
            TotalSpent = totalSpent;
            LastPurchaseDate = lastPurchaseDate;
            IsVIP = isVIP;
        }
    }
}
