using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceLiveScoring
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Create a ServiceHost for the CaseStudyService type.
            System.ServiceModel.ServiceHost serviceHost = new
                System.ServiceModel.ServiceHost(typeof(ScoreService));

            // Open the ServiceHost to create listeners and start listening for messages.
            serviceHost.Open();
            Console.WriteLine("Services are ready & running.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}