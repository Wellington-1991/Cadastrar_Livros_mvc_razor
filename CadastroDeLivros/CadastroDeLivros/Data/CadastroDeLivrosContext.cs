using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroDeLivros.Models;

    public class CadastroDeLivrosContext : DbContext
    {
        public CadastroDeLivrosContext (DbContextOptions<CadastroDeLivrosContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroDeLivros.Models.Livro> Livro { get; set; } = default!;
    }
