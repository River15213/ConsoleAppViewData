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
using WpfAppViewData11._7.Repositori;

namespace WpfAppViewData11._7
{
    /// <summary>
    /// Логика взаимодействия для Page1ConsultantEmployee.xaml
    /// </summary>
    public partial class Page1ConsultantEmployee : Page
    {
        RecordingAndReadFile recordingAndReadFile = new RecordingAndReadFile();
        ConsultantEmployeeWPF consultantEmployeeWPF = new ConsultantEmployeeWPF();
        private List<ClientData> data;

        public Page1ConsultantEmployee()
        {
            
            InitializeComponent();
            recordingAndReadFile.WreateFile();
            data = recordingAndReadFile.ReadFile();

            foreach (var item in data)
            {
                item.PassportID = -1;
            }
            dataGridConsultant.ItemsSource = data;
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = dataGridConsultant.SelectedItem as ClientData;
            if (selectedEmployee != null)
            {
                var IdEmployee = selectedEmployee.Id;
                EditPhoneNumber editPhoneNumber = new EditPhoneNumber();
                if (editPhoneNumber.ShowDialog() == true)
                {
                    consultantEmployeeWPF.ChangePhoneNumber(data, IdEmployee, editPhoneNumber.newPhoneNumber, "Консультант");
                    recordingAndReadFile.UpdateFileClient(data);
                    dataGridConsultant.Items.Refresh();
                    
                }   

            }
            else
            {
                MessageBox.Show("Выберите клиента для изменение данных.");
            }
        }
    }
}
