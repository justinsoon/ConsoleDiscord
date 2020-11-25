using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BOT
{
    public static class Helpers
    {
        public static string RandomIntAsString()
        {
            Random random = new Random();
            return random.Next(int.MaxValue).ToString();
        }

        public static void PrintRuntimeStats()
        {
            Console.WriteLine(new StringBuilder()
                .Append($"{DateTime.Now} :: {Utility.Runtime.Elapsed} Elapsed")
                .Append(" & ")
                .Append($"{TimeSpan.FromHours(ENV.RuntimeInHours) - Utility.Runtime.Elapsed} Remaining")
                .ToString());
        }

        public static void PrintDashes(int amount)
        {
            for (int i = 0; i < amount; i++)
                Console.Write("-");

            Console.WriteLine();
        }

        public static void PrintEnclosedInNewLines(string content)
        {
            Console.Write(Environment.NewLine);
            Console.Write(content);
            Console.Write(Environment.NewLine);
        }

        public static void PrintDisclaimer()
        {
            Console.WriteLine();
            Console.WriteLine("          # # # # # # # # # # # # # # # # DISCLAIMER # # # # # # # # # # # # # # # #");
            Console.WriteLine("          #                THIS BOT IS FOR RESEARCH PURPOSES ONLY.                 #");
            Console.WriteLine("          #     USE IT AT YOUR OWN RISK! IF YOU GET BANNED IT'S NOT MY PROBLEM.    #");
            Console.WriteLine("          #          PLEASE UPDATE OFFSETS DEPENDENT ON YOUR PROGRESS              #");
            Console.WriteLine("          # TO CHANGE THIS: FORK, CHANGE, BUILD. DON'T ASK FOR CHANGES OR UPDATES. #");
            Console.WriteLine("          # # # # # # # # # # # # # # # # DISCLAIMER # # # # # # # # # # # # # # # #");
            Console.WriteLine();
        }
    }
}
