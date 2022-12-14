// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Runtime.Loader;
using CardPluginBase;
using Microsoft.Extensions.Logging;

namespace CardService
{
    public class Program
    {
        private static Dictionary<string, ICardPlugin> Plugins = new Dictionary<string, ICardPlugin>();

        private static string PluginPath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"Plugins"));

        public static void Main(string[] args)
        {
            Console.WriteLine("Application Started");
            
            ILoggerFactory loggerFactory = LoggerFactory.Create(config => { });
            ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
            
            logger.LogInformation("Logging in Card Service");
            
            LoadPlugins();
            foreach (var key in Plugins.Keys)
            {
                Plugins[key].MakePayment();
            }
        }

        public static void LoadPlugins()
        {
            foreach (var dll in Directory.GetFiles(PluginPath, "*.dll"))
            {
                AssemblyLoadContext assemblyLoadContext = new AssemblyLoadContext(dll);
                Assembly assembly = assemblyLoadContext.LoadFromAssemblyPath(dll);
                var CardPlugin = Activator.CreateInstance(assembly.GetTypes()[2]) as ICardPlugin;
                if (CardPlugin != null)
                {
                    Plugins.Add(Path.GetFileNameWithoutExtension(dll), CardPlugin);
                }
            }
        }
    }
   
}



