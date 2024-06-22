namespace Shop.Objects;

public interface IProduct<TId>
{
    public string Name { get; set; }

    public int Price { get; set; }

    public string Manufacturer { get; set; }

    public TId Id { get; set; }
}