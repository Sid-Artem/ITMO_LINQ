using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<PC> pCs = new List<PC>()
            {

                new PC() { Marka = 1, GBHard = 500, GBVideo = 8, CPUFrequency = 3000, Cost = 100, RAM = 16, Quantity = 3, CPUType = "Intel" },
                new PC() { Marka = 2, GBHard = 1000, GBVideo = 4, CPUFrequency = 3200, Cost = 120, RAM = 32, Quantity = 1, CPUType = "AMD" },
                new PC() { Marka = 3, GBHard = 2000, GBVideo = 8, CPUFrequency = 4000, Cost = 150, RAM = 64, Quantity = 9, CPUType = "Intel" },
                new PC() { Marka = 4, GBHard = 1000, GBVideo = 4, CPUFrequency = 2500, Cost = 80, RAM = 32, Quantity = 8, CPUType = "AMD" },
                new PC() { Marka = 5, GBHard = 500, GBVideo = 8, CPUFrequency = 3300, Cost = 130, RAM = 64, Quantity = 10, CPUType = "Intel" },
                new PC() { Marka = 6, GBHard = 2000, GBVideo = 4, CPUFrequency = 3500, Cost = 100, RAM = 16, Quantity = 2, CPUType = "AMD" },
                new PC() { Marka = 7, GBHard = 500, GBVideo = 8, CPUFrequency = 3000, Cost = 90, RAM = 16, Quantity = 7, CPUType = "Intel" },






            };

            //Console.WriteLine("Введите тип процессора");
            //string prossesor= Console.ReadLine();
            //List<PC> pCs1 =pCs.Where(x => x.CPUType == prossesor).ToList();
            //Print(pCs1 );

            //Console.WriteLine("Введите объем ОЗУ");
            //int ozy = Convert.ToInt32(Console.ReadLine());
            //List<PC> pCs2 = pCs.Where(x => x.RAM >= ozy).ToList();
            //Print(pCs2);


            //List<PC> pCs3 = pCs.OrderBy(x=>x.Cost).ToList();
            //Print(pCs3);

            //IEnumerable<IGrouping<string, PC>> pCs4 = pCs.GroupBy(e => e.CPUType);
            //foreach (IGrouping<string, PC> gr in pCs4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach (PC e in gr) {  Console.WriteLine($"{e.Marka} {e.GBHard} {e.GBVideo} {e.CPUFrequency} {e.Cost} {e.RAM} {e.Quantity} {e.CPUType} "); }   


            //}

            //PC pCs5= pCs.OrderByDescending(x=>x.Cost).FirstOrDefault();
            //Console.WriteLine($"{pCs5.Marka},{pCs5.GBHard},{pCs5.Quantity},{pCs5.Cost}");

            //PC pCs6 = pCs.OrderByDescending(x => x.Cost).LastOrDefault();
            //Console.WriteLine($"{pCs6.Marka},{pCs6.GBHard},{pCs6.Quantity},{pCs6.Cost}");

            Console.WriteLine(pCs.Any(x => x.Quantity >= 30));



            Console.ReadKey();

        }

        static void Print(List<PC> pCs)
        {
            foreach (PC e in pCs)
            {

                Console.WriteLine($"{e.Marka} {e.GBHard} {e.GBVideo} {e.CPUFrequency} {e.Cost} {e.RAM} {e.Quantity} {e.CPUType} ");

            }
            Console.WriteLine();

        }   

    





} } 