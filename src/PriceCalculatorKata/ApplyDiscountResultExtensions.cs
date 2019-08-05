namespace PriceCalculatorKata
{
	public static class ApplyDiscountResultExtensions
	{
		public static string Describe(this ApplyDiscountResult result) => 
			$"Discount: rate = {result.Discount}, amount = {result.DiscountAmount}. Price: before = {result.Product.Price}, after = {result.PriceAfterDiscount}";
	}
}