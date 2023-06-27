namespace API_LIBROS.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUser (string username, string pass);
    }
}
