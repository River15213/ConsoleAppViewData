using ConsoleAppViewData10._8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppViewData10._8
{
    internal class ManagersEmployee : IViewData, IChangingDataConsultant, IChangingDataManagers, IChangeControl
    {
        public ClientData ChangePhoneNumber(List<ClientData> list, int idClients, string phoneNumber)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                Console.WriteLine($"Такого клиента нет");
                return null;
            }
            clients.PhoneNumber = phoneNumber;
            InfoControlChange("Телефон", "Update", "Менеджер");
            Console.WriteLine($"Номер телефона у клиента {idClients} обновлен.");
            return clients;
        }

        public ClientData ChangePassportId(List<ClientData> list, int idClients, int passportId)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                Console.WriteLine($"Такого клиента нет");
                return null;
            }
            clients.PassportID = passportId;
            InfoControlChange("Паспортные данные", "Update", "Менеджер");
            Console.WriteLine($"Паспортные данные у клиента {idClients} обновлены.");
            return clients;
        }

        public ClientData ChangeFullName(List<ClientData> list, int idClients, string surname, string name, string patronymic)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                Console.WriteLine($"Такого клиента нет");
                return null;
            }
            clients.Surname = surname;
            clients.Name = name;
            clients.Patronymic = patronymic;
            InfoControlChange("ФИО", "Update", "Менеджер");
            Console.WriteLine($"ФИО у клиента {idClients} обновлена.");
            return clients;
        }

        public void OutputData(List<ClientData> list)
        {
            foreach (ClientData item in list)
            {
                Console.WriteLine($"{item.Id} Фамилия: {item.Surname} Имя: {item.Name} Отчество: {item.Patronymic} Номер телефона: {item.PhoneNumber} Паспортные данные: {item.PassportID}");
            }
        }

        public ChangeControlClientBD InfoControlChange(string dataChange, string typeChange, string whoChange)
        {
            var change = new ChangeControlClientBD(dataChange, typeChange, whoChange);
            Console.WriteLine(change.ToString());
            return change;
        }
    }
}
