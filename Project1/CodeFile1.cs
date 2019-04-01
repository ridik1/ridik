using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvit();
            Console.ReadKey();
        }


        static void Kvit()
        {
            Kvit kvit = new Kvit();
            kvit.SetInfo();
            kvit.GetInfo();
            Console.WriteLine();


        }
    }
    class Kvit

    {
        public int Number { get; set; }
        public string Data { get; set; }
        public float Sum { get; set; }

        public Kvit(int number, string data, float sum)
        {
            Number = number;
            Data = data;
            Sum = sum;
        }

        public Kvit()
        {
            Number = 0;
            Data = "";
            Sum = 0;
        }

        public void SetInfo()
        {
            Console.WriteLine("Ввод инфо о изделии: ");

            Console.Write("Номер: ");
            Number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Дата: ");
            Data = Convert.ToString(Console.ReadLine());

            Console.Write("Сумма: ");
            Sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Номер: {Number}");
            Console.WriteLine($"Дата: {Data}");
            Console.WriteLine($"Сумма: {Sum}");
        }
    }
}
