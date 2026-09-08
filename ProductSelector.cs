public class ProductSelector
{
    public int ValidateSelection(string userInput, int maximum)
    {
        bool valid = int.TryParse(userInput, out int selection);
        while (!valid || selection < 1 || selection > maximum)
        {
            Console.Write("Invalid response. Please enter a number between 1 and " + maximum + ": ");
            userInput = Console.ReadLine();
            valid = int.TryParse(userInput, out selection);
        }

        return selection;
    }

    public void ProductMenu(int serviceOption)
    {
        if (serviceOption == 1)
        {
            Console.WriteLine("\nBOARDS");
            Console.WriteLine("1. Welcome Board - R350\n2. Photo Booth - R450\n3. Canvas - R350");
        }
        else if (serviceOption == 2)
        {
            Console.WriteLine("\nCUPS");
            Console.WriteLine("1. Personalized Cup - R10\n2. Cup with Lid - R15\n3. Personalized bottle - R75");
        }
        else if (serviceOption == 3)
        {
            Console.WriteLine("\nSTICKERS");
            Console.WriteLine("1. Sticker Only - R6\n2. Hennessy bottle - R35\n3. jc le Roux bottle - R35\n4. Water bottle - R6\n5. Party pack bucket - R15\n6. Thank You - R4");
        }
    }

    public Order SelectProduct(int serviceOption)
    {
        string product = "";
        int price = 0;

        ProductMenu(serviceOption);

        if (serviceOption == 1)
        {
            Console.Write("\nSelect a board type: ");
            string boardInput = Console.ReadLine();

            int boardOption = ValidateSelection(boardInput, 3);

            if (boardOption == 1)
            {
                product = "Welcome Board";
                price = 350;
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
            Console.Write("\nSelect a cup type: ");
            string cupInput = Console.ReadLine();

            int cupOption = ValidateSelection(cupInput, 3);

            if (cupOption == 1)
            {
                product = "Personalized Cup";
                price = 10;
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
            Console.Write("\nSelect a sticker type: ");
            string stickerInput = Console.ReadLine();

            int stickerOption = ValidateSelection(stickerInput, 6);

            if (stickerOption == 1)
            {
                product = "Sticker Only";
                price = 6;
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
        return new Order(product, price);
    }
}
