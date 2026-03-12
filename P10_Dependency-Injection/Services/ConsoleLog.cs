namespace P10_Dependency_Injection.Services
{
    public class ConsoleLog : ILog
    {
        public ConsoleLog(int a)
        {
            
        }
        public void Log()
        {
            Console.WriteLine("Console Loglama İşlemi Gerçekleşti."); 
        }
    }
}
