using FoodAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP.ViewModel
{
    public class ProductSubTypeViewModel
    {
        static ObservableCollection<ProductSubType> Sybtypes { get; }

        ProductSubTypeViewModel()
        {
            Sybtypes.Add(new ProductSubType() { Title = "Виноград" });
            Sybtypes.Add(new ProductSubType() { Title = "Яблоки" });
            Sybtypes.Add(new ProductSubType() { Title = "Бананы" });
            Sybtypes.Add(new ProductSubType() { Title = "Апельсины" });
            Sybtypes.Add(new ProductSubType() { Title = "Форель" });
            Sybtypes.Add(new ProductSubType() { Title = "Сельдь" });
            Sybtypes.Add(new ProductSubType() { Title = "Сёмга" });
            Sybtypes.Add(new ProductSubType() { Title = "Тунец" });
            Sybtypes.Add(new ProductSubType() { Title = "Курица" });
            Sybtypes.Add(new ProductSubType() { Title = "Индейка" });
            Sybtypes.Add(new ProductSubType() { Title = "Утка" });
            Sybtypes.Add(new ProductSubType() { Title = "Гусь" });
            Sybtypes.Add(new ProductSubType() { Title = "Свинина" });
            Sybtypes.Add(new ProductSubType() { Title = "Говядина" });
            Sybtypes.Add(new ProductSubType() { Title = "Баранина" });
            Sybtypes.Add(new ProductSubType() { Title = "Крольчатина" });
            Sybtypes.Add(new ProductSubType() { Title = "Молоко" });
            Sybtypes.Add(new ProductSubType() { Title = "Сметана" });
            Sybtypes.Add(new ProductSubType() { Title = "Йогурт" });
            Sybtypes.Add(new ProductSubType() { Title = "Сыр" });
            Sybtypes.Add(new ProductSubType() { Title = "Рыбные" });
            Sybtypes.Add(new ProductSubType() { Title = "Овощные" });
            Sybtypes.Add(new ProductSubType() { Title = "Мясные" });
            Sybtypes.Add(new ProductSubType() { Title = "Фруктовые" });
            Sybtypes.Add(new ProductSubType() { Title = "Майонез" });
            Sybtypes.Add(new ProductSubType() { Title = "Кетчуп" });
            Sybtypes.Add(new ProductSubType() { Title = "Сырные" });
            Sybtypes.Add(new ProductSubType() { Title = "Чесночные" });
            Sybtypes.Add(new ProductSubType() { Title = "Готовые замороженные блюда" });
            Sybtypes.Add(new ProductSubType() { Title = "Пельмени" });
            Sybtypes.Add(new ProductSubType() { Title = "Тесто" });
            Sybtypes.Add(new ProductSubType() { Title = "Мясо" });
        }

        private void SaveSubtype()
        {
            int i = 1, j=0;
            foreach (var subType in Sybtypes)
            {
                subType.TypeID = i;
                App.Database.SaveProdSubtype(subType);
                j++;
                if (j == 4) i++;
            }
        }
    }
}
