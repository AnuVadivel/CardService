﻿using System;
using CardPluginBase;

namespace VisaCardPlugin;

public class VisaCard : ICardPlugin
{
    public void MakePayment()
    {
        Console.WriteLine("The payment is done by Master MasterCard");
    }
}
