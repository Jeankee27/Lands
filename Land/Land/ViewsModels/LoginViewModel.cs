using System.Windows.Input;

namespace Land.ViewsModels
{    
    class LoginViewModel
    {
        #region Propiedades
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion
        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;

        }
        #endregion
        #region Comandos
        public ICommand LoginCommand 
        {
            get;
            set;
        }
        #endregion
    }
}
