using StrategyPattern.Strategies;
using StrategyPattern.Context;
using StrategyPattern.AbstractStrategy;
using System;

namespace StrategyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			// Define strategies which have to concrete implementation of the run method
			IPaymentProvider googlePay = new GooglePayPaymentProvider();
			IPaymentProvider applePay = new ApplePayPaymentProvider();
			IPaymentProvider paypal = new PayPalPaymentProvider();

			// Call the context with different concrete implementations
			Console.WriteLine(PaymentProcessor.ProcessPayment(googlePay));
			Console.WriteLine(PaymentProcessor.ProcessPayment(applePay));
			Console.WriteLine(PaymentProcessor.ProcessPayment(paypal));

			Console.ReadLine();
		}
	}
}
