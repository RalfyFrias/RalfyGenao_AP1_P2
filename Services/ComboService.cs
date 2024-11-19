using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using RalfyGenao_AP1_P2.DAL;
using RalfyGenao_AP1_P2.Models;
using System.Linq.Expressions;

namespace RalfyGenao_AP1_P2.Services
{
    public class ComboService(IDbContextFactory<Contexto> DbFactory)
    
        {
            public async Task<bool> Existe(int ComboId)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
                return await contexto.combo.AnyAsync(c => c.ComboId == ComboId);
            }

            private async Task<bool> Insertar(Combos combo)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
                contexto.combo.Add(combo);
                return await contexto.SaveChangesAsync() > 0;
            }
            private async Task<bool> Modificar(Combos combo)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
                contexto.combo.Update(combo);
                return await contexto.SaveChangesAsync() > 0;
            }
            public async Task<bool> Guardar(Combos combos)
            {
                if (!await Existe(combos.ComboId))
                    return await Insertar(combos);
                else
                    return await Modificar(combos);
            }

            public async Task<bool> Eliminar(int id)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
                var eliminado = await contexto.combo
                    .Where(c => c.ComboId == id)
                    .ExecuteDeleteAsync();
                return eliminado > 0;
            }
            public async Task<Combos?> Buscar(int id)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
                return await contexto.combo
                    .AsNoTracking()
                    .FirstOrDefaultAsync(r => r.ComboId == id);
            }

            public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> Criterio)
            {
                await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.combo
                .AsNoTracking()
                .Where(Criterio)
                .ToListAsync();
            }
        }
    }


