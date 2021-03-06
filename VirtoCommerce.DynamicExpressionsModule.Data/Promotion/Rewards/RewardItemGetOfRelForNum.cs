using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtoCommerce.Domain.Marketing.Model;
using VirtoCommerce.Domain.Common;

namespace VirtoCommerce.DynamicExpressionsModule.Data.Promotion
{
    //Get []% off [] items of entry [] not to exceed $ [ 500 ]
    public class RewardItemGetOfRelForNum : DynamicExpression, IRewardExpression
	{
		public decimal Amount { get; set; }
		public string ProductId { get; set; }
		public int NumItem { get; set; }
		public string ProductName { get; set; }
	    public decimal MaxLimit { get; set; }
        #region IRewardExpression Members

        public PromotionReward[] GetRewards()
		{
			var retVal = new CatalogItemAmountReward
			{
				Amount = Amount,
				AmountType = RewardAmountType.Relative,
				Quantity = NumItem,
				ProductId = ProductId,
                MaxLimit = MaxLimit
			};
			return new PromotionReward[] { retVal };
		}

		#endregion
	}
}
