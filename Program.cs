Console.WriteLine("=============================================");   
Console.WriteLine("              PHIWE'S BRANDING               ");
Console.WriteLine("          Custom Branding Services           ");
Console.WriteLine("============================================="); 
Console.WriteLine("\nWelcome to Phiwe's Branding!");
Console.WriteLine("Please select a service below to get started.");
Console.WriteLine("\nOUR SERVICES");
Console.WriteLine("1. BOARDS\n2. CUPS\n3. STICKERS");
Console.Write("\nSelect a service: ");
int serviceOption = Convert.ToInt32(Console.ReadLine());

string product = "";
int price = 0;

if (serviceOption == 1)
{
    Console.WriteLine("\nBOARDS");
    Console.WriteLine("1. Welcome Board - R350\n2. Photo Booth - R450\n3. Canvas - R350");
    Console.Write("\nSelect a board type: ");
    int boardOption = Convert.ToInt32(Console.ReadLine());

    if (boardOption == 1)
    {
       product = "Welcome Board";
       price  = 350; 
    } 
    else if (boardOption == 2)
    {
       product = "Photo Booth";
       price = 450;
    }
    else if (boardOption == 3)
    {
       product = "Canvas";
       price = 350;
    }

}
else if (serviceOption == 2)
{
   Console.WriteLine("\nCUPS");
   Console.WriteLine("1. Personalized Cup - R10\n2. Cup with Lid - R15\n3. Personalized bottle - R75");
   Console.Write("\nSelect a cup type: ");
   int cupOption = Convert.ToInt32(Console.ReadLine());
   if (cupOption == 1)
    {
       product = "Personalized Cup";
       price  = 10; 
    }
   else if (cupOption == 2)
    {
       product = "Cup with Lid";
       price = 15;
    }
   else if (cupOption == 3)
    {
       product = "Personalized bottle";
       price = 75;
    }
}
else if (serviceOption == 3)
{
    Console.WriteLine("\nSTICKERS");
    Console.WriteLine("1. Sticker Only - R6\n2. Hennessy bottle - R35\n3. jc le Roux bottle - R35\n4. Water bottle - R6\n5. Party pack bucket - R15\n6. Thank You - R4");
    Console.Write("\nSelect a sticker type: ");
    int stickerOption = Convert.ToInt32(Console.ReadLine());
    if (stickerOption == 1)
    {
       product = "Sticker Only";
       price  = 6; 
    }
   else if (stickerOption == 2)
    {
       product = "Hennessy bottle";
       price = 35;
    }
   else if (stickerOption == 3)
    {
       product = "jc le Roux bottle";
       price = 35;
    }
    else if (stickerOption == 4)
    {
       product = "Water bottle";
       price = 6;
    }
    else if (stickerOption == 5)
    {
        product = "Party pack bucket";
        price = 15;
    
    }
    else if (stickerOption == 6)
    {
        product = "Thank You";
        price = 4;
    }
}
Console.Write("Enter quantity: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int total = price * quantity;

Console.WriteLine("\nORDER SUMMARY");
Console.WriteLine("Product: " + product);
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Price: R"+ price);
Console.WriteLine("Total: R" + total);


Console.WriteLine("\nORDER CONFIRMATION");
Console.WriteLine("To confirm your order:");
Console.WriteLine("1. Make a 50% deposit.\n2. Send your chosen image/design.\n3. Send proof of payment to our contact number.");
Console.WriteLine("\nCONTACT DETAILS");
Console.WriteLine("Contact: 063 xxx xxxx\nLocation: Gqeberha\nBank Name: Capitec\nAccount No: 1445xxxx");
Console.WriteLine("\nNOTE: Collections can take up to 5 working days.\n\nThank you for your support!");

