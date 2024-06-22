using Shop.Logic;
using Shop.Show;
using Shop.User;

namespace Shop;

internal class Program
{
    static void Main(string[] args)
    {
        Message message = new();
        Registration registration = new();
        Generator generator = new();

        try
        {
            message.ShopMessage();
            message.RegistrationMessage();
            registration.Name();
            registration.Age();
            registration.Password();
            message.ProductMessage();
            generator.ProductGame();
            generator.ProductAlcohol();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}