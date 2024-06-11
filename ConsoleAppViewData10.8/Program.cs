namespace ConsoleAppViewData10._8
{
    internal class Program
    {
        static RecordingAndReadFile recordingAndReadFile = new RecordingAndReadFile();
        static ConsultantEmployee consultantEmployee = new ConsultantEmployee();
        static ManagersEmployee managersEmployee = new ManagersEmployee();
        static List<ClientData> listClients = recordingAndReadFile.ReadFile();

        static void Main(string[] args)
        {

            recordingAndReadFile.WreateFile();
            StartProgram();
           
        }

        static void StartProgram()
        {
            Console.WriteLine($"Какая у вас должность?\n" +
                             $"1. Консультант\n" +
                             $"2. Менеджер\n");
            int.TryParse(Console.ReadLine(), out int inputEmployees);
            while (true)
            {
                switch (inputEmployees)
                {
                    case 1:
                        ConsultantActionProgram();
                        break;
                    case 2:
                        ManagersActionProgram();
                        break;
                }
            }
        }

        static void ConsultantActionProgram()
        {
            Console.WriteLine($"Выберите что хотите сделать.\n" +
                                          $"1. Посмотреть информацию о клиентах.\n" +
                                          $"2. Изменить номер телефона клиента по ID.\n");
            int.TryParse(Console.ReadLine(), out int choiceEmployees);
            switch (choiceEmployees)
            {
                case 1:
                    Console.WriteLine("Информацио о клиентах: ");
                    Console.WriteLine();
                    consultantEmployee.OutputData(listClients, "Консультант");
                    break;
                case 2:
                    Console.WriteLine($"Введите Ид клиента.");
                    int.TryParse(Console.ReadLine(), out int inputIdClient);

                    Console.WriteLine($"Введите новый номер телефона клиента.");
                    string inputNewPhoneNumberClient = Console.ReadLine();

                    if (string.IsNullOrEmpty(inputNewPhoneNumberClient))
                    {
                        Console.WriteLine("Ошибка номера телефона");
                    }
                    else
                    {
                        var clientsChande = consultantEmployee.ChangePhoneNumber(listClients, inputIdClient, inputNewPhoneNumberClient, "Консультант");
                        if (clientsChande != null)
                        {
                            recordingAndReadFile.UpdateFileClient(listClients);
                        }
                    }
                break;
            }
        }

        static void ManagersActionProgram()
        {
            Console.WriteLine($"Выберите что хотите сделать.\n" +
                                $"1. Посмотреть информацию о клиентах.\n" +
                                $"2. Изменить номер телефона клиента по ID.\n" +
                                $"3. Изменить ФИО у клиента\n" +
                                $"4. Изменить паспортные данные\n");
            int.TryParse(Console.ReadLine(), out int choiceEmployeesManagers);
            switch (choiceEmployeesManagers)
            {
                case 1:
                    Console.WriteLine("Информацио о клиентах: ");
                    Console.WriteLine();
                    managersEmployee.OutputData(listClients, "Менеджер");
                    break;
                case 2:
                    Console.WriteLine($"Введите Ид клиента.");
                    int.TryParse(Console.ReadLine(), out int inputIdClient);

                    Console.WriteLine($"Введите новый номер телефона клиента.");
                    string inputNewPhoneNumberClient = Console.ReadLine();

                    if (string.IsNullOrEmpty(inputNewPhoneNumberClient))
                    {
                        Console.WriteLine("Ошибка номера телефона");
                    }
                    else
                    {
                        var clientsChandePhone = consultantEmployee.ChangePhoneNumber(listClients, inputIdClient, inputNewPhoneNumberClient, "Менеджер");
                        if (clientsChandePhone != null)
                        {
                            recordingAndReadFile.UpdateFileClient(listClients);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine($"Введите Ид клиента.");
                    int.TryParse(Console.ReadLine(), out int inputManagerIdClient);
                    Console.WriteLine($"Введите новую фамилию");
                    string newSurnameClient = Console.ReadLine();
                    Console.WriteLine($"Введите новуе Имя");
                    string newNameClient = Console.ReadLine();
                    Console.WriteLine($"Введите новое отчество");
                    string newPatromicClient = Console.ReadLine();
                    if (string.IsNullOrEmpty(newSurnameClient) && string.IsNullOrEmpty(newNameClient) && string.IsNullOrEmpty(newPatromicClient))
                    {
                        Console.WriteLine("Ошибка данных");
                    }
                    else
                    {
                        var clientsChandeFullName = managersEmployee.ChangeFullName(listClients, inputManagerIdClient, newSurnameClient, newNameClient, newPatromicClient);
                        if (clientsChandeFullName != null)
                        {
                            recordingAndReadFile.UpdateFileClient(listClients);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine($"Введите Ид клиента.");
                    int.TryParse(Console.ReadLine(), out int inputManagerIdClientChangePassportId);

                    Console.WriteLine("Введите новые паспортные данные");
                    int.TryParse(Console.ReadLine(), out int newPassportId);
                    var clientsChandePassportId = managersEmployee.ChangePassportId(listClients, inputManagerIdClientChangePassportId, newPassportId);
                    if (clientsChandePassportId != null)
                    {
                        Console.WriteLine("Ошибка данных паспорта");
                    }
                    else
                    {
                        recordingAndReadFile.UpdateFileClient(listClients);
                    }

                break;
            }
        }
    }
}

