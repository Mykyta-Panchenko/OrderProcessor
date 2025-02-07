using System;

class OrderProcessor
{
    public void ProcessOrder(string productName, int quantity, string paymentMethod, string customerEmail)
    {
        Console.WriteLine("Processing order...");

        // Перевірка наявності товару
        if (quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        // Обробка платежу
        if (paymentMethod == "CreditCard")
        {
            Console.WriteLine("Processing credit card payment...");
        }
        else if (paymentMethod == "PayPal")
        {
            Console.WriteLine("Processing PayPal payment...");
        }
        else
        {
            Console.WriteLine("Unknown payment method.");
            return;
        }

        // Надсилання підтвердження
        Console.WriteLine($"Sending confirmation email to {customerEmail}...");
        
        Console.WriteLine("Order processed successfully.");
    }

    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();
        processor.ProcessOrder("Laptop", 1, "CreditCard", "customer@example.com");
    }
}
