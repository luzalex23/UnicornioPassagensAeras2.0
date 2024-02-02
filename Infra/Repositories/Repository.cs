using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    public readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = context.Set<T>();
    }

    public async Task Add(T objeto)
    {
        await _dbSet.AddAsync(objeto);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T objeto)
    {
        _context.Entry(objeto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T objeto)
    {
        _dbSet.Remove(objeto);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetEntityById(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<List<T>> List()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.Where(expression).ToListAsync();
    }

    public Task<T> GetByName(string name)
    {
        throw new NotImplementedException();
    }
}
