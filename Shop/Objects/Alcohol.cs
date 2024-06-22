namespace Shop.Objects;

public class Alcohol : IProduct<int>
{
    public string Name { get; set; } = string.Empty;

    public int Price { get; set; } = 0;

    public string Manufacturer { get; set; } = string.Empty;

    public int Id { get; set; } = 0;

    public void Print()
    {
        Console.WriteLine($"------\n" +
            $"Имя: {Name}\n" +
            $"Цена: {Price}\n" +
            $"Автор: {Manufacturer}\n" +
            $"Номер: {Id}\n");
    }
}