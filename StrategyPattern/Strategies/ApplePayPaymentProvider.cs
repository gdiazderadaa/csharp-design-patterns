using DesignPatterns.Behavioral.StrategyPattern.AbstractStrategy;

namespace DesignPatterns.Behavioral.StrategyPattern.Strategies
{
	public class ApplePayPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by Apple Pay";
		}
	}
}
