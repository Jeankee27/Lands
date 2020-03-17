namespace Land.ViewsModels
{
    class MainViewModel
    {
        #region ViewsModels
        public LoginViewModel login 
        {
            get;
            set;
        
        }
        #endregion

        #region Constructors
        public MainViewModel() 
        {
            this.login = new LoginViewModel();
        }
        #endregion
    }
}
