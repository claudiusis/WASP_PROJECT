using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodAPP.Model;
using SQLite;

namespace FoodAPP.Database
{
    internal class DataBase
    {
        readonly SQLiteAsyncConnection _database;

        public DataBase(string db)
        {
            _database = new SQLiteAsyncConnection(db);
            _database.CreateTableAsync<Signin>().Wait();
        }

        public Task<Signin> GetLoginDataAsync(string username)
        {
            return _database.Table<Signin>().Where(i => i.UserName ==username).FirstOrDefaultAsync();
        }
        public Task SaveLoginDataAsync(Signin logdata) 
        {
            return _database.InsertAsync(logdata);        
        }
    }
}
