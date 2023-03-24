public class Personage
{
    protected string name;
    protected int height;
    protected string hairColor;
    protected string eyeColor;
    protected string clothes;

    public Personage(string name, int height, string hairColor, string eyeColor, string clothes)
    {
        this.name = name;
        this.height = height;
        this.hairColor = hairColor;
        this.eyeColor = eyeColor;
        this.clothes = clothes;
    }

    public void InfoPersonage()
    {
        Console.WriteLine($"Iм'я персонажа - {this.name}");
        Console.WriteLine($"Зрiст персонажа - {this.height}");
        Console.WriteLine($"Колiр волосся персонажа - {this.hairColor}");
        Console.WriteLine($"Колiр очей персонажа - {this.eyeColor}");
        Console.WriteLine($"Одяг персонажа - {this.clothes}");
        Console.WriteLine();
    }
}

public interface Builder
{
    void SetName(string name);
    void SetHeight(int height);
    void SetHairColor(string hairColor);
    void SetEyeColor(string eyeColor);
    void SetClothes(string clothes);

    Personage GetInfo();
}

class HeroBuilder : Builder
{
    protected string name;
    protected int height;
    protected string hairColor;
    protected string eyeColor;
    protected string clothes;


    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public void SetHairColor(string hairColor)
    {
        this.hairColor = hairColor;
    }

    public void SetEyeColor(string eyeColor)
    {
        this.eyeColor = eyeColor;
    }

    public void SetClothes(string clothes)
    {
        this.clothes = clothes;
    }

    public Personage GetInfo()
    {
        return new Personage(this.name, this.height, this.hairColor, this.eyeColor, this.clothes);
    }
}

class EnemyBuilder : Builder
{
    protected string name;
    protected int height;
    protected string hairColor;
    protected string eyeColor;
    protected string clothes;

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public void SetHairColor(string hairColor)
    {
        this.hairColor = hairColor;
    }
    public void SetEyeColor(string eyeColor)
    {
        this.eyeColor = eyeColor;
    }

    public void SetClothes(string clothes)
    {
        this.clothes = clothes;
    }

    public Personage GetInfo()
    {
        return new Personage(this.name, this.height, this.hairColor, this.eyeColor, this.clothes);
    }
}

public class CreatePersonage
{
    public Builder builder;
    public CreatePersonage(Builder builder)
    {
        this.builder = builder;
    }

    public void CreateEnemy()
    {
        builder.SetName("Вася");
        builder.SetHeight(150);
        builder.SetHairColor("чорні");
        builder.SetEyeColor("зелені");
        builder.SetClothes("Футболка , штани , кросівкі");

    }

    public void CreateHero()
    {
        builder.SetName("Рома");
        builder.SetHeight(190);
        builder.SetHairColor("чорні");
        builder.SetEyeColor("сині");
        builder.SetClothes("Футболка , штани , кросівкі");
    }

}

class Program
{
    static void Main(string[] args)
    {

        CreatePersonage createHero = new CreatePersonage(new HeroBuilder());
        createHero.CreateHero();

        Personage hero = createHero.builder.GetInfo();
        hero.InfoPersonage();


        CreatePersonage createEnemy = new CreatePersonage(new EnemyBuilder());
        createEnemy.CreateEnemy();

        Personage enemy = createEnemy.builder.GetInfo();
        enemy.InfoPersonage();
    }
}