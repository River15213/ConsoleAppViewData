using ConsoleAppViewData10._8.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppViewData10._8
{
    public class ConsultantEmployee : IViewData, IChangingDataConsultant, IChangeControl
    {
        public virtual ClientData ChangePhoneNumber(List<ClientData> list, int idClients, string phoneNumber)
        {
            var clients = list.Find(x => x.Id == idClients);
            if (clients == null)
            {
                Console.WriteLine($"Такого клиента нет");
                return null;
            }
            clients.PhoneNumber = phoneNumber;
            
            InfoControlChange("Телефон", "Update", "Консультант");
            Console.WriteLine($"Номер телефона у клиента {idClients} обновлен.");
            return clients;
        }


        public virtual void OutputData(List<ClientData> list)
        {
            foreach (ClientData item in list)
            {
                Console.WriteLine($"{item.Id} Фамилия: {item.Surname} Имя: {item.Name} Отчество: {item.Patronymic} Номер телефона: {item.PhoneNumber} Паспортные данные: ***********");
            }
        }

        public virtual ChangeControlClientBD InfoControlChange(string dataChange, string typeChange, string whoChange)
        {
            var change = new ChangeControlClientBD(dataChange, typeChange, whoChange);
            Console.WriteLine(change.ToString());
            return change;
        }

    }

    
}
