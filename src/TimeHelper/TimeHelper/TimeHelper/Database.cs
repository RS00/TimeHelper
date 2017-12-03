using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
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
            database.CreateTableAsync<TimeHelper.Task>();
        }

        public static Task<TimeHelper.Task> GetItem(Int32 id)
        {
            return database.GetAsync<TimeHelper.Task> (id);
            
        }

        public static void SaveItem(TimeHelper.Task item, String path)
        {
            var db = new SQLiteAsyncConnection(path);
            var status = db.InsertAsync(item);
            if (status.IsCanceled)
               status = db.UpdateAsync(item);
            return;

        }
    }
}
