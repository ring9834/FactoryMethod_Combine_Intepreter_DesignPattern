using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Concrete expression for Interpreter pattern
    public class VIPRule : IDiscountRule
    {
        public bool Interpret(CustomerContext context)
        {
            return context.IsVIP;
        }
    }
}
