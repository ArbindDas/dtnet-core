using MyApp.Models;
using MyApp.Utilities;

namespace MyApp.Services
{
    public class GreetingService : IGreetingService
    {
        public void Greet(User user)
        {
            Logger.Log($"Hello, {user.FirstName} {user.LastName}!");
        }
    }
}
