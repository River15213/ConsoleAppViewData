using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8
{
    internal class ClientData
    {
        private static int idcouter = 0;
        public int Id { get; private set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public int PassportID { get; set; }


        public ClientData(string surname, string name, string patronymic, string phoneNumber, int passportID)
        {
            Id = ++idcouter;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportID = passportID;
        }

        public override string ToString()
        {
            return $"{Id} Фамилия: {Surname} Имя: {Name} Отчество: {Patronymic} Номер телефона: {PhoneNumber} Паспортные данные: {PassportID}";
        }
    }
}
