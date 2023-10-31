using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using JwtApp.Api.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace JwtApp.Api.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ApiDbContext _context;

        public Repository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
           return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(object id)
        {
           return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
             _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
