using Microsoft.EntityFrameworkCore;
using RalfyGenao_AP1_P2.Models;
using System.Collections.Generic;

namespace RalfyGenao_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Combos> combo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Combos>().HasData(new List<Combos>()
      {
    new Combos() {ComboId=1, Articulo="computadora "},
     new Combos() {ComboId=2, Articulo="mouse"},
      new Combos() {ComboId=3, Articulo="bocina"},
       new Combos() {ComboId=4, Articulo="teclado"},
        new Combos() {ComboId=5, Articulo="disco ssd"}
     });
        }

    }
}
