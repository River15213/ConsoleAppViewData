using ConsoleAppViewData10._8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppViewData11._7.Services
{
    internal class ManagersEmployeeWPF : ManagersEmployee
    {
        public override ClientData ChangePhoneNumber(List<ClientData> list, int idClients, string phoneNumber, string who)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                MessageBox.Show("Такого клиента нет");
                return null;
            }
            clients.PhoneNumber = phoneNumber;

            MessageBox.Show($"Номер телефона у клиента {idClients} обновлен.");
            return clients;
        }

        public override ClientData ChangeFullName(List<ClientData> list, int idClients, string surname, string name, string patronymic)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                MessageBox.Show("Такого клиента нет");
                return null;
            }
            clients.Surname = surname;
            clients.Name = name;
            clients.Patronymic = patronymic;

            MessageBox.Show($"ФИО у клиента {idClients} обновлена.");
            return clients;
        }

        public override ClientData ChangePassportId(List<ClientData> list, int idClients, int passportId)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                MessageBox.Show("Такого клиента нет");
                return null;
            }
            clients.PassportID = passportId;
            MessageBox.Show($"Паспортные данные у клиента {idClients} обновлены.");
            return clients;
        }

        internal ClientData AddClient(List<ClientData> list, string surname, string name, string patronymic, string phoneNumber, int passportId)
        {
            var newClient = new ClientData(surname, name, patronymic, phoneNumber, passportId);
            list.Add(newClient);
            MessageBox.Show($"Клиент добавлен.");
            return newClient;
        }
    }
}
