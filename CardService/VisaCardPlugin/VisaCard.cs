using CardPluginBase;
using System;
using Microsoft.Extensions.Logging;

namespace VisaCardPlugin;

public class VisaCard: ICardPlugin
{
    public void MakePayment()
    {
        Console.WriteLine("The payment is done by VisaCard");
        
        ILoggerFactory loggerFactory = LoggerFactory.Create(config => { });
        ILogger logger = loggerFactory.CreateLogger<VisaCard>();
            
        logger.LogInformation("Logging in VisaCard Pulgin");
    }

}
