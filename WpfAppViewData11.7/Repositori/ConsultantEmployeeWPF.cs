using ConsoleAppViewData10._8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppViewData11._7.Repositori
{
    internal class ConsultantEmployeeWPF : ConsultantEmployee
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

        
    }
}
