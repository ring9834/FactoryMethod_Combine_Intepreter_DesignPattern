using FactoryMethod_Combine_Intepreter.FactoryMethod.Products;
using FactoryMethod_Combine_Intepreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Factory
{
    // Abstract creator for Factory Method
    public abstract class DiscountFactory
    {
        public abstract IDiscountCalculator CreateDiscountCalculator();
        public abstract IDiscountRule CreateDiscountRule();
    }
}
