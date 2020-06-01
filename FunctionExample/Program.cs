using System;
using System.Collections.Generic;
using System.Linq;
using FunctionExample.Entities;


namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();   

            list.Add(new Product("Pão", 4.00));
            list.Add(new Product("Leite", 3.00));
            list.Add(new Product("Arroz", 11.00));
            list.Add(new Product("Feijão", 7.00));
            list.Add(new Product("Refrigerante", 8.00));

            Func<Product, string> func = p => p.Name.ToUpper();

            var res = list.Select(func).ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


        }
    }
}
