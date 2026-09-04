// See https://aka.ms/new-console-template for more information
Console.WriteLine("=============================================");   
Console.WriteLine("              PHIWE'S BRANDING               ");
Console.WriteLine("          Custom Branding Services           ");
Console.WriteLine("============================================="); 
Console.WriteLine("\nWelcome to Phiwe's Branding!");
Console.WriteLine("Please select a service below to get started.");
Console.WriteLine("\nOUR SERVICES");
Console.WriteLine("1. BOARDS\n2. CUPS\n3. STICKERS");
Console.Write("Select a service: ");

int serviceOption = Convert.ToInt32(Console.ReadLine());

if (serviceOption == 1)
{
    Console.WriteLine("\nBOARDS");
    Console.WriteLine("1. Welcome Board - R350\n2. Photo Booth - R450\n3. Canvas - R350");
    Console.Write("Select a board type: ");
    int boardOption = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine());
   
}
else if (serviceOption == 2)
{
   Console.WriteLine("\nCUPS");
   Console.WriteLine("1. Personalized Cup - R10\n2. Cup with Lid - R15\n3. Personalized bottle - R75");
   Console.Write("Select a cup type: ");
   int cupOption = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter quantity: ");
   int quantity1 = Convert.ToInt32(Console.ReadLine());
}
else if (serviceOption == 3)
{
    Console.WriteLine("\nSTICKERS");
    Console.WriteLine("1. Sticker Only - R6\n2. Hennessy bottle - R35\n3. jc le Roux bottle - R35\n4. Water bottle - R6\n5. Party pack bucket - R15\n6. Thank You - R4");
    Console.Write("Select a sticker type: ");
    int stickerOption = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter quantity: ");
    int quantity2 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nORDER CONFIRMATION");
Console.WriteLine("To confirm your order:");
Console.WriteLine("1. Make a 50% deposit.\n2. Send your chosen image/design.\n3. Send proof of payment to our contact number.");
Console.WriteLine("\nCONTACT DETAILS");
Console.WriteLine("Contact: 063 xxx xxxx\nLocation: Gqeberha\nBank Name: Capitec\nAccount No: 1445xxxx");
Console.WriteLine("\nNOTE: Collections can take up to 5 working days.\n\nThank you for your support!");

