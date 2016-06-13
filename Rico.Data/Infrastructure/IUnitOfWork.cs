namespace Rico.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}