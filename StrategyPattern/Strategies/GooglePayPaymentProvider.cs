using StrategyPattern.AbstractStrategy;

namespace StrategyPattern.Strategies
{
	public class GooglePayPaymentProvider : IPaymentProvider
	{
		public string Pay()
		{
			return "Paid by Google Pay";
		}
	}
}
