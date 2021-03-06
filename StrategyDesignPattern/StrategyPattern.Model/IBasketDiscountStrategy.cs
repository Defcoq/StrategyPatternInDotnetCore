using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Model
{
    public interface IBasketDiscountStrategy 
    { 
        decimal GetTotalCostAfterApplyingDiscountTo(Basket basket); 
    }
}
