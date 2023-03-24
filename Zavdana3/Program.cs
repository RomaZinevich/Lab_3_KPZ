public class DatavaseRepository
{
    private static DatavaseRepository instance;

    private DatavaseRepository() { }

    public static DatavaseRepository getInstance()
    {
        if (instance == null)
            instance = new DatavaseRepository();
        return instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DatavaseRepository datavase1 = DatavaseRepository.getInstance();
    }
}


