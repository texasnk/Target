using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Target
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region JSON

            var json = File.ReadAllText(Directory.GetCurrentDirectory() + @"\dados.json");
            var data = JsonConvert.DeserializeObject<List<Dados>>(json);


            int a = 0, dayMax=0, dayMin=0;
            double Max = data[0].valor, Min= data[0].valor, total=0;
           

            for (int i = 0; i < data.Count; i++)
            {
                if (!(data[i].valor == 0)) a++;

                total += data[i].valor;
            }

            double average = total / a;
         

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].valor > average)
                {
                    Console.WriteLine($"\tDay: {data[i].dia} | Value: {data[i].valor.ToString("C")}\n\tHigher than the monthly average!\n");
                }
                if (data[i].valor>Max)
                {
                    Max = data[i].valor;
                    dayMax = data[i].dia;
                }
                if (data[i].valor<=Min && data[i].valor != 0)
                {
                    Min = data[i].valor;
                    dayMin = data[i].dia;
                }
            }


            Console.Write("\t");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n\n");


            Console.WriteLine($"\tDay: {dayMax} | Value: {Max.ToString("C")}\n\tThe highest value of the month!\n");
            Console.WriteLine($"\tDay: {dayMin} | Value: {Min.ToString("C")}\n\tThe Lowest value of the month!\n");

            #endregion




            Console.ReadKey();

        }
    }
}
