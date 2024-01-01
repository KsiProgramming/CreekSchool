namespace CreekSchool.AzureFunctions
{
    using CreekSchool.Sql;
    using Microsoft.Extensions.Hosting;

    public static class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices((ctx, services) =>
                {
                    services.AddPersistence();
                    services.AddCoreServices();
                })
                .Build();

            host.Run();
        }
    }
}