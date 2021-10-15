namespace Api.Application.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}