namespace Land
{
    using Xamarin.Forms;
    using Land.Views;

    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            LoginPage loginPage = new LoginPage();
            NavigationPage navigationPage = new NavigationPage(loginPage);
            MainPage = navigationPage;
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
