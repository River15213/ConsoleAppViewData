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
using System.Windows.Shapes;

namespace WpfAppViewData11._7
{
    /// <summary>
    /// Логика взаимодействия для EditPhoneNumber.xaml
    /// </summary>
    public partial class EditPhoneNumber : Window
    {
        public string newPhoneNumber {  get; set; }
        public EditPhoneNumber()
        {
            InitializeComponent();

        }

        private void SaveNumber_Click(object sender, RoutedEventArgs e)
        {
            var inputEmployee = newPhoneNumbersTextBox.Text;
            if (!string.IsNullOrWhiteSpace(inputEmployee))
            {
                newPhoneNumber = inputEmployee;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите номер телефона.");
            }

        }
    }
}
