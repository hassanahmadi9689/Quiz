namespace Taav.Contract;

public interface UnitOfWork
{
    Task Begin();
    Task Complete();
    Task Commit();
    Task RollBack();
}