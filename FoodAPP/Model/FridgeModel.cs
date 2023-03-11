using FoodAPP.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP
{
    public class FridgeModel
    {
        [PrimaryKey, AutoIncrement] public int ID { get; set; }
        [ForeignKey("FridgeModel")] public int ID_ofuser { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; } 

    }
}
