using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using IT_Department.Annotations;

namespace IT_Department.ViewModels
{
    public class BaseViewModels : INotifyPropertyChanged
    {
        public string StatusMessage { get; set; } = "Привет Мир";

        #region Реализация интерфейса INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}