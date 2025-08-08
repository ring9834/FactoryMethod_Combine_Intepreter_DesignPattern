using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Concrete expressions for Interpreter pattern
    public class TotalSpentRule : IDiscountRule
    {
        private readonly decimal _minSpent;

        public TotalSpentRule(decimal minSpent)
        {
            _minSpent = minSpent;
        }

        public bool Interpret(CustomerContext context)
        {
            return context.TotalSpent >= _minSpent;
        }
    }
}
