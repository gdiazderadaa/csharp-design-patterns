using StrategyPattern.AbstractStrategy;

namespace StrategyPattern.Strategies
{
	public class ApplePayPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by Apple Pay";
		}
	}
}
