namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyTaxTests
	{
		[Test]
		public void Tax20ShouldIncreasePriceAfterTax()
		{
			Product product = Product.Sample;

			Tax tax = new Tax(20);

			AffectPriceResult result = tax.ApplyTo(product.Price);

			string expected = "Product price reported as $20.25 before tax and $24.30 after 20% tax";

			Assert.AreEqual(expected, result.DescribeWith(product, tax));
		}

		[Test]
		public void Tax21ShouldIncreasePriceAfterTax()
		{
			Product product = Product.Sample;

			Tax tax = new Tax(21);

			AffectPriceResult result = tax.ApplyTo(product.Price);

			string expected = "Product price reported as $20.25 before tax and $24.50 after 21% tax";

			Assert.AreEqual(expected, result.DescribeWith(product, tax));
		}

		[Test]
		public void NoneTaxShouldNotAffectPrice()
		{
			Product product = Product.Sample;

			Tax tax = Tax.None;

			AffectPriceResult result = tax.ApplyTo(product.Price);

			string expected = "Product price reported as $20.25 before tax and $20.25 after 0% tax";

			Assert.AreEqual(expected, result.DescribeWith(product, tax));
		}
	}
}