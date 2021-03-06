﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtoCommerce.Domain.Marketing.Model;
using VirtoCommerce.Domain.Common;

namespace VirtoCommerce.DynamicExpressionsModule.Data.Promotion
{
	//Get $[] off payment method []
	public class RewardPaymentGetOfAbs : DynamicExpression, IRewardExpression
	{
		public decimal Amount { get; set; }
		public string PaymentMethod { get; set; }

		#region IRewardExpression Members

		public PromotionReward[] GetRewards()
		{
			var retVal = new PaymentReward
			{
				Amount = Amount,
				AmountType = RewardAmountType.Absolute,
				PaymentMethod = PaymentMethod
            };
			return new PromotionReward[] { retVal };
		}

		#endregion
	}
}