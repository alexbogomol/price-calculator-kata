namespace PriceCalculatorKata
{
	using System;

	public struct Amount
	{
		private readonly double _value;

		public Amount(double value)
		{
			if (value < 0) throw new ArgumentOutOfRangeException(
				nameof(value), 
				"Amount cannot be negative");

			_value = SetupPrecision(value);
		}

		private static double SetupPrecision(double raw) => Math.Round(raw, 2, MidpointRounding.AwayFromZero);

		public static Amount operator + (Amount x, Amount y) => new Amount(x._value + y._value);
		public static Amount operator - (Amount x, Amount y) => new Amount(x._value - y._value);
		public static Amount operator * (Amount x, double multiplier) => new Amount(SetupPrecision(x._value * multiplier));

		public override string ToString() => $"${_value:F}";
	}
}