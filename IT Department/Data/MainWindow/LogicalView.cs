using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using ModelsTable;
using IT_Department.ViewModels;
using System.Reflection;
using System.Windows.Documents;

namespace IT_Department.Data.MainWindow
{
    public class LogicalView
    {
        private readonly MainWindowsViewModels mainWindowsViewModels;

        public LogicalView(MainWindowsViewModels mainWindowsViewModels)
        {
            this.mainWindowsViewModels = mainWindowsViewModels;
        }

        internal void UpdateDataGridColumns(DataGrid dataGrid)
        {
            UserDepartament departament =
                (mainWindowsViewModels.Departament.First().User.First()) as UserDepartament ??
                throw new ArgumentNullException("mainWindowsViewModels.Departament.First()");
            var property = departament.GetType().GetRuntimeProperties().ToList();
            ObservableCollection<DataGridColumn> dataGridColumns = new ObservableCollection<DataGridColumn>();
            for (int i = 0; i < property.Count; i++)
            {
                dataGridColumns = dataGrid.Columns;
                (dataGridColumns[i] as DataGridTextColumn).Header = property[i]
                    .GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            }
        }


        //ToDo: СЮДА БД
        /// <summary>
        /// Метод для обновления отделов и их сотрудников
        /// </summary>
        internal void UpdateDepartament()
        {
            List<UserDepartament> userDepartaments = new List<UserDepartament>()
            {
                new UserDepartament()
                {
                    AdressUser = "Москва", BornUser = DateTime.MinValue, CodeCompUser = "45885A",
                    DepartamentId = 0, EmailUser = "Сашок@горшок.ру", FaksUser = "4588786",
                    FamilyName = "Гопничиков", FirstName = "Алкаш", SecondName = "Наркошевич",
                    ID = 1, IPAdressUser = "458,55,77,44,4", InventareNumUser = "488fff",
                    NumerTelefone = "+7-969-021-57-53"
                },
                new UserDepartament()
                {
                    AdressUser = "Москва", BornUser = DateTime.MinValue, CodeCompUser = "45885A",
                    DepartamentId = 2, EmailUser = "Сашок@горшок.ру", FaksUser = "4588786",
                    FamilyName = "Гопничиков", FirstName = "Алкаш", SecondName = "Наркошевич",
                    ID = 1, IPAdressUser = "458,55,77,44,4", InventareNumUser = "488fff",
                    NumerTelefone = "+7-969-021-57-53"
                },
                new UserDepartament()
                {
                    AdressUser = "Москва", BornUser = DateTime.MinValue, CodeCompUser = "45885A",
                    DepartamentId = 0, EmailUser = "Сашок@горшок.ру", FaksUser = "4588786",
                    FamilyName = "Гопничиков", FirstName = "Алкаш", SecondName = "Наркошевич",
                    ID = 1, IPAdressUser = "458,55,77,44,4", InventareNumUser = "488fff",
                    NumerTelefone = "+7-969-021-57-53"
                },

            };

            
            mainWindowsViewModels.Departament = new List<Departament>()
            {
                new Departament() {Id = 0, NameDepartament = "Экономический", User = userDepartaments},
                new Departament() {Id = 0, NameDepartament = "Генеральный", User = userDepartaments},
                new Departament() {Id = 0, NameDepartament = "Бухгалтерия", User = userDepartaments}
            };

            mainWindowsViewModels.UserDepartaments = userDepartaments;
        }


        internal void UpdateTreeView()
        {
            List<TreeViewItem> treeViewItems =
                mainWindowsViewModels.ThTreeViewItems as List<TreeViewItem>;
            foreach (Departament departament in mainWindowsViewModels.Departament)
            {
                treeViewItems?.Add(new TreeViewItem() {Header = departament.NameDepartament});
            }

            mainWindowsViewModels.ThTreeViewItems = treeViewItems;
        }
    }
}