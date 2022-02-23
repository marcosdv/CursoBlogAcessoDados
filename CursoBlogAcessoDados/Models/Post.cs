using Dapper.Contrib.Extensions;

namespace CursoBlogAcessoDados.Models
{
    [Table("[Post]")]
    class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
