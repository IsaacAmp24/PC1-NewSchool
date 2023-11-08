using PC1_NewSchool.Shared.Persistence.Contexts;

namespace PC1_NewSchool.Shared.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;
    
    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}