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

namespace Library_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            Login LoginScreen = new Login();
            LoginScreen.ShowDialog(); //cant click mainwindow while open Login screen
        }

        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            Register RegisterScreen = new Register();
            RegisterScreen.ShowDialog(); //cant click mainwindow while open Register screen
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin AdminLoginLogin = new AdminLogin();
            AdminLoginLogin.ShowDialog();
        }
    }
}
