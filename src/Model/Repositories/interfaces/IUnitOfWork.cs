namespace Model.Repositories.interfaces
{
    public interface IUnitOfWork
    {
        IAttributesRepository AttributesRepository { get; }

        void Save();
    }
}
