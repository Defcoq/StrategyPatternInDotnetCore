using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Model
{
    public class BasketDiscountPercentageOff : IBasketDiscountStrategy 
    { 
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket) 
        { 
            return basket.TotalCost * 0.85m; 
        } 
    }
}
