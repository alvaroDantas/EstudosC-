using System;
using System.Linq;
using System.Collections.Generic;
using PredicateExample.Entities;

namespace PredicateExample
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
            

            Predicate<Product> op = p => p.Price < 5;


            list.RemoveAll(op);//remover produtos com preco menor que 5
            list.RemoveAll(p => p.Price % 2 == 0);//remover produto com o preco par

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
