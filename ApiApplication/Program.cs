namespace ApiApplication;

public static class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
                _ = webBuilder.ConfigureLogging(options => options.AddConsole());
                _ = webBuilder.UseStartup<Startup>();
            });
}
