namespace PriceCalculatorKata
{
	using System;

	public class Discount
	{
		private readonly int _percent;

		public static Discount None => new Discount(0);

		public Discount(int percent)
		{
			if (percent < 0 || percent > 100)
				throw new ArgumentOutOfRangeException(
					nameof(percent), 
					$"{nameof(Discount)} percentage should be in range [0..100]");

			_percent = percent;

			Ratio = (double) _percent / 100;
		}

		public double Ratio { get; }

		public override string ToString() => $"{_percent}%";
	}
}