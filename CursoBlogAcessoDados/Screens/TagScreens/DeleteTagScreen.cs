using CursoBlogAcessoDados.Models;
using CursoBlogAcessoDados.Repositories;
using System;

namespace CursoBlogAcessoDados.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluindo Tag");
            Console.WriteLine("_______________");

            Delete();

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete()
        {
            Console.Write("Id da tag a ser excluida: ");
            var id = Console.ReadLine();

            try
            {
                var repository = new Repository<Tag>(Database.connection);
                repository.Delete(int.Parse(id));
                Console.WriteLine("Tag excluida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
