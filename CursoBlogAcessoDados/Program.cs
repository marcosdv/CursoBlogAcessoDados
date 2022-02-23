using CursoBlogAcessoDados.Screens.TagScreens;
using Microsoft.Data.SqlClient;
using System;

namespace CursoBlogAcessoDados
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=MDV-NOTE;Database=Blog;Integrated Security=true;Trusted_Connection=true;";
        static void Main(string[] args)
        {
            Database.connection = new SqlConnection(CONNECTION_STRING);
            Database.connection.Open();

            Load();

            Console.ReadKey();

            Database.connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("______________");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 4: MenuTagScreen.Load(); break;
                default: Load(); break;
            }
        }
    }
}