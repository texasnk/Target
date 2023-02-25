using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Target;

namespace Target_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region JSON

            var json = File.ReadAllText(Directory.GetCurrentDirectory() + @"\dados.json");
            var data = JsonConvert.DeserializeObject<List<Dados>>(json);

            double total = 0;


            for (int i = 0; i < data.Count; i++)
            { 
                total += data[i].valor;
            }

            Console.WriteLine($"Total value: {total.ToString("C")}\n");

            double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Others = 19849.53;

            var res = (SP * 100) / total;
            Console.WriteLine($"The percentage of SP to the total is {res.ToString("N")}%");
            res = (RJ * 100) / total;
            Console.WriteLine($"The percentage of RJ to the total is {res.ToString("N")}%");      
            res = (MG * 100) / total;
            Console.WriteLine($"The percentage of MG to the total is {res.ToString("N")}%");  
            res = (ES * 100) / total;
            Console.WriteLine($"The percentage of ES to the total is {res.ToString("N")}%");   
            res = (Others * 100) / total;
            Console.WriteLine($"The percentage of others to the total is {res.ToString("N")}%");


            #endregion




            Console.ReadKey();
        }
    }
}
