using System;
using System.Collections;
namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Fibonacci Kaça kadar gitsin : ");
            int input = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("\n");
                FibonacciHesapla(input);
                
        }
      
       static void  FibonacciHesapla(int limit)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            for (int i = 1; i < limit; i++)
            {
                decimal toplam = Convert.ToInt32(arrayList[i]) + Convert.ToInt32(arrayList[i-1]);
                arrayList.Add(toplam);
            }
            foreach (var item in arrayList) System.Console.WriteLine($"{arrayList.IndexOf(item) + 1} => {item}");
     
        }
    }
}
