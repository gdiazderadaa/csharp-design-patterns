using DesignPatterns.Behavioral.StrategyPattern.Strategies;
using DesignPatterns.Behavioral.StrategyPattern.Context;
using DesignPatterns.Behavioral.StrategyPattern.AbstractStrategy;
using System;

namespace DesignPatterns.Behavioral.StrategyPattern
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
