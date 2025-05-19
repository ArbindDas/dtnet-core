using MyApp.Services;
using MyApp.Models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IGreetingService greetingService = new GreetingService();
            User user = new User { FirstName = "Arbind", LastName = "Das" };

            greetingService.Greet(user);
        }
    }
}


// Feature | Usage
// Nested Namespaces | MyApp.Services.Interfaces, MyApp.Models, etc.
// Interfaces | IGreetingService abstraction
// Dependency Injection Style | Using IGreetingService to reference GreetingService
// Static Utility Class | Logger
// Strong Separation of Concerns | Models, services, utilities in separate folders/namespaces



// 🚀 Benefits of This Structure
// Easy to scale as your app grows.

// Code is clean, modular, and testable.

// Follows SOLID principles (especially Interface Segregation and Dependency Inversion).

// Mimics real-world enterprise .NET projects.

// Let me know if you'd like this as a downloadable .NET Console App or want a version using ASP.NET Core.