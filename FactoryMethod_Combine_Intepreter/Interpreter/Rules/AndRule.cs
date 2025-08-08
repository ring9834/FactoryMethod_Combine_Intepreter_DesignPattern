using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Concrete expression for Interpreter pattern
    public class AndRule : IDiscountRule
    {
        private readonly IDiscountRule _rule1;
        private readonly IDiscountRule _rule2;

        public AndRule(IDiscountRule rule1, IDiscountRule rule2)
        {
            _rule1 = rule1;
            _rule2 = rule2;
        }

        public bool Interpret(CustomerContext context)
        {
            return _rule1.Interpret(context) && _rule2.Interpret(context);
        }
    }
}
