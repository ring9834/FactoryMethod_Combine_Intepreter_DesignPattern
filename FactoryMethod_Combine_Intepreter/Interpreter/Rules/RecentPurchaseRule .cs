using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Concrete expressions for Interpreter pattern
    public class RecentPurchaseRule : IDiscountRule
    {
        private readonly int _daysSinceLastPurchase;

        public RecentPurchaseRule(int daysSinceLastPurchase)
        {
            _daysSinceLastPurchase = daysSinceLastPurchase;
        }

        public bool Interpret(CustomerContext context)
        {
            return (DateTime.Now - context.LastPurchaseDate).TotalDays <= _daysSinceLastPurchase;
        }
    }
}
