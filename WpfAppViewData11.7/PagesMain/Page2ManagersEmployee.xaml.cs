using ConsoleAppViewData10._8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppViewData11._7.PagesMain.EditDataWindow;
using WpfAppViewData11._7.Services;

namespace WpfAppViewData11._7.PagesMain
{
    /// <summary>
    /// Логика взаимодействия для Page2ManagersEmployee.xaml
    /// </summary>
    public partial class Page2ManagersEmployee : Page
    {
        RecordingAndReadFile recordingAndReadFile = new RecordingAndReadFile();
        ManagersEmployeeWPF managersEmployeeWPF = new ManagersEmployeeWPF();
        private List<ClientData> data;


        public Page2ManagersEmployee()
        {
            InitializeComponent();
            recordingAndReadFile.WreateFile();
            data = recordingAndReadFile.ReadFile();
            dataGridManagers.ItemsSource = data;
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            var selectedManagers = dataGridManagers.SelectedItem as ClientData;

            if (selectedManagers != null)
            {
                var IdEmployee = selectedManagers.Id;
                EditPhoneNumber editPhoneNumber = new EditPhoneNumber();
                if (editPhoneNumber.ShowDialog() == true)
                {
                    managersEmployeeWPF.ChangePhoneNumber(data, IdEmployee, editPhoneNumber.newPhoneNumber, "Менеджер");
                    recordingAndReadFile.UpdateFileClient(data);
                    dataGridManagers.Items.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для изменение данных.");
            }
        }

        private void ChangePassportID_Click(object sender, RoutedEventArgs e)
        {
            var selectedManagers = dataGridManagers.SelectedItem as ClientData;

            if (selectedManagers != null)
            {
                var IdEmployee = selectedManagers.Id;
                EditPassportID editPassportId = new EditPassportID();
                if (editPassportId.ShowDialog() == true)
                {
                    managersEmployeeWPF.ChangePassportId(data, IdEmployee, editPassportId.newPassportId);
                    recordingAndReadFile.UpdateFileClient(data);
                    dataGridManagers.Items.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для изменение данных.");
            }
        }

        private void ChangeFullName_Click(object sender, RoutedEventArgs e)
        {
            var selectedManagers = dataGridManagers.SelectedItem as ClientData;

            if (selectedManagers != null)
            {
                var IdEmployee = selectedManagers.Id;
                EditFullName editFullName = new EditFullName();
                if (editFullName.ShowDialog() == true)
                {
                    managersEmployeeWPF.ChangeFullName(data, IdEmployee, editFullName.newSurname, editFullName.newName, editFullName.newPatronymic);
                    recordingAndReadFile.UpdateFileClient(data);
                    dataGridManagers.Items.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для изменение данных.");
            }
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            EditFullName editFullName = new EditFullName();
            EditPhoneNumber editPhoneNumber = new EditPhoneNumber();
            EditPassportID editPassportID = new EditPassportID();

            if(editFullName.ShowDialog() == true)
            {
                if(editPhoneNumber.ShowDialog() == true)
                {
                    if (editPassportID.ShowDialog() == true)
                    {
                        managersEmployeeWPF.AddClient(
                            data,
                            editFullName.newSurname,
                            editFullName.newName,
                            editFullName.newPatronymic,
                            editPhoneNumber.newPhoneNumber,
                            editPassportID.newPassportId);

                        recordingAndReadFile.UpdateFileClient(data);
                        dataGridManagers.Items.Refresh();
                    }
                }
            }

        }
    }
}
