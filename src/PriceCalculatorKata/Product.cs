namespace PriceCalculatorKata
{
	using System;

	public class Product
	{
		public static Product Sample => new Product("The Little Prince", 12345, new Amount(20.25));

		public Product(string name, int upc, Amount price)
		{
			if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(
				"Value cannot be null or whitespace.", 
				nameof(name));

			Name = name;
			Price = price;
			Upc = upc;
		}

		public string Name { get; }
		public Amount Price { get; }
		public int Upc { get; }
	}

	public static class ProductExtensions
	{
		public static string Describe(this Product product) =>
			$"Book with name = “{product.Name}”, UPC={product.Upc}, price={product.Price}";
	}
}