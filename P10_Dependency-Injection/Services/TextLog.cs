namespace P10_Dependency_Injection.Services
{
    public class TextLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Console Loglama İşlemi Gerçekleşti.");
        }
    }
}
