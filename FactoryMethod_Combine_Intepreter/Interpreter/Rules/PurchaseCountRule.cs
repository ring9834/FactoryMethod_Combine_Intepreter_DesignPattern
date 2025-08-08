using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Concrete expressions for Interpreter pattern
    public class PurchaseCountRule : IDiscountRule
    {
        private readonly int _minPurchases;

        public PurchaseCountRule(int minPurchases)
        {
            _minPurchases = minPurchases;
        }

        public bool Interpret(CustomerContext context)
        {
            return context.PurchaseCount >= _minPurchases;
        }
    }
}
