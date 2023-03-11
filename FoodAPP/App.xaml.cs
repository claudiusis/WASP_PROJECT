namespace FoodAPP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    static DataBase database;

    public static DataBase Database
    {
        get
        {
            if (database == null)
           {
                database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"SQ.db"));
            }
            return database;
        }
    }
}
