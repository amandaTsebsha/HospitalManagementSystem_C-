using Microsoft.ASPNetCore.Hosting;
using Microsoft.Extension.Hosting;

namespace HMS 
{
    public class Program
    {
        public static void Main(String[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostbuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => 
                {
                    webBuilder.UserStartuo<Startup>();
                });
    }
}