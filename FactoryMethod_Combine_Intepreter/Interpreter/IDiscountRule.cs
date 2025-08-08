using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.Interpreter
{
    // Abstract expression for Interpreter pattern
    public interface IDiscountRule
    {
        bool Interpret(CustomerContext context);
    }
}
