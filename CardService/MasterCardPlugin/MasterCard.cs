using System;
using CardPluginBase;
using Microsoft.Extensions.Logging;

namespace MasterCardPlugin;

public class MasterCard : ICardPlugin
{
    public void MakePayment()
    {
        Console.WriteLine("The payment is done by Master MasterCard !");
        
        ILoggerFactory loggerFactory = LoggerFactory.Create(config => { });
        ILogger logger = loggerFactory.CreateLogger<MasterCard>();
            
        logger.LogInformation("Logging in MasterCard Pulgin");
    }
}
