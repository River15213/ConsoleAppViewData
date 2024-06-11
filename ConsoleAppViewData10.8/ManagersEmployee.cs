using ConsoleAppViewData10._8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppViewData10._8
{
    internal class ManagersEmployee : ConsultantEmployee, IViewData, IChangingDataManagers, IChangeControl
    {
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

    }
}
