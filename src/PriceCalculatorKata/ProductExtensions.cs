namespace PriceCalculatorKata
{
	public static class ProductExtensions
	{
		public static string Describe(this Product product) =>
			$"Book with name = “{product.Name}”, UPC={product.Upc}, price={product.Price}";
	}
}