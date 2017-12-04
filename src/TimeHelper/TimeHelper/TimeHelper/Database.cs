using SQLite;
using System;
using System.Threading.Tasks;
namespace TimeHelper
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }

    class Database
    {
        static SQLiteAsyncConnection database;
        static TaskList ListOfTasks;
        public static void CreateDatabase(string filename)
        {
            database = new SQLiteAsyncConnection(filename);
            database.CreateTableAsync<Task>();
        }

        public static Task<Task> GetItem(Int32 id)
        {
            return database.GetAsync<Task> (id);
            
        }

        public static void SaveItem(Task item, String path)
        {
            var db = new SQLiteAsyncConnection(path);
            var status = db.InsertAsync(item);
            if (status.IsCanceled)
               status = db.UpdateAsync(item);
            return;

        }
    }
}
