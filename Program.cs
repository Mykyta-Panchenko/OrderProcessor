using System;

class OrderProcessor
{
    public void ProcessOrder(string productName, int quantity, string paymentMethod, string customerEmail)
    {
        Console.WriteLine("Processing order...");
    
        if (!ValidateOrder(quantity))
            return;
    
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment(paymentMethod);
    
        EmailNotifier notifier = new EmailNotifier();
        notifier.SendEmail(customerEmail);
    
        Console.WriteLine("Order processed successfully.");
    }
    
    private bool ValidateOrder(int quantity)
    {
        if (quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return false;
        }
        return true;
    }
    
    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();
        processor.ProcessOrder("Laptop", 1, "CreditCard", "customer@example.com");
    }
}
