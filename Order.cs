public class Order
{
    public string Product { get; private set ;}
    public int Price { get; private set; }
    public int Quantity { get; set; }
    public int Total { get; private set; }

    public Order(string product, int price)
    {
        Product = product;
        Price = price;
    }
    public void CalculateTotal()
    {
        Total = Price * Quantity;
    }
    public override string ToString()
    {
        return "\nORDER SUMMARY" + "\nProduct: " + Product + "\nQuantity: " + Quantity + "\nPrice: R"+ Price + "\nTotal: R" + Total;
    }
}