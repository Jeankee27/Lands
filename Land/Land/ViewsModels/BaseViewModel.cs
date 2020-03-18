using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Land.ViewsModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnProtertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            
            }
            backingField = value;
            OnProtertyChange(propertyName);
          
        }

    }
}
