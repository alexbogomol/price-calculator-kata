namespace PriceCalculatorKata
{
	public class AffectPriceResult
	{
		public static AffectPriceResult Increase(Amount price, double ratio) => new AffectPriceResult
		{
			AffectedAmount = price * ratio,
			AffectedPrice = price * (1.0 + ratio)
		};

		public static AffectPriceResult Decrease(Amount price, double ratio) => new AffectPriceResult
		{
			AffectedAmount = price * ratio,
			AffectedPrice = price * (1.0 - ratio)
		};

		public Amount AffectedAmount { get; private set; }
		public Amount AffectedPrice { get; private set; }
	}

	public static class AffectPriceResultExtensions
	{
		public static string DescribeWith(this AffectPriceResult result, Product product, Tax tax) =>
			$"Product price reported as {product.Price} before tax and {result.AffectedPrice} after {tax} tax";

		public static string DescribeWith(this AffectPriceResult result, Product product, Discount discount) =>
			$"Discount: rate = {discount}, amount = {result.AffectedAmount}. Price: before = {product.Price}, after = {result.AffectedPrice}";
	}
}