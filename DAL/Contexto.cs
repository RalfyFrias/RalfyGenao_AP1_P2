using Microsoft.EntityFrameworkCore;
using RalfyGenao_AP1_P2.Models;
using System.Collections.Generic;

namespace RalfyGenao_AP1_P2.DAL
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Registros> registros { get; set; }
    }
}
