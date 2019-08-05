namespace PriceCalculatorKata
{
	using System;

	public class ApplyTaxResult
	{
		public ApplyTaxResult(Tax tax, Product product)
		{
			Tax = tax ?? throw new ArgumentNullException(nameof(tax));
			Product = product ?? throw new ArgumentNullException(nameof(product));

			TaxAmount = product.Price * tax.Rate;
			PriceAfterTaxes = product.Price + TaxAmount;
		}

		public Amount TaxAmount { get; }
		public Amount PriceAfterTaxes { get; }
		public Tax Tax { get; }
		public Product Product { get; }
	}
}