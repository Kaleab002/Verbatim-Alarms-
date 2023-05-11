using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace Alaram101
{
    internal class SqliteDataAccess
    {
        public static List<TaskModel> LoadTask()
        {
            using (IDbConnection connect = new SQLiteConnection(LoadConnectionString())) // Opens connection string  and close in crash or when projcet is closed
            {
                var outPut = connect.Query<TaskModel>("select * from TaskTable", new DynamicParameters());//SQL from Selecting data and loading it 
                return outPut.ToList();
            }
        }
        public static void SaveTask(TaskModel task)
        {
            using (IDbConnection connect = new SQLiteConnection(LoadConnectionString()))// Opens connection string and close in crash or when projcet is closed
            {
                connect.Execute("insert into TaskTable (TaskName,TaskDescription) values (@TaskName,@TaskDescription)", task);//SQL for Inserting to the data 
            }


        }
        private static string LoadConnectionString(string id = "Default") //Loading Connection string from App.config
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;//Connecting to ConnectionString 

        }
        public static void DeleteTask(TaskModel task) // Opens connection string and close in crash or when projcet is closed
        {
            using (IDbConnection connect = new SQLiteConnection(LoadConnectionString()))
            {
                connect.Execute("delete from TaskTable", task);//SQL command from delete from the tabel
            }

        }
    }
}
