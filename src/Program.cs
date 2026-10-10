namespace WindowsServiceExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host
                .CreateDefaultBuilder(args)
                .UseWindowsService(options =>
                {
                    options.ServiceName = "WindowsServiceExample";
                })
                .ConfigureServices(services => {
                    services.AddHostedService<Worker>();
                });

            var host = builder.Build();
            host.Run();
        }
    }
}
