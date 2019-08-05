namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ProductTests
	{
		[Test]
		public void TestProductDescriptor()
		{
			string expected = "Book with name = “The Little Prince”, UPC=12345, price=$20.25";

			Assert.AreEqual(expected, Product.Sample.Describe());
		}
	}
}
