namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyAllTests
	{
		[Test]
		public void Tax20Discount15ShouldAffectPriceAfterTax()
		{
			Product product = Product.Sample;

			Tax tax = new Tax(20);

			AffectPriceResult taxResult = tax.ApplyTo(product.Price);

			Discount discount = new Discount(15);

			AffectPriceResult discountResult = discount.ApplyTo(product.Price);

			Amount priceAfterAll = product.Price + taxResult.AffectedAmount - discountResult.AffectedAmount;

			Assert.AreEqual("20%", tax.ToString());
			Assert.AreEqual("$4.05", taxResult.AffectedAmount.ToString());

			Assert.AreEqual("15%", discount.ToString());
			Assert.AreEqual("$3.04", discountResult.AffectedAmount.ToString());
			
			Assert.AreEqual("$21.26", priceAfterAll.ToString());
		}
	}
}