namespace PriceCalculatorKata
{
	using System;

	public class ApplyDiscountResult
	{
		public ApplyDiscountResult(Product product, Discount discount)
		{
			Product = product ?? throw new ArgumentNullException(nameof(product));
			Discount = discount ?? throw new ArgumentNullException(nameof(discount));

			DiscountAmount = product.Price * discount.Ratio;
			PriceAfterDiscount = product.Price - DiscountAmount;
		}

		public Amount DiscountAmount { get; }
		public Amount PriceAfterDiscount { get; }
		public Discount Discount { get; }
		public Product Product { get; }
	}
}