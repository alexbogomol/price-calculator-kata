namespace PriceCalculatorKata
{
	public static class ApplyTaxResultExtensions
	{
		public static string Describe(this ApplyTaxResult result) => 
			$"Product price reported as {result.Product.Price} before tax and {result.PriceAfterTaxes} after {result.Tax} tax";
	}
}