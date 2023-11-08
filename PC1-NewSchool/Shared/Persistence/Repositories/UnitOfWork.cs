using PC1_NewSchool.Shared.Domain.Repositories;
using PC1_NewSchool.Shared.Persistence.Contexts;

namespace PC1_NewSchool.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}