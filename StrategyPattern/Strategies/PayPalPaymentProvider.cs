using DesignPatterns.Behavioral.StrategyPattern.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.StrategyPattern.Strategies
{
	public class PayPalPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by PayPal";
		}
	}
}
