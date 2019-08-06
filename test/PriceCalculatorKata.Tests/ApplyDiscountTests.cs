namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyDiscountTests
	{
		[Test]
		public void Discount15ShouldDecreasePriceAfterTax()
		{
			Product product = Product.Sample;

			Discount discount = new Discount(15);

			AffectPriceResult result = discount.ApplyTo(product.Price);

			string expected = "Discount: rate = 15%, amount = $3.04. Price: before = $20.25, after = $17.21";

			Assert.AreEqual(expected, result.DescribeWith(product, discount));
		}

		[Test]
		public void Discount10ShouldDecreasePriceAfterTax()
		{
			Product product = Product.Sample;

			Discount discount = new Discount(10);

			AffectPriceResult result = discount.ApplyTo(product.Price);

			string expected = "Discount: rate = 10%, amount = $2.03. Price: before = $20.25, after = $18.22";

			Assert.AreEqual(expected, result.DescribeWith(product, discount));
		}

		[Test]
		public void NoneDiscountShouldNotAffectPrice()
		{
			Product product = Product.Sample;

			Discount discount = Discount.None;

			AffectPriceResult result = discount.ApplyTo(product.Price);

			string expected = "Discount: rate = 0%, amount = $0.00. Price: before = $20.25, after = $20.25";

			Assert.AreEqual(expected, result.DescribeWith(product, discount));
		}
	}
}