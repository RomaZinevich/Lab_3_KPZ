public abstract class Subscription
{
    protected double monthlyFee;
    public double MonthlyFee
    {
        set { monthlyFee = value; }
        get { return monthlyFee; }
    }

    protected int minimalSubscriptionPeriod;
    public int MinimalSubscriptionPeriod
    {
        set { minimalSubscriptionPeriod = value; }
        get { return minimalSubscriptionPeriod; }
    }

    protected List<string> channelList;
    public List<string> ChannelList
    {
        set { channelList = value; }
        get { return channelList; }
    }

    protected List<string> appendices;
    public List<string> Appendices
    {
        set { appendices = value; }
        get { return appendices; }
    }
}

public class DomesticSubscription : Subscription
{
    public DomesticSubscription()
    {
        MonthlyFee = 7.77;
        MinimalSubscriptionPeriod = 7;
        ChannelList = new List<string> {"1+1","CTБ","Новий","ICTV"};
        Appendices = new List<string> { "YouTube" };
    }
}

public class EducationalSubscription : Subscription
{
    public EducationalSubscription()
    {
        MonthlyFee = 14.99;
        MinimalSubscriptionPeriod = 14;
        ChannelList = new List<string> { "MEGOGO", "Volia TV", "Animal Planet", "Discovery" };
        Appendices = new List<string> { "Duolingo", "English Grammar Test", "Українська", "Microsoft Office Lens"};
    }
}

public class PremiumSubscription : Subscription
{
    public PremiumSubscription()
    {
        MonthlyFee = 29.99;
        MinimalSubscriptionPeriod = 30;
        ChannelList = new List<string> { "1+1", "CTБ", "MEGOGO", "Volia TV", "Animal Planet", "...and 199 channels" };
        Appendices = new List<string> { "YouTube", "NNetflix", "...and 20 appendices" };
    }
}

public abstract class Seller
{
    public abstract Subscription CreteSubscriptiom();
}

public class WebSite : Seller {
    public override Subscription CreteSubscriptiom()
    {
        return new DomesticSubscription();
    }
}
public class MobileApp : Seller  {
    public override Subscription CreteSubscriptiom()
    {
        return new EducationalSubscription();
    }
}
public class ManagerCall : Seller {
    public override Subscription CreteSubscriptiom()
    {
        return new PremiumSubscription();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Тест 
        Seller web = new WebSite();
        Console.WriteLine($"Ви успiшно купили пiдписку за : {web.CreteSubscriptiom().MonthlyFee}");

        Console.WriteLine();

        Seller mobile = new MobileApp();
        Console.WriteLine($"Ви успiшно купили пiдписку за : {mobile.CreteSubscriptiom().MonthlyFee}");

        Console.WriteLine();

        Seller manager = new ManagerCall();
        Console.WriteLine($"Ви успiшно купили пiдписку за : {manager.CreteSubscriptiom().MonthlyFee}");

    }
}