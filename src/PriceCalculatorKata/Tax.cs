namespace PriceCalculatorKata
{
	using System;

	public class Tax : ICanAffectPrice
	{
		private readonly int _percent;
		private readonly double _ratio;

		public static Tax None => new Tax(0);

		public Tax(int percent)
		{
			if (percent < 0 || percent > 100)
				throw new ArgumentOutOfRangeException(
					nameof(percent), 
					$"{nameof(Tax)} percentage should be in range [0..100]");

			_percent = percent;

			_ratio = (double) _percent / 100;
		}

		public override string ToString() => $"{_percent}%";
		public AffectPriceResult ApplyTo(Amount price) => AffectPriceResult.Increase(price, _ratio);
	}
}