using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Products
{
    // Concrete product for Factory Method
    public class VIPDiscountCalculator : IDiscountCalculator
    {
        public decimal CalculateDiscount(decimal originalPrice)
        {
            return originalPrice * 0.25m; // 25% discount
        }
    }
}
