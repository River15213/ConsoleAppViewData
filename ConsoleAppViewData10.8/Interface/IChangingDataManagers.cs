using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8.Interface
{
    internal interface IChangingDataManagers
    {
        ClientData ChangeFullName(List<ClientData> list, int idClients, string surname, string name, string patronymic);
        ClientData ChangePassportId(List<ClientData> list, int idClients, int passportId);
    }
}
