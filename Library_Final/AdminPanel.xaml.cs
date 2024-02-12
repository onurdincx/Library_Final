using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Final
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_ListMember_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_ListMembers ListMembers_Admin = new AdminPanel_ListMembers();
            ListMembers_Admin.ShowDialog();
        }

        private void btn_AddMember_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_AddMember AddMember_Admin = new AdminPanel_AddMember();
            AddMember_Admin.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Close_AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_AddBook_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_AddBook AddBook_Admin = new AdminPanel_AddBook();
            AddBook_Admin.ShowDialog();
        }

        private void btn_ListBook_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_ListBook ListBook_Admin = new AdminPanel_ListBook();
            ListBook_Admin.ShowDialog();
        }

        private void btn_GiveBook_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_GiveDepositBook GiveDepositBook_Admin = new AdminPanel_GiveDepositBook();
            GiveDepositBook_Admin.ShowDialog();
        }

        private void btn_ListDepositBooks_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_ListDepositBooks ListDepositBooks_Admin = new AdminPanel_ListDepositBooks();
            ListDepositBooks_Admin.ShowDialog();
        }

        private void btn_ReturnDepositBook_AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel_ReturnDepositBook ReturnDepositBook_Admin = new AdminPanel_ReturnDepositBook();
            ReturnDepositBook_Admin.ShowDialog();
        }
    }
}
