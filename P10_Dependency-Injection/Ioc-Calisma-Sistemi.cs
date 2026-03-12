using P10_Dependency_Injection.Services;

namespace P10_Dependency_Injection
{
    public class Ioc_Calisma_Sistemi // Bu Sınıf .Net Core'da IoC'nin çalışma mantığını gösterir. Asp.Net Core'da genel olarak Program.cs dosyasında IServiceCollection üzerinden IoC Container'a servisler eklenir.
    {
        public Ioc_Calisma_Sistemi()
        {
            IServiceCollection services = new ServiceCollection();
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog())); // Service ekleme


            ServiceProvider provider = services.BuildServiceProvider(); // Nesneyi sağlayaak olan somut container
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>(); // ilgili sınıfı getirir.
        }

    }
}
