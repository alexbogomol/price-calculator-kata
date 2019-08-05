namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyAllTests
	{
		[Test]
		public void Tax20Discount15ShouldAffectPriceAfterTax()
		{
			Product product = Product.Sample;

			ApplyTaxResult taxResult = new ApplyTaxResult(product, new Tax(20));

			ApplyDiscountResult discountResult = new ApplyDiscountResult(product, new Discount(15));

			Amount priceAfterAll = product.Price + taxResult.TaxAmount - discountResult.DiscountAmount;

			Assert.AreEqual("20%", taxResult.Tax.ToString());
			Assert.AreEqual("$4.05", taxResult.TaxAmount.ToString());

			Assert.AreEqual("15%", discountResult.Discount.ToString());
			Assert.AreEqual("$3.04", discountResult.DiscountAmount.ToString());
			
			Assert.AreEqual("$21.26", priceAfterAll.ToString());
		}
	}
}