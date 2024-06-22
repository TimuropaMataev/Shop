using Shop.Objects;

namespace Shop.Logic;

public class Generator
{
    private readonly string[] namesOfGames =
        {"CS:GO", "Dota2", "Minecraft",
         "BrawlStars", "Agar.io", "GenshinImpact",
         "NeetforSpeed", "Shariki", "GTA5",
         "Kasynkya", "Dyrak", "AmongUs",
         "Skyrim", "AssassinsCreed"};
    private readonly string[] typesOfGames =
        {"Quest", "Action", "Strategy",
         "Logical", "Gambling", "Simulator",
         "Plot", "Sport", "Relaxing"};
    private readonly string[] manufacturersOfGames =
        {"SquareEnix", "Ubisoft", "Konami",
         "ElectronicArts", "BandaiNamco", "Sony",
         "Sega", "Nintendo", "ActivisionBlizzard"};
    private readonly string[] namesOfAlcohol =
        {"Vodka", "Beer", "Wine",
         "Cognac", "Chacha", "Rum",
         "Champagne", "Liquor", "Moonshine",
         "Martini"};
    private readonly string[] manufacturersOfAlcohol =
        {"Алкон", "АрсеналВин", "Фортуна",
         "Самовар", "Глазовский", "БранскСпиртПром"};

    public void ProductGame()
    {
        for (int i = 0; i < 5; i++)
        {
            var r = new Random();

            int name = r.Next(namesOfGames.Length);
            int type = r.Next(typesOfGames.Length);
            int manufacturer = r.Next(manufacturersOfGames.Length);

            var game = new Game
            {
                Name = namesOfGames[name],
                Type = typesOfGames[type],
                Manufacturer = manufacturersOfGames[manufacturer],
                Price = r.Next(200, 900),
                Id = r.Next(1, 1000)
            };

            game.Print();
        }
    }

    public void ProductAlcohol()
    {
        for (int i = 0; i < 5; i++)
        {
            var r = new Random();

            int name = r.Next(namesOfAlcohol.Length);
            int manufacturer = r.Next(manufacturersOfAlcohol.Length);

            var alcohol = new Alcohol
            {
                Name = namesOfAlcohol[name],
                Manufacturer = manufacturersOfAlcohol[manufacturer],
                Price = r.Next(400, 1500),
                Id = r.Next(1, 1000)
            };

            alcohol.Print();
        }
    }
}