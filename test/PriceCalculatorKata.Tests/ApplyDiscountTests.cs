namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyDiscountTests
	{
		[Test]
		public void Discount15ShouldDecreasePriceAfterTax()
		{
			ApplyDiscountResult result = new ApplyDiscountResult(Product.Sample, new Discount(15));

			string expected = "Discount: rate = 15%, amount = $3.04. Price: before = $20.25, after = $17.21";

			Assert.AreEqual(expected, result.Describe());
		}

		[Test]
		public void Discount10ShouldDecreasePriceAfterTax()
		{
			ApplyDiscountResult result = new ApplyDiscountResult(Product.Sample, new Discount(10));

			string expected = "Discount: rate = 10%, amount = $2.03. Price: before = $20.25, after = $18.22";

			Assert.AreEqual(expected, result.Describe());
		}

		[Test]
		public void NoneDiscountShouldNotAffectPrice()
		{
			ApplyDiscountResult result = new ApplyDiscountResult(Product.Sample, Discount.None);

			string expected = "Discount: rate = 0%, amount = $0.00. Price: before = $20.25, after = $20.25";

			Assert.AreEqual(expected, result.Describe());
		}
	}
}