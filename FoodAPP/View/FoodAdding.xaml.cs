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
        if ((string)Picker1.SelectedItem == "����")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("������");
            Picker2.Items.Add("������");
            Picker2.Items.Add("������");
            Picker2.Items.Add("������");
        }
        else if ((string)Picker1.SelectedItem == "����")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("�������");
            Picker2.Items.Add("��������");
            Picker2.Items.Add("��������");
            Picker2.Items.Add("��������");
        }
        else if ((string)Picker1.SelectedItem == "�����")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("������");
            Picker2.Items.Add("�������");
            Picker2.Items.Add("����");
            Picker2.Items.Add("����");
        }
        else if ((string)Picker1.SelectedItem == "������")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("������");
            Picker2.Items.Add("������");
            Picker2.Items.Add("���������");
            Picker2.Items.Add("�����");
        }
        else if ((string)Picker1.SelectedItem == "�����")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("������");
            Picker2.Items.Add("��������");
            Picker2.Items.Add("�������");
            Picker2.Items.Add("���");
        }

        else if ((string)Picker1.SelectedItem == "�������� ��������")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("����");
            Picker2.Items.Add("������");
            Picker2.Items.Add("�������");
            Picker2.Items.Add("�������");
        }
        else if ((string)Picker1.SelectedItem == "��������")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("�������");
            Picker2.Items.Add("���������");
            Picker2.Items.Add("������");
            Picker2.Items.Add("������");
        }
        else if ((string)Picker1.SelectedItem == "�����")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("�������");
            Picker2.Items.Add("������");
            Picker2.Items.Add("���������");
            Picker2.Items.Add("������");
        }
        else if ((string)Picker1.SelectedItem == "������������ ��������")
        {
            Picker2.Items.Clear();
            Picker2.Items.Add("��������");
            Picker2.Items.Add("�����");
            Picker2.Items.Add("������� ������������ �����");
            Picker2.Items.Add("����, ����");
        }
        Picker2.Items.Add("������");
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