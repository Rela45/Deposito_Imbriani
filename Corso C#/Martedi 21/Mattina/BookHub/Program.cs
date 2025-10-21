#region Interfaces
using System.ComponentModel;
using System.Data.Common;
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
    private readonly ProductFactory _product;
    public Inventory(ProductFactory product)
    {
        _product = product;
    }
    public bool CheckStock(string productId, int quantity)
    {
        Console.WriteLine($"Verifico la disponibilita del {productId} per la quantita' {quantity}");
        return true; //funzione sempre true, non riesco a dare ancora una logica funzionale
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
#region Order
public class Order
{
    public string Id { get; set; }
    public decimal Prezzo { get; set; }
    public int qty{ get; set; }
}

#endregion

#region ORDERSERVICE
public class Orderservice
{
    private readonly IPaymentGateway _payment;
    private readonly IInventoryService _inventoryService;
    private readonly List<Order> _ordini = new();

    public INotificationService notificationService { get; set; }
    public IPricingStrategy pricingStrategy { get; set; }

    public Email email = new Email();

    public Orderservice(IPaymentGateway payment, IInventoryService inventoryService)
    {
        _payment = payment;
        _inventoryService = inventoryService;
    }
    public void AddOrder(Order ordine)
    {
        if (_inventoryService.CheckStock(ordine.Id, ordine.qty))
        {
            _ordini.Add(ordine);
            email.Send("Ordine Aggiunto correttamente");
        }
    }

    public void CreatePayment()
    {
        _payment.PaymentProcess();
        email.Send("Pagamento riuscito");
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

    public string CreateProduct()
    {
        IProduct product = FactoryMethod();
        return product.ProductCode();
    }
}

public class RealDigitalBook : ProductFactory
{
    public override IProduct FactoryMethod()
    {
        return new DigitalBook();
    }
}

public class RealPrintBook : ProductFactory
{
    public override IProduct FactoryMethod()
    {
        return new PrintedBook();
    }
}

#endregion

#region MAIN
class Program
{
    static void Main(string[] args)
    {
        ProductFactory book = new RealDigitalBook();
        book.CreateProduct();
        IInventoryService inventoryService = new Inventory(book);
        IPaymentGateway paymentGateway = new PaypalGateway();

        var orderService = new Orderservice(paymentGateway, inventoryService);

        // orderService.AddOrder(new Order {Id= book})  non riesco a prendere il product code e inserirlo come id dell'ordine, forse devo ragionarla diversamente

    }
}
#endregion