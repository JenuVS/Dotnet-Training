public class ShoppingCart
{
    public readonly List <ShoppingCartEntry>_entries;

    public ShoppingCart()
    {
        _entries = new List<ShoppingCartEntry>();
    }

    public void AddToCart(ShoppingCartEntry cart)
    {
        _entries.Add(cart);

    }

    public int TotalAmount()
    {
        int total = 0;
        foreach (var item in _entries)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }

    public void Cart()
    {
        foreach (var item in _entries)
        {
            Console.WriteLine(item);
        }
    }
}