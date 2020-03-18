using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Land.ViewsModels
{
    public class LoginViewModel : BaseViewModel
    {

        #region Attibutes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Propiedades
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }

        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion
        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnabled = true;

        }
        #endregion

        #region Comandos
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }

        }


        private async void Login()
        {
            if (String.IsNullOrEmpty(this.Email))
            {


                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert
                    (
                    "Error",
                    "You must enter an Email",
                    "Accept");
                return;


            }
                        
            if (String.IsNullOrEmpty(this.Password))
            {


                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert
                    (
                    "Error",
                    "You must enter an Password",
                    "Accept");
                return;


            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "lole0310@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect",
                    "Accept");

                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert
                ("Ok", 
                "Fuck Yeahhhhh",
                "Accept");


        }
        #endregion
    }
}
