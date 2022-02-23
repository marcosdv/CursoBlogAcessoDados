using CursoBlogAcessoDados.Models;
using CursoBlogAcessoDados.Repositories;
using System;

namespace CursoBlogAcessoDados.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando Tag");
            Console.WriteLine("_______________");

            Update();

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update()
        {
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag
            {
                Id = int.Parse(id),
                Name = nome,
                Slug = slug
            };

            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
