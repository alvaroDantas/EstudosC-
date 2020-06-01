using System;
using System.Collections.Generic;
using System.Linq;
using ActionExample.Entities;

namespace ActionExample
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

            Action<Product> action = p => { p.Price += p.Price * 0.33; };

            Comparison<Product> comparison = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.ForEach(action);
            
            list.Sort(comparison);


            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
