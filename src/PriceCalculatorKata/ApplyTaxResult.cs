namespace PriceCalculatorKata
{
	using System;

	public class ApplyTaxResult
	{
		public ApplyTaxResult(Product product, Tax tax)
		{
			Product = product ?? throw new ArgumentNullException(nameof(product));
			Tax = tax ?? throw new ArgumentNullException(nameof(tax));

			TaxAmount = product.Price * tax.Ratio;
			PriceAfterTaxes = product.Price + TaxAmount;
		}

		public Amount TaxAmount { get; }
		public Amount PriceAfterTaxes { get; }
		public Tax Tax { get; }
		public Product Product { get; }
	}
}