using System;

namespace StrategyPattern.Model
{
    public class Basket 
    {
        public decimal TotalCost { get; set; }

        private IBasketDiscountStrategy _basketDiscount; 
        public Basket(DiscountType discountType) 
        {
            _basketDiscount = BasketDiscountFactory.GetDiscount(discountType); 
        }
        public decimal GetTotalCostAfterDiscount() 
        { 
            return _basketDiscount.GetTotalCostAfterApplyingDiscountTo(this); 
        }
    }
}
