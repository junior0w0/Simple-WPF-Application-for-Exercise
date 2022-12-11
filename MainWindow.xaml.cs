using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Laprak_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] place { get; set; }
        public class User
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string birthday { get; set; }
            public string city { get; set; }
        }


        public MainWindow()
        {
            InitializeComponent();

            place = new string[] { "Yogyakarta", "Klaten", "Semarang", "Boyolali", "Jakarta", "Surabaya", "Solo", "Malang", "Magelang" };

            DataContext = this;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            User dataUser = new User();
            dataUser.firstName = firstNameBox.Text;
            dataUser.lastName = lastNameBox.Text;
            dataUser.birthday = birthdayBox.Text;
            dataUser.city = cityBox.Text;
            
            dataGrid.Items.Add(dataUser);
        }


        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            firstNameBox.Clear();
            lastNameBox.Clear();    
        }

        private void birthdayBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = dataGrid.SelectedItem as User;
            if (user != null)
            {
                dataGrid.Items.Remove(user);
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = dataGrid.SelectedItem as User;
            if (user != null)
            {
                user.firstName = firstNameBox.Text;
                user.firstName = firstNameBox.Text;
                user.lastName = lastNameBox.Text;
                user.birthday = birthdayBox.Text;
                user.city = cityBox.Text;

                dataGrid.Items.Refresh();
            }
        }
    }
}
//<TextBox x:Name="birthdayBox" HorizontalAlignment="Left" Height="25" Margin="117,103,0,0" TextWrapping="Wrap" Text="Select a date" VerticalAlignment="Top" Width="310" TextChanged="birthdayBox_TextChanged"/>