using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8.Interface
{
    internal interface IChangingDataConsultant
    {
        ClientData ChangePhoneNumber(List<ClientData> list, int idClients, string phoneNumber, string who);
    }
}
