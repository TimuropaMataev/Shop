namespace Shop.User;

#nullable disable

public class Registration
{
    private string _name = string.Empty;
    private int _age = 0;
    private int _password = 0;

    public void Name()
    {
        Console.Write("Name: ");
        string text = Console.ReadLine();

        bool isNumber = int.TryParse(text, out var value);

        if (isNumber is not true && text.Length > 1) _name = text;
        else throw new Exception("Name not set");
    }

    public void Age()
    {
        Console.Write("Age: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 4 && number < 120) _age = number;
        else throw new Exception("Age not set");
    }

    public void Password()
    {
        Console.Write("Password: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 999 && number < int.MaxValue) _password = number;
        else throw new Exception("Four numbers or more or range violation");
    }
}