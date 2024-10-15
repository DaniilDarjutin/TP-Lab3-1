class Program
{
    static void Main(string[] args)
    {
        // Singleton: GameManager
        Console.WriteLine("Singleton:");
        GameManager manager1 = GameManager.GetInstance();
        GameManager manager2 = GameManager.GetInstance();
        Console.WriteLine();

        // Builder: Создание героя
        Console.WriteLine("Builder:");
        HeroBuilder builder = new HeroBuilder();
        Hero hero = builder.SetName("Петя").SetHealth(100).SetStrength(60).Build();
        Console.WriteLine(hero);

        HeroBuilder builder1 = new HeroBuilder();
        Hero hero1 = builder.SetName("Алёша").SetHealth(60).SetStrength(50).Build();
        Console.WriteLine(hero);
        Console.WriteLine();

        // Factory Method: Создание врагов
        Console.WriteLine("Factory Method:");
        EnemyFactory orcFactory = new OrcFactory();
        Enemy orc = orcFactory.CreateEnemy();
        orc.Attack();

        EnemyFactory goblinFactory = new GoblinFactory();
        Enemy goblin = goblinFactory.CreateEnemy();
        goblin.Attack();
        Console.WriteLine();

        // Abstract Factory: Создание предметов
        Console.WriteLine("Abstract Factory:");
        ItemFactory easyFactory = new EasyItemFactory();
        Weapon easyWeapon = easyFactory.CreateWeapon();
        Potion easyPotion = easyFactory.CreatePotion();
        easyWeapon.Use();
        easyPotion.Drink();

        ItemFactory hardFactory = new HardItemFactory();
        Weapon hardWeapon = hardFactory.CreateWeapon();
        Potion hardPotion = hardFactory.CreatePotion();
        hardWeapon.Use();
        hardPotion.Drink();

        ItemFactory mediumFactory = new MediumItemFactory();
        Weapon mediumWeapon = mediumFactory.CreateWeapon();
        Potion mediumPotion = mediumFactory.CreatePotion();
        mediumWeapon.Use();
        mediumPotion.Drink();
    }
}
