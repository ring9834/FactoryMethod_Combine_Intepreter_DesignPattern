using FactoryMethod_Combine_Intepreter.FactoryMethod.Products;
using FactoryMethod_Combine_Intepreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Factory
{
    public class LoyalCustomerDiscountFactory : DiscountFactory
    {
        public override IDiscountCalculator CreateDiscountCalculator()
        {
            return new LoyalCustomerDiscountCalculator();
        }

        public override IDiscountRule CreateDiscountRule()
        {
            return new AndRule(
                new PurchaseCountRule(10),
                new RecentPurchaseRule(30)
            );
        }
    }
}
