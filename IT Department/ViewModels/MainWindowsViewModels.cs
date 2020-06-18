using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using IT_Department.Data.MainWindow;
using ModelsTable;

namespace IT_Department.ViewModels
{
    public class MainWindowsViewModels : BaseViewModels
    {
        private IEnumerable<TreeViewItem> _thTreeViewItems = new List<TreeViewItem>();
        private LogicalView logical;
        private MainWindow mainWindow;
        private DataGrid dataGrid;
        private IEnumerable<Departament> _departament = new List<Departament>();
        private IEnumerable<UserDepartament> _userDepartaments = new List<UserDepartament>();

        public MainWindowsViewModels()
        {
            
            mainWindow = Application.Current.MainWindow as MainWindow ?? throw new System.NullReferenceException("Не удалось получить экземпляр главного окна");
            mainWindow.Loaded += MainWindow_Loaded;

            logical = new LogicalView(this);
            logical.UpdateDepartament();
            logical.UpdateTreeView();

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.dataGrid = mainWindow.DataGridMainView;
            logical.UpdateDataGridColumns(this.dataGrid);
        }

        public IEnumerable<TreeViewItem> ThTreeViewItems
        {
            get => _thTreeViewItems;
            set { _thTreeViewItems = value;OnPropertyChanged(nameof(ThTreeViewItems)); }
        }



        public Visibility IsVisibleTabItemUser { get; set; } = Visibility.Visible;


        //Работа с моделями
        public IEnumerable<Departament> Departament
        {
            get => _departament;
            set { _departament = value;OnPropertyChanged(nameof(Departament)); }
        }

        public IEnumerable<UserDepartament> UserDepartaments
        {
            get => _userDepartaments;
            set { _userDepartaments = value; OnPropertyChanged(nameof(UserDepartaments)); }
        }
    }
}