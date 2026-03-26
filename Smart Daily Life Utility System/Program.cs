class Program
{
    static void Main()
    {
    menu:
        Console.Clear();
        Console.WriteLine("==== Smart Daily Life Utility System ====\n" +
        "1. Health Checker\n" +
        "2. Shopping Calculator\n" +
        "3. Text Analeyzr\n" +
        "4. Exit\n");

        Console.Write("Enter command(1-4): ");
        int command = Convert.ToInt32(Console.ReadLine());

        if (command == 1)
        {
        healthMenu:
            Console.Clear();
            Console.WriteLine("=== Health Checker ===\n\n" +
            "1. BMI (Body Mass Index hisoblash)\n" +
            "2.Yosh kategoryasini aniqlash\n " +
            "3. Ideal vaznni aniqlash\n\n" +
            "4. Exit\n");

            Console.Write("Enter command(1-4): ");
            int healthCommand = Convert.ToInt32(Console.ReadLine());

            if (healthCommand == 1)
            {
                Console.Write("Buyingizni kiriting(metrda): ");
                double buy = Convert.ToDouble(Console.ReadLine());

                Console.Write("O'z tana vazningizni kiriting: ");
                double vazn = Convert.ToDouble(Console.ReadLine());

                double bmi = vazn / (buy * buy);

                Console.WriteLine($"Sizning BMI ko'rsatkichi: {bmi}");

                if (bmi < 18.5)
                    Console.WriteLine("Ozgin");
                else if (bmi >= 18.5 && bmi < 24.9)
                    Console.WriteLine("Normal vazn");
                else if (bmi >= 25 && bmi < 29.9)
                    Console.WriteLine("Ortiqcha vazn");
                else
                    Console.WriteLine("Semizlik");
            }
            else if (healthCommand == 2)
            {
                Console.Write("Yoshingizni kiriting: ");
                double yosh = Convert.ToDouble(Console.ReadLine());

                if (yosh > 0 && yosh <= 12)
                    Console.WriteLine("child");
                else if (yosh >= 13 && yosh <= 19)
                    Console.WriteLine("Teen");
                else if (yosh >= 20 && yosh <= 59)
                    Console.WriteLine("Adult");
                else
                    Console.WriteLine("Senior");
            }
            else if (healthCommand == 3)
            {
                Console.Write("Buyingizni kiriting(metrda): ");
                double buy = Convert.ToDouble(Console.ReadLine());

                double idealVazn = (buy - 100) * 0.9;
                Console.WriteLine($"Sizning ideal vazningiz: {idealVazn} kg");
            }
            else if (healthCommand == 4)
            {
                Console.WriteLine("Exiting Health Tools...");
                goto menu;
            }
            Console.Write("Health Checker ishini yakunlash(y/n): ");
            string exitHealth = Console.ReadLine();
            if (exitHealth.ToLower() == "y" || exitHealth.ToLower() == "yes")
                goto menu;

            goto healthMenu;
        }
        else if (command == 2)
        {
        shoppingCommand:
            Console.Clear();
            Console.WriteLine("=== Shopping Calculator ===\n\n" +
            "1. Mahsulot umumiy narxini hisoblash\n" +
            "2. Chegirmali narxni hisoblash\n" +
            "3. Xarid byudjetini tekshirish\n" +
            "4.QQS hisoblash\r\n"+
            "5. Exit\n");

            Console.Write("Enter command(1-4): ");
            int shoppingCommand = Convert.ToInt32(Console.ReadLine());

            if (shoppingCommand == 1)
            {
                Console.Write("Nechta mahsulot: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double sum = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Mahsulot {i + 1} narxi: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    sum += price;
                }

                Console.WriteLine("Umumiy summa: " + sum);

            }
            else if (shoppingCommand == 2)
            {
                Console.Write("Summani kiriting: ");
                double total = Convert.ToDouble(Console.ReadLine());

                double discount = 0;

                if (total > 1000000)
                    discount = total * 0.10;
                else if (total >= 500000)
                    discount = total * 0.05;

                Console.WriteLine("Chegirma: " + discount);
                Console.WriteLine("Yangi summa: " + (total - discount));
            }
            else if (shoppingCommand == 3)
            {
                { 
                    Console.Write("Xarid byudjetini kiriting: ");
                    double budget = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Xarid qilinadigan mahsulotlar sonini kiriting: ");
                    int productCount = Convert.ToInt32(Console.ReadLine());

                    double totalCost = 0;

                    for (int i = 1; i <= productCount; i++)
                    {
                        Console.Write($"Mahsulot {i} narxini kiriting: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        totalCost += price;
                    }

                    if (totalCost <= budget)
                    {
                        Console.WriteLine("Sizning byudjetingiz yetarli.");
                    }
                    else
                    {
                        Console.WriteLine("Sizning byudjetingiz yetarli emas.");
                    }
                }
            }
            else if(shoppingCommand==4)
            {
                Console.Write("Summani kiriting: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                double vat = amount * 0.12;
                double finalPrice = amount + vat;

                Console.WriteLine("QQS: " + vat);
                Console.WriteLine("Final narx: " + finalPrice);

            }
            else if (shoppingCommand == 5)
                {
                    Console.WriteLine("Exiting Shopping Calculator...");
                    goto menu;
                }

                Console.Write("Shopping Calculator ishini yakunlash(y/n): ");
                string exitShopping = Console.ReadLine();

                if (exitShopping.ToLower() == "y" || exitShopping.ToLower() == "yes")
                    goto menu;

                goto shoppingCommand;
        }
        else if (command == 3)
        {
        textMenu:
            Console.Clear();
            Console.WriteLine("=== Text Analeyzr ===\n\n" +
            "1. suzlr sonir\n" +
            "2. unli harflar soni\n" +
            "3. Palindrom tekshirish r\n" +
            "4. Exit\n");

            Console.Write("Enter command(1-4): ");
            int textCommand = Convert.ToInt32(Console.ReadLine());
            if (textCommand == 1)
            {
                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                Console.WriteLine($"suzlar soni: {text.Length}");
            }
            else if (textCommand == 2)
            {
                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                int harfSoni = 0;

                foreach (char c in text)
                {
                    if ("aeiouAEIOU".Contains(c))
                        harfSoni++;
                }
                Console.WriteLine($"Unli harflar soni:" + harfSoni);
            }
            else if (textCommand == 3)
            {
                Console.Write("suz kiriting: ");
                string text = Console.ReadLine();

                string reversed = "";
                for (int i = text.Length - 1; i >= 0; i--) {

                    reversed += text[i];
                }
                if (text == reversed)
                {
                    Console.WriteLine("Palindrom");
                }
                else {
                    Console.WriteLine("Palindrom emas");
                }
            }
            else if (textCommand == 4)
            {
                Console.WriteLine("Exiting Text Analeyzr...");
                goto menu;
            }

            Console.Write("Text Analeyzr ishini yakunlash(y/n): ");
            string exitText = Console.ReadLine();

            if (exitText.ToLower() == "y" || exitText.ToLower() == "yes")
                goto menu;

            goto textMenu;
        }
        else if (command == 4)
        {
            Console.WriteLine("Exiting Smart Daily Life Utility System...");
            return;
        }
        else
        {
            goto menu;
        }
    } 
}

    