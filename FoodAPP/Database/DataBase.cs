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
            _database.CreateTableAsync<LoginModel>().Wait();
        }

        public Task<LoginModel> GetLoginDataAsync(string username)
        {
            return _database.Table<LoginModel>().Where(i => i.UserName ==username).FirstOrDefaultAsync();
        }
        public Task SaveLoginDataAsync(LoginModel logdata) 
        {
            return _database.InsertAsync(logdata);        
        }
    }
}
