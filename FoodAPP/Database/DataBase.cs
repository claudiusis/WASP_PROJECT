using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodAPP;
using SQLite;

namespace FoodAPP
{
    public class DataBase
    {
        public readonly SQLiteAsyncConnection _database;

        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SignupModel>().Wait();
        }

        public Task<SignupModel> GetLoginDataAsync(string email)
        {
            return _database.Table<SignupModel>().Where(i => i.Email == email).FirstOrDefaultAsync();
        }

        public Task<int> SaveLoginDataAsync(SignupModel loginData)
        {
            return _database.InsertAsync(loginData);
        }
        public Task<int> DeleteUser(SignupModel signupdata)
        {
            return _database.DeleteAsync(signupdata);
        }
    }
}
