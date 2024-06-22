namespace Shop.Objects;

public class Game : IProduct<int>
{
    public string Name { get; set; } = string.Empty;

    public int Price { get; set; } = 0;

    public string Manufacturer { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public int Id { get; set; } = 0;

    public void Print()
    {
        Console.WriteLine($"------\n" +
            $"Имя: {Name}\n" +
            $"Цена: {Price}\n" +
            $"Автор: {Manufacturer}\n" +
            $"Жанр: {Type}\n" +
            $"Номер: {Id}\n");
    }
}