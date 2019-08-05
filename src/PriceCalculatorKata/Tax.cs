namespace PriceCalculatorKata
{
	using System;

	public class Tax
	{
		private readonly int _percent;

		public static Tax None => new Tax(0);

		public Tax(int percent)
		{
			if (percent < 0 || percent > 100)
				throw new ArgumentOutOfRangeException(
					nameof(percent), 
					$"{nameof(Tax)} percentage should be in range [0..100]");

			_percent = percent;

			Ratio = (double) _percent / 100;
		}

		public double Ratio { get; }

		public override string ToString() => $"{_percent}%";
	}
}