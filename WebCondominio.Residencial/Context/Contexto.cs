using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCondominio.Residencial.Models;

namespace WebCondominio.Residencial.Context
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Morador> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Morador>().HasKey(m => m.IdMorador);
            base.OnModelCreating(builder);
        }
    }
}
