using System;
using System.Text;
using efcoremysql.Models;
using Microsoft.EntityFrameworkCore;

namespace efcoremysql
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            PrintData();
        }

        private static void InsertData()
        {
            using (var context = new MyDbContext())
            {

                var album = new Album()
                {
                    Nome = "Acústico MTV - Legião Urbana",
                    Ano = 1999,
                    Email = "contato@legiaourbana.com.br"
                };

                context.Albuns.Add(album);

                context.Musicas.Add(new Musica
                {
                    Nome = "Índios",
                    Album = album
                });
                context.Musicas.Add(new Musica
                {
                    Nome = "Pais e Filhos",
                    Album = album
                });

                context.Musicas.Add(new Musica
                {
                    Nome = "Eu sei",
                    Album = album
                });

                context.SaveChanges();
            }
        }

        private static void PrintData()
        {
            using (var context = new MyDbContext())
            {
                var musicas = context.Musicas.Include(m => m.Album);
                foreach (var musica in musicas)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Musica: {musica.Nome}");
                    data.AppendLine($"Album: {musica.Album.Nome}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}
