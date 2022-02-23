using CursoBlogAcessoDados.Models;
using CursoBlogAcessoDados.Repositories;
using System;

namespace CursoBlogAcessoDados.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("________");

            Create();

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag
            {
                Name = nome,
                Slug = slug
            };

            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a Tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
