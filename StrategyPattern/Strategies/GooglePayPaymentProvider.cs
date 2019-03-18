using DesignPatterns.Behavioral.StrategyPattern.AbstractStrategy;

namespace DesignPatterns.Behavioral.StrategyPattern.Strategies
{
	public class GooglePayPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by Google Pay";
		}
	}
}
