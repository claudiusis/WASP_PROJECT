using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP.Model
{
    public class ProductSubType
    {
        [PrimaryKey, AutoIncrement] 
        public int ID { get; set; }
        public int TypeID { get; set; }
        public string Title { get; set; }
    }
}
