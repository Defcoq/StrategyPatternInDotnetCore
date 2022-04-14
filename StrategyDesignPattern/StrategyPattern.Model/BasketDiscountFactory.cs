using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Model
{
    public class BasketDiscountFactory 
    { 
        public static IBasketDiscountStrategy GetDiscount(DiscountType DiscountType)
        { 
            switch (DiscountType) 
            { 
                case DiscountType.MoneyOff: 
                    return new BasketDiscountMoneyOff(); 
                case DiscountType.PercentageOff: 
                    return new BasketDiscountPercentageOff(); 
                default: return new NoBasketDiscount(); 
            } 
        } 
    }
}
