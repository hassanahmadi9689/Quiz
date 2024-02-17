using Taav.Contract;

namespace Quiz.Persistence.Ef;

public class EfUnitOfWork : UnitOfWork
{
    private readonly EfDataContext _context;

    public EfUnitOfWork(EfDataContext context)
    {
        _context = context;
    }

    public async Task Begin()
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task Complete()
    {
        await _context.SaveChangesAsync();
    }

    public async Task Commit()
    {
        await _context.Database.CommitTransactionAsync();
    }

    public async Task RollBack()
    {
        await _context.Database.RollbackTransactionAsync();
    }
}