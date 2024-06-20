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

namespace WpfAppViewData11._7.PagesMain.EditDataWindow
{
    /// <summary>
    /// Логика взаимодействия для EditPassportID.xaml
    /// </summary>
    public partial class EditPassportID : Window
    {
        public int newPassportId {  get; set; }
        public EditPassportID()
        {
            InitializeComponent();
        }

        private void ButtonSaveDataPasportId_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(newPasportIDTextBox.Text, out int inputEmployee))
            {
                newPassportId = inputEmployee;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите правильные данные из цифр");

            }
        }
    }
}
