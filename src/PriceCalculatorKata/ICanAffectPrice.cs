namespace PriceCalculatorKata
{
	public interface ICanAffectPrice // IAppliesToPrice
	{
		//(Amount affectedAmount, Amount affectedPrice) ApplyTo(Amount price);
		AffectPriceResult ApplyTo(Amount price);
	}
}