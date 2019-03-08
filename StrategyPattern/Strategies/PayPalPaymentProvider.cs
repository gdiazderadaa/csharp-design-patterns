using StrategyPattern.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
	public class PayPalPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by PayPal";
		}
	}
}
