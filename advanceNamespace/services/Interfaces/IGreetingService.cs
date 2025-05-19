namespace MyApp.Services
{
    using MyApp.Models;

    public interface IGreetingService
    {
        void Greet(User user);
    }
}
