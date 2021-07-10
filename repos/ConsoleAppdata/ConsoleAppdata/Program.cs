using System;

namespace ConsoleAppdata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ура я работаю");
            Console.WriteLine("Введите первую дату в формате xx.xx.xxxx");
            String data1 = Console.ReadLine();
            Console.WriteLine("Введите вторую дату в формате xx.xx.xxxx");
            String data2 = Console.ReadLine();

            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
          
            int day = Convert.ToInt32(data1.Substring(0, 2)) - Convert.ToInt32(data2.Substring(0, 2));
            int month = Convert.ToInt32(data1.Substring(3, 2)) - Convert.ToInt32(data2.Substring(3, 2));
            if (month<0) {
                month *= -1;
                day *= -1;
            }
            if (day<0) {
                day+=months[Convert.ToInt32(data2.Substring(3, 2)) - 1];
                month--;
            }

            Console.WriteLine("Между данными датами "+day+" дней и "+month+" месяцев ");
            Console.Write("Нажмите пожалусто");
            Console.ReadKey();
        }
    }
}
