namespace CreekSchool.AzureFunctions
{
    using Microsoft.Extensions.Hosting;

    public static class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices((ctx, services) =>
                {
                    services.AddCoreServices();
                })
                .Build();

            host.Run();
        }
    }
}



