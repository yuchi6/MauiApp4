namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit() { Name="Apple", Image="apple.png", Description="This is an apple" },
                new Fruit() { Name="Orange", Image="orange.png", Description="This is an orange" },
                new Fruit() { Name="Banana", Image="banana.png", Description="This is a banana" },
                new Fruit() { Name="Kiwi", Image="kiwi.png", Description="This is a kiwi" },
                new Fruit() { Name="Starawberry", Image="starawberry.png", Description="This is a starawberry" },
                new Fruit() { Name="Pineapple", Image="pineapple.png", Description="This is a pineapple" },
                new Fruit() { Name="Watermalon", Image="watermalon.png", Description="This is a watermalon" },
                new Fruit() { Name="Grapes", Image="grape.png", Description="This is a grapes" },
            };
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }
        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)

        {
            if (e.SelectedItem == null)
                return;
            var selectItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectItem.Name, selectItem.Image, selectItem.Description));
        }
    }
}