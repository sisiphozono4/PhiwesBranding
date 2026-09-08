Console.WriteLine("=============================================");   
Console.WriteLine("              PHIWE'S BRANDING               ");
Console.WriteLine("          Custom Branding Services           ");
Console.WriteLine("============================================="); 
Console.WriteLine("\nWelcome to Phiwe's Branding!");
Console.WriteLine("Please select a service below to get started.");
Console.WriteLine("\nOUR SERVICES");
Console.WriteLine("1. BOARDS\n2. CUPS\n3. STICKERS");
Console.Write("\nSelect a service: ");

ProductSelector selector = new ProductSelector();

string serviceInput =  Console.ReadLine();

int serviceOption = selector.ValidateSelection(serviceInput, 3);

Order order = selector.SelectProduct(serviceOption);

Console.Write("\nEnter quantity: ");
string quantityInput = Console.ReadLine();

bool valid = int.TryParse(quantityInput, out int quantity);

while (!valid || quantity <= 0)
{
   Console.Write("Enter a quantity greater than 0: ");
   quantityInput = Console.ReadLine();
   valid = int.TryParse(quantityInput, out quantity);
}

order.Quantity = quantity;
order.CalculateTotal();

Console.WriteLine(order.ToString());

Console.WriteLine("\nORDER CONFIRMATION");
Console.WriteLine("To confirm your order:");
Console.WriteLine("1. Make a 50% deposit.\n2. Send your chosen image/design.\n3. Send proof of payment to our contact number.");
Console.WriteLine("\nCONTACT DETAILS");
Console.WriteLine("Contact: 063 xxx xxxx\nLocation: Gqeberha\nBank Name: Capitec\nAccount No: 1445xxxx");
Console.WriteLine("\nNOTE: Collections can take up to 5 working days.\n\nThank you for your support!");
