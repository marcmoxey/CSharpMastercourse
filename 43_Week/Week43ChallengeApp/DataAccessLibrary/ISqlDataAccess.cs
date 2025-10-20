
namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName);
        void SaveData<T>(string sqlStatement, T parameter, string connectionStringName);
    }
}