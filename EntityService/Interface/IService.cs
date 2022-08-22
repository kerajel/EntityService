namespace EntityWeb.Interface
{
    public interface IService<T> where T : class
    {
        Task<T?> Get(Guid id);

        Task Add(T entry);
    }
}
