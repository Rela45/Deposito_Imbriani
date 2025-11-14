internal class Program
{
    public static void Main(string[] args)
    {
        var subj = NewsAgency.Instance;

        var MobileApp = new MobileApp();
        var EmailClient = new EmailClient();

        subj.AddSubscriber(EmailClient);
        subj.AddSubscriber(MobileApp);

        subj.News = "sono riuscito a implementare il singleton";
    }
}