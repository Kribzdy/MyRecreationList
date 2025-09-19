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

namespace MyRecreationList.WPF
{
    /// <summary>
    /// Логика взаимодействия для LoginControl.xaml
    /// </summary>
    public partial class LoginControl : Page
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (StrLogin != null && StrPassword != null)
            {
                if (StrLogin.Text == "admin" && StrPassword.Password == "admin")
                {
                    MessageBox.Show("Вы успешно вошли в систему!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    //this.Hide();
                    //AdminWindow adminWindow = new AdminWindow();
                    // adminWindow.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
