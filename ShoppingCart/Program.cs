var shoppingCart = new ShoppingCart();

void AddToCart()
{
    string close = string.Empty;
    while (!close.Equals("n"))
    {
        string name = string.Empty;
        int quantity = 0;
        int price = 0;

        Console.Write("Product Name : ");
        name = Console.ReadLine();
        Console.Write("Quantity : ");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Price : ");
        price = Convert.ToInt32(Console.ReadLine());
        var product = new ShoppingCartEntry(name, quantity, price);
        shoppingCart.AddToCart(product);
        Console.Write("Add more items(y/n): ");
        close = Console.ReadLine();
    }

}

void ViewCart()
{
    Console.WriteLine("Cart");
    shoppingCart.Cart();

}

void CalculatePrice()
{
    Order order = new Order();
    double totalAmount = shoppingCart.TotalAmount();
    Console.WriteLine($"Total Amount :{order.GetTotalPrice(totalAmount)}");
}

try
{
    AddToCart();
    ViewCart();
    CalculatePrice();
}
catch (Exception ex)
{
    Console.WriteLine($"Something went wrong{ex.Message}");
}