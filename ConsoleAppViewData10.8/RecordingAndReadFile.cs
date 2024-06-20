using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViewData10._8
{
    public class RecordingAndReadFile
    {
        static private ClientData ClientOne = new ClientData("Иванов", "Иван", "Иванович", "+7(918)345-12-23", 232345544);
        static private ClientData ClientTwo = new ClientData("Петров", "Петр", "Петрович", "+7(928)123-15-83", 127929881);
        static private ClientData ClientThree = new ClientData("Мумов", "Артур", "Артурович", "+7(918)666-10-03", 000144912);

        public void WreateFile()
        {
            using (StreamWriter sw = new StreamWriter("DataClients.txt"))
            {
                sw.WriteLine(ClientOne.ToString());
                sw.WriteLine(ClientTwo.ToString());
                sw.WriteLine(ClientThree.ToString());
            }
            Console.WriteLine("Запись выполнена");
        }
        public void WriteOneLine(ClientData clientData)
        {
            using(StreamWriter sw = new StreamWriter("DataClients.txt"))
            {
                sw.WriteLine(clientData.ToString());
            }
        }

        public void UpdateFileClient(List<ClientData> clients)
        {
            using (StreamWriter sw = new StreamWriter("DataClients.txt"))
            {
                foreach (var client in clients)
                {
                    sw.WriteLine(client.ToString());
                }

            }
            Console.WriteLine("Запись клиента выполнена");
        }

        public List<ClientData> ReadFile()
        {
            List<ClientData> list = new List<ClientData>();
            using(StreamReader sr = new StreamReader("DataClients.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var parsLineClient = ParseClientData(line);
                    list.Add(parsLineClient);
                }
                Console.WriteLine("Данные считаны.");
                return list;
            }
        }

        private ClientData ParseClientData(string data)
        {
            var dataClient = data.Split(new[] {" Фамилия: ", " Имя: ", " Отчество: ", " Номер телефона: ", " Паспортные данные: "}, StringSplitOptions.None);
            int.TryParse(dataClient[0], out int id);
            string surname = dataClient[1];
            string name = dataClient[2];
            string patronymic = dataClient[3];
            string phoneNamber = dataClient[4];
            int.TryParse(dataClient[5], out int passportId);

            var clientData = new ClientData(surname,  name, patronymic, phoneNamber, passportId);
            return clientData;
        }



    }
}
