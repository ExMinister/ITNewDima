using System;
using System.Windows.Input;
using IT_Department.View;

namespace IT_Department.Data.MainWindow
{
    public class CommandOpenOrgtexnical : ICommand
    {
        private OrgTexnical org;

        public bool CanExecute(object parameter)
        {
            if(org == default)
                org = new OrgTexnical();
            return org.IsInitialized;
        }

        public void Execute(object parameter)
        {
            if (org == default)
                org = new OrgTexnical();
            org.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}