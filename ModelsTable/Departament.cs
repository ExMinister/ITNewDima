using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelsTable
{
    public class Departament
    {
        [DisplayName("Порядковый номер отдела")]
        public int Id { get; set; } //ID

        [Required, DisplayName("Отдел")]
        public string NameDepartament { get; set; } //Название отдела
        
        [Required, DisplayName("Сотрудник")]
        public IEnumerable<UserDepartament> User { get; set; } //ФИО Сотрудника (Валидацию данных проводить в другом месте)

    }
}
