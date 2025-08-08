using FactoryMethod_Combine_Intepreter.FactoryMethod.Products;
using FactoryMethod_Combine_Intepreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Factory
{
    // Concrete creators for Factory Method
    public class StandardDiscountFactory : DiscountFactory
    {
        public override IDiscountCalculator CreateDiscountCalculator()
        {
            return new StandardDiscountCalculator();
        }

        public override IDiscountRule CreateDiscountRule()
        {
            return new PurchaseCountRule(5);
        }
    }
}
