using FoodAPP.ViewModel;

namespace FoodAPP.View;
[QueryProperty(nameof(ProdId), nameof(ProdId))]
public partial class FoodAdding : ContentPage
{
    public string ProdId
    {
        set
        {
            Loadprod(value);
        }
    }

    public FoodAdding()
	{
		InitializeComponent();
        Date1.MaximumDate = DateTime.Now;
		BindingContext = new FridgeModel();
	}


    private async void Loadprod(string value)
    {
        try
        {
            int prodId = Convert.ToInt32(value);
            FridgeModel model = await App.Database.GetFoodNoteOne(prodId);
            BindingContext = model;
        }
        catch { }

    }

    private void Date1_DateSelected(object sender, DateChangedEventArgs e)
    {
		Date2.MinimumDate = Date1.Date;
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        Picker2.IsVisible = true;
        if ((string)Picker1.SelectedItem == "Рыба")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Форель");
            Picker2.Items.Add("Сельдь");
            Picker2.Items.Add("Форель");
            Picker2.Items.Add("Сельдь");
        }
        else if ((string)Picker1.SelectedItem == "Мясо")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Свинина");
            Picker2.Items.Add("Говядина");
            Picker2.Items.Add("Телятина");
            Picker2.Items.Add("Баранина");
        }
        else if ((string)Picker1.SelectedItem == "Птица")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Курица");
            Picker2.Items.Add("Индейка");
            Picker2.Items.Add("Гусь");
            Picker2.Items.Add("Утка");
        }
        else if ((string)Picker1.SelectedItem == "Фрукты")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Яблоки");
            Picker2.Items.Add("Бананы");
            Picker2.Items.Add("Апельсины");
            Picker2.Items.Add("Груши");
        }
        else if ((string)Picker1.SelectedItem == "Овощи")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Огурцы");
            Picker2.Items.Add("Помидоры");
            Picker2.Items.Add("Морковь");
            Picker2.Items.Add("Лук");
        }

        else if ((string)Picker1.SelectedItem == "Молочные продукты")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Сыры");
            Picker2.Items.Add("Молоко");
            Picker2.Items.Add("Йогурты");
            Picker2.Items.Add("Сметана");
        }
        else if ((string)Picker1.SelectedItem == "Консервы")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Овощные");
            Picker2.Items.Add("Фруктовые");
            Picker2.Items.Add("Мясные");
            Picker2.Items.Add("Рыбные");
        }
        else if ((string)Picker1.SelectedItem == "Соусы")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Майонез");
            Picker2.Items.Add("Кетчуп");
            Picker2.Items.Add("Чесночные");
            Picker2.Items.Add("Сырные");
        }
        else if ((string)Picker1.SelectedItem == "Замороженные продукты")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("Пельмени");
            Picker2.Items.Add("Тесто");
            Picker2.Items.Add("Готовые замороженные блюда");
            Picker2.Items.Add("Мясо, рыба");
        }
        Picker2.Items.Add("Другое");
    }
    private async void SaveClicked(object sender, EventArgs e)
    {
        FridgeModel fridge = (FridgeModel)BindingContext;
        fridge.ID_ofuser = SigninViewModel.user_id;
        await App.Database.SaveItemAsync(fridge);
        await Shell.Current.GoToAsync(nameof(Fridge));
    }
    private async void DeleteClicked(object sender, EventArgs e)
    {
        FridgeModel model = (FridgeModel)BindingContext;
        await App.Database.DeleteItemAsync(model);
        await Shell.Current.GoToAsync(nameof (Fridge));
    }
    private async void Back(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Fridge));
    }
}