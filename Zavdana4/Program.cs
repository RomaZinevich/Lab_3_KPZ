public interface IVirus
{
    public IVirus Clone();
}

public class Virus : IVirus
{
    protected double weight;
    public double Weight { set; get; }

    protected int age;
    public int Age { set; get; }

    protected string name;
    public string Name { set; get; }

    protected string type;
    public string Type { set; get; }

    public VirusChild[] viruses;

    public Virus(double weight, int age,string name, string type, VirusChild[] viruses)
    {
        this.weight = weight;
        this.age = age;
        this.name = name;
        this.type = type;
        this.viruses = viruses;
    }

    public IVirus Clone()
    {
        return this.MemberwiseClone() as IVirus;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Iм'я вiруса - {this.name}");
        Console.WriteLine($"Рокiв - {this.age}");
        Console.WriteLine($"Тип вiруса - {type}");
        Console.WriteLine($"Вага вiруса - {weight}");
        for(int i=0;i<viruses.Length;i++)
        {
            Console.WriteLine($"Дитя - {i+1}");
            viruses[i].GetInfo();
        }
    }
}

public class VirusChild
{
    protected DateTime birthDate;
    public DateTime BirthDate { set; get; }

    protected Virus parent;
    public Virus Parent { set; get; }

    public VirusChild(DateTime birthDate)
    {
        this.birthDate = birthDate;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Рiк народження - {birthDate}");
    }
}

public class Program
{
    static void Main(string[] args)
    {

        VirusChild[] virusesChild = new VirusChild[] { new VirusChild(new DateTime(2020, 3, 24)) };

        Virus virus = new Virus(0.0002 , 2, "COVID-19", "SARS-CoV-2", virusesChild);

        Virus virusClone = virus.Clone() as Virus;

        virus.GetInfo();

        Console.WriteLine();

        virusClone.GetInfo();
    }
}