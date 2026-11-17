namespace Demo.Pricing;

public static class DiscountCalculator
{
    // O percentual recebido é inteiro. Exemplo: 10 representa 10%.
    public static decimal ApplyDiscount(decimal subtotal, int discountPercent)
    {
        return subtotal * (1m - discountPercent / 100m);
    }
}