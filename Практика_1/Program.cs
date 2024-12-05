using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Num = 1, Name= "Иванов", City= "Москва", Summa=100},
                new Employee(){Num = 2, Name= "Сидоров", City= "Сочи", Summa=110},
                new Employee(){Num = 3, Name= "Петров", City= "Спб", Summa=150},
                new Employee(){Num = 4, Name= "Кузнецов", City= "Иркутск", Summa=200},
                new Employee(){Num = 5, Name= "Васильев", City= "Москва", Summa=500},
                new Employee(){Num = 6, Name= "Бендер", City= "Спб", Summa=900},
                new Employee(){Num = 7, Name= "Воробьянинов", City= "Сочи", Summa=120},
                new Employee(){Num = 8, Name= "Балаганов", City= "Екатеринбург", Summa=60}

            };
            //Console.WriteLine("Введите город");
            //string city = Console.ReadLine();
            //List<Employee> employees1 = employees.Where(x => x.City == city).ToList();

            //Print(employees1 );



            //Console.WriteLine("Введите зп");
            //int summa = Convert.ToInt32(Console.ReadLine());
            //List<Employee> employees2 = employees.Where(x => x.Summa >= summa).ToList();

            //Print(employees2);




            //List<Employee> employees3 = employees.OrderBy(e => e.Name).ToList();

            //Print(employees3);

            //IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(e => e.City);
            //foreach (IGrouping<string, Employee> gr in employees4)
            //{

            //    Console.WriteLine(gr.Key);
            //    foreach (Employee e in gr)
            //    {
            //        Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
            //    }


            //    Employee employee5= employees.OrderByDescending(e => e.Summa).FirstOrDefault();
            //Console.WriteLine($"{employee5.Num} {employee5.Name} {employee5.Summa} {employee5.City}");

            Console.WriteLine(employees.Any(x=>x.Summa>200));

            
            Console.ReadKey();

            
        }
            static void Print(List<Employee> employees)
            {
                foreach (Employee e in employees)
                {

                    Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");

                }
                Console.WriteLine();

            }
    }



}


