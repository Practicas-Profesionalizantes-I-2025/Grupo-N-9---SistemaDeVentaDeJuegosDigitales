using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaJuegos.Datos.Contexto;

namespace TiendaJuegos.Datos.Repositorios
{
    public class Repositorio<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repositorio(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> ObtenerTodos() => await _dbSet.ToListAsync();
        public async Task<T> ObtenerPorId(int id) => await _dbSet.FindAsync(id);
        public async Task Agregar(T entidad)
        {
            await _dbSet.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }
        public async Task Actualizar(T entidad)
        {
            _dbSet.Update(entidad);
            await _context.SaveChangesAsync();
        }
        public async Task Eliminar(T entidad)
        {
            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
