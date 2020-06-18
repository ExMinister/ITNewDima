using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelsTable
{
    //ToDo:Валидация для E-mail и подобного?
    public class UserDepartament
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Код Сотрудника")]
        public int CodeUser { get; set; }

        [DisplayName("Номер отдела")]
        public int DepartamentId { get; set; }

        [DisplayName ("Имя"), Required]
        public string FirstName { get; set; }

        [DisplayName("Фамилия"), Required]
        public string FamilyName { get; set; }

        [DisplayName("Отчество")]
        public string SecondName { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime BornUser { get; set; }
        
        [DisplayName("Номер телефона")]
        public string NumerTelefone { get; set; }

        [DisplayName("E-mail")]
        public string EmailUser { get; set; }

        [DisplayName("Факс")]
        public string FaksUser { get; set; }

        [DisplayName("Адресс")]
        public string AdressUser { get; set; }

        [DisplayName("Код компьютера")]
        public string CodeCompUser { get; set; }


        [DisplayName("Инвентарный номер")]
        public string InventareNumUser { get; set; }

        [DisplayName("IP адрес")]
        public string IPAdressUser { get; set; }
    }
}