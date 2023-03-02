using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP.Model
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Subtype { get; set; }
    }
}
