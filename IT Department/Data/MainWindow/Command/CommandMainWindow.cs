using IT_Department.View;
using System;
using System.Windows.Input;

namespace IT_Department.Data.MainWindow
{
    internal class CommandMainWindow : ICommand
    {
        private CompData compData;

        public bool CanExecute(object parameter)
        {
            if (compData == default ) 
                compData = new CompData();
            return compData.IsInitialized;
        }

        public void Execute(object parameter)
        {
            if(compData == null)
                compData = new CompData();
            compData.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
