using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Combine_Intepreter.FactoryMethod.Products
{
    // Product interface for Factory Method
    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(decimal originalPrice);
    }
}
