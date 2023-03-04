﻿using FoodAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP.ViewModel
{
    class ProductTypes
    {
        public static ObservableCollection<ProductType> Types { get; set; }

        ProductTypes()
        {
            Types.Add(new ProductType() { Title = "Рыба" });
            Types.Add(new ProductType() { Title = "Птица" });
            Types.Add(new ProductType() { Title = "Мясо" });
            Types.Add(new ProductType() { Title = "Молочная продукция" });
            Types.Add(new ProductType() { Title = "Фрукты" });
            Types.Add(new ProductType() { Title = "Овощи" });
            Types.Add(new ProductType() { Title = "Консервы" });
            Types.Add(new ProductType() { Title = "Соусы" });
            Types.Add(new ProductType() { Title = "Замороженные продукты" });
        }

        private void AddingDataTypes()
        {
            foreach (var type in Types)
            {
                App.Database.SaveProductType(type);
            }
        }
    }
}
