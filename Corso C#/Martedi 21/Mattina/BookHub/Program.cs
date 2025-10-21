#region Interfaces
public interface IInventoryService
{
    bool CheckStock(string productId, int quantity);
    void ReserveStock(string productId, int quantity);
}

public interface IPaymentGateway
{
    void PaymentProcess();
}

public interface INotificationService
{
    void Send(string message);
}

public interface IPricingStrategy
{
    decimal ApplyPricing(decimal basePrice);
}
#endregion

#region Implementation

public class PaypalGateway : IPaymentGateway
{
    public void PaymentProcess()
    {
        Console.WriteLine($"Payment with Paypal");
    }
}

public class StripeGateway : IPaymentGateway
{
    public void PaymentProcess()
    {
        Console.WriteLine($"Payment with Stripe");
    }
}


#endregion



#region MAIN
class Program
{
    static void Main(string[] args)
    {

    }
}
#endregion