using Microsoft.EntityFrameworkCore;
using ProjetoWebReact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebReact.Configuracao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
           
            Database.EnsureCreated();

        }

        public DbSet<Produto> Produto { get; set; }


    }
}
