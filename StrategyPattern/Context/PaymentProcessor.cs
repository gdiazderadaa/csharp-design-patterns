using StrategyPattern.AbstractStrategy;

namespace StrategyPattern.Context
{
	public static class PaymentProcessor
	{

		public static string ProcessPayment(IPaymentProvider paymentProvider)
		{
			return paymentProvider.Pay();
		}

		/* Without the Strategy Pattern, out function will look like this:
		 * 
		 * public static string ProcessPayments(string paymentProvider)
		 * {
		 *		switch (paymentProvider)
		 *		{
		 *			case "ApplePay":
		 *				return "Paid by Apple Pay";
		 *			case "ApplePay":
		 *				return "Paid by Apple Pay";
		 *			case "ApplePay":
		 *				return "Paid by Apple Pay";
		 *			default":
		 *				return "Uknown payment provider";
		 *		}
		 * }
		 * 
		 * With the strategy pattern we don't need to modify this class when a new paymentprovider is required.
		 * We will just need to create a new implementation of the interface IPaymentProvider and call the 
		 * ProcessPayment function passing in an instance of the new implementation.
		 * 
		 */
	}
}
