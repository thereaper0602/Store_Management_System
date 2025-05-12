using DAL.Model;

namespace DAL.Repository
{
    public interface ILoginDAL
    {
        User Login(string username, string password);
    }
}