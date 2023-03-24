public abstract class Clothing
{
    public abstract void Info();
}

public class WomenClothers : Clothing
{
    public string type;

    public WomenClothers(string type) { this.type = type; }

    public override void Info()
    {
        Console.WriteLine($"Жiноча одежа : {type}");
    }
}

public class ManClothers : Clothing
{
    public string type;

    public ManClothers(string type) { this.type = type; }

    public override void Info()
    {
        Console.WriteLine($"Чоловiча одежа : {type}");
    }
}

public class KidsClothers : Clothing
{
    public string type;

    public KidsClothers(string type) { this.type = type; }

    public override void Info()
    {
        Console.WriteLine($"Дитяча одежа : {type}");
    }
}

public abstract class ClothesFactory
{
    public abstract Clothing CreateWomenClothers(string type);
    public abstract Clothing CreateManClothers(string type);
    public abstract Clothing CreateKidsClothers(string type);
}

public class Footwear : ClothesFactory
{
    public override Clothing CreateWomenClothers(string type)
    {
        return new WomenClothers(type);
    }
    public override Clothing CreateManClothers(string type)
    {
        return new ManClothers(type);
    }
    public override Clothing CreateKidsClothers(string type)
    {
        return new KidsClothers(type);
    }
}

public class Pants : ClothesFactory
{
    public override Clothing CreateWomenClothers(string type)
    {
        return new WomenClothers(type);
    }
    public override Clothing CreateManClothers(string type)
    {
        return new ManClothers(type);
    }
    public override Clothing CreateKidsClothers(string type)
    {
        return new KidsClothers(type);
    }
}

public class T_shirt : ClothesFactory
{
    public override Clothing CreateWomenClothers(string type)
    {
        return new WomenClothers(type);
    }
    public override Clothing CreateManClothers(string type)
    {
        return new ManClothers(type);
    }
    public override Clothing CreateKidsClothers(string type)
    {
        return new KidsClothers(type);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClothesFactory footwear = new Footwear();
        ClothesFactory pants = new Pants();
        ClothesFactory t_shirt = new T_shirt();

        Clothing women = t_shirt.CreateWomenClothers("Футболка");
        Clothing man = pants.CreateManClothers("Штани");
        Clothing kids = footwear.CreateKidsClothers("Взуття");

        women.Info();
        man.Info();
        kids.Info();
    }
}