namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ITodoRepository Todo { get; }
        IUserRepository User { get; }
        void Save();
    }
}
