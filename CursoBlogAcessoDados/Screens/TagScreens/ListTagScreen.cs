using CursoBlogAcessoDados.Models;
using CursoBlogAcessoDados.Repositories;
using System;

namespace CursoBlogAcessoDados.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Tags");
            Console.WriteLine("_____________");
            
            List();
            
            Console.ReadKey();
            var slug = Console.ReadLine();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}
