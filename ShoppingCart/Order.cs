class Order
{
    private double _tax = 0.1;//10 percent
    public double GetTotalPrice(double sum)
    {
        double totalPrice = sum + sum * _tax;
        return totalPrice;
    }
}