﻿using Dapper.Contrib.Extensions;

namespace CursoBlogAcessoDados.Models
{
    [Table("[Category]")]
    class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Slug { get; set; }
    }
}
