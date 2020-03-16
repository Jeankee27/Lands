namespace Land.Insfrastructure
{
    using ViewsModels;
    class InstanceLocater
    {

        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructor

        public InstanceLocater()
        {
            this.Main = new MainViewModel();
        }

        #endregion
    }
}
