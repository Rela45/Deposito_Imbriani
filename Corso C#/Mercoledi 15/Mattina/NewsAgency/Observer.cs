using System.Net;

public interface INewsSubscriber
{
    void Update(string news);
}

public class NewsAgency
{
    private static NewsAgency _instance;
    private string _news;
    private readonly List<INewsSubscriber> _newsAgencyList = new List<INewsSubscriber>();

    public NewsAgency(){}
    public static NewsAgency Instance
    {
        get { if (_instance != null) { _instance = new NewsAgency(); } return _instance; }
    }

    public string News
    {
        get { return _news; }
        set {
            _news = value;
            notify();
            }

    }

    public void addSubscriber(INewsSubscriber newsSubscriber)
    {
        _newsAgencyList.Add(newsSubscriber);
    }

    public void removeSubscriber(INewsSubscriber newsSubscriber)
    {
        _newsAgencyList.Remove(newsSubscriber);
    }

    public void notify()
    {
        foreach(INewsSubscriber newsSubscriber in _newsAgencyList)
        {
            newsSubscriber.Update(News);
        }
    }
}


class MobileApp : INewsSubscriber
{
    public void Update(string news)
    {
        Console.WriteLine($"Notification on mobile: {news}");
    }
}

class EmailClient : INewsSubscriber
{
    public void Update(string news)
    {
        Console.WriteLine($"Email sent: {news}");
    }
}