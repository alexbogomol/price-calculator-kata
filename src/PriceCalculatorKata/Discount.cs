namespace PriceCalculatorKata
{
	using System;

	public class Discount : ICanAffectPrice
	{
		private readonly int _percent;

		private readonly double _ratio;

		public static Discount None => new Discount(0);

		public Discount(int percent)
		{
			if (percent < 0 || percent > 100)
				throw new ArgumentOutOfRangeException(
					nameof(percent), 
					$"{nameof(Discount)} percentage should be in range [0..100]");

			_percent = percent;

			_ratio = (double) _percent / 100;
		}

		public override string ToString() => $"{_percent}%";
		public AffectPriceResult ApplyTo(Amount price) => AffectPriceResult.Decrease(price, _ratio);
	}
}