using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.StrategyPattern.AbstractStrategy
{
	public interface IPaymentProvider
	{
		string Pay();
	}
}
