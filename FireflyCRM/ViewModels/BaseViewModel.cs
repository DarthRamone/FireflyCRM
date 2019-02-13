using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FireflyCRM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {   
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetValue(ref _isBusy, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public bool IsModified { get; private set; }
        
        protected BaseViewModel ()
        {
        }

        protected void SetValue<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (SetProperty(ref storage, value, propertyName))
                IsModified = true;
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        }
    }
}
