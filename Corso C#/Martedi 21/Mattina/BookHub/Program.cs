#region Interfaces
using System.ComponentModel;
public interface IProduct
{
    string ProductCode();
}
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

public class Inventory : IInventoryService
{
    public bool CheckStock(string productId, int quantity)
    {
        Console.WriteLine($"Verifico la disponibilita del {productId} per la quantita' {quantity}");
        return true;
    }

    public void ReserveStock(string productId, int quantity)
    {
        Console.WriteLine($"Riservo il {productId} in stock di {quantity}");
    }
}

public class Email : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:MM:ss}]: {message} inviato tramite Mail");
    }
}

public class SMS : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:MM:ss}]: {message} inviato tramite SMS");
    }
}

public class PushNotification : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:MM:ss}]: {message} :Notifica inviata");
    }
}



#endregion


#region ORDERSERVICE
public class Orderservice
{
    private readonly IPaymentGateway _payment;
    private readonly IInventoryService _inventoryService;

    public INotificationService notificationService { get; set; }
    public IPricingStrategy pricingStrategy{ get; set; }

    public Orderservice(IPaymentGateway payment, IInventoryService inventoryService)
    {
        _payment = payment;
        _inventoryService = inventoryService;
    }

    public void CreatePayment()
    {
        _payment.PaymentProcess();
    }
    public void BookOrder()
    {
        // if(_inventoryService.CheckStock(string productId, int quantity))
    }
}

#endregion
#region ConcreteClasses
public class DigitalBook : IProduct
{
    public string ProductCode()
    {
        return "BOOK_DIGITAL";
    }
}

public class PrintedBook : IProduct
{
    public string ProductCode()
    {
        return "BOOK_PRINT";
    }
}

#endregion

#region Factory
public abstract class ProductFactory
{
    public abstract IProduct FactoryMethod();

    public void CreateProduct()
    {
        IProduct product = FactoryMethod();
        product.ProductCode();
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