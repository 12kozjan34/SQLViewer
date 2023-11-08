using SqlViewer.Models;
using System.Data;

namespace SqlViewer.Dal
{
    internal interface IRepository
    {
        List<List<TableForShowing>> ReadData(string command);
        DataSet CreateDataSet(DBEntity dbEntity);
        string ExecuteCommand(string command);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
    }
}