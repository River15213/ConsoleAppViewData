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
    /// Логика взаимодействия для EditFullName.xaml
    /// </summary>
    public partial class EditFullName : Window
    {
        public string newSurname { get; set; }
        public string newName { get; set; }
        public string newPatronymic { get; set; }
        public EditFullName()
        {
            InitializeComponent();
        }

        private void SaveFullNameButton_Click(object sender, RoutedEventArgs e)
        {
            var inputFullName = TextBoxFullName.Text;
            string[] fullname = inputFullName.Split(" ");
            if (fullname.Length == 3 )
            {
                newSurname = fullname[0];
                newName = fullname[1];
                newPatronymic = fullname[2];
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите ФИО через пробел");
            }
        }
    }
}
