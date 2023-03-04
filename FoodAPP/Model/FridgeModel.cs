using FoodAPP.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP
{
    public class FridgeModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ID_ofuser { get => SigninViewModel.user_id; }
        public int ID_ofproduct { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }

    }
}
