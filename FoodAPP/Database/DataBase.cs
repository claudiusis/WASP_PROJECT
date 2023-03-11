using FoodAPP.Model;
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
            _database.CreateTableAsync<FridgeModel>().Wait();
            _database.CreateTableAsync<Product>().Wait();
            _database.CreateTableAsync<ProductType>().Wait();
            _database.CreateTableAsync<ProductSubType>().Wait();
        }
        //Tasks for Users Pages
        public Task<SignupModel> GetLoginDataAsync(string email)
        {
            var id = _database.Table<SignupModel>().Where(i => i.Email == email).FirstOrDefaultAsync();
            return id;
        }

        public Task<int> SaveLoginDataAsync(SignupModel loginData)
        {
            return _database.InsertAsync(loginData);
        }
        //Tasks for Fridge Table
        public async Task<List<FridgeModel>> GetFoodNote(int idofuser)
        {
            return await _database.Table<FridgeModel>().Where(i=> i.ID_ofuser==idofuser).ToListAsync();
        }
        public  Task<FridgeModel> GetFoodNoteOne(int id)
        {
            return _database.Table<FridgeModel>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(FridgeModel item)
        {
            if (item.ID != 0)
                return  _database.UpdateAsync(item);
            else
                return _database.InsertAsync(item);
        }

        public Task<int> DeleteItemAsync(FridgeModel item)
        {
            return _database.DeleteAsync(item);
        }

        public Task<int> SaveProductType(ProductType productType)
        {
            return _database.InsertAsync(productType);
        }
        public async Task<List<ProductType>> GetProdType()
        {
            return await _database.Table<ProductType>().ToListAsync();
        }
        public Task<List<ProductSubType>> GetProdSybType(int id)
        {
            return _database.Table<ProductSubType>().Where(i => i.TypeID == id).ToListAsync();
        }

        public Task<int> SaveProdSubtype(ProductSubType subtype)
        {
            return _database.InsertAsync(subtype);
        }
    }
}
