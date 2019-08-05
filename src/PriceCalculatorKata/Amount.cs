namespace PriceCalculatorKata
{
	using System;

	/// <summary>
	/// to pay = price + tax - discount : amount of money
	/// </summary>
	public struct Amount
	{
		private readonly double _value;

		public Amount(double value)
		{
			if (value < 0) throw new ArgumentOutOfRangeException(
				nameof(value), 
				"Amount cannot be negative");

			_value = value;
		}

		public static Amount operator + (Amount x, Amount y) => new Amount(x._value + y._value);
		public static Amount operator * (Amount x, double multiplier) => new Amount(x._value * multiplier);

		public override string ToString() => $"${_value:#.00}";
	}
}