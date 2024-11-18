using Microsoft.EntityFrameworkCore;
using RalfyGenao_AP1_P2.DAL;
using RalfyGenao_AP1_P2.Models;
using System.Linq.Expressions;

namespace RalfyGenao_AP1_P2.Services
{
    public class RegistroService(IDbContextFactory<Contexto> DbFactory)
    {
        //public async Task<bool> Existe(int RegistroId)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
          
        //}

        //private async Task<bool> Insertar(Registros registro)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
         
        //}
        //private async Task<bool> Modificar(Registros registro)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
            
        //}
        //public async Task<bool> Guardar(Registros registro)
        //{
     
        //}

        //public async Task<bool> Eliminar(int id)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
           
        //}
        //public async Task<Registros?> Buscar(int id)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
           
        //}

        //public async Task<List<Registros>> Listar(Expression<Func<Registros, bool>> Criterio)
        //{
        //    await using var contexto = await DbFactory.CreateDbContextAsync();
           
        //}
    }
}
