namespace MyApp.Utilities
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
