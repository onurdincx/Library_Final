using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for AdminPanel_ListDepositBooks.xaml
    /// </summary>
    public partial class AdminPanel_ListDepositBooks : Window
    {
        public AdminPanel_ListDepositBooks()
        {
            InitializeComponent();
            ListDepositBookNow();
            combobox_FilterDepositBooks_Admin.SelectedIndex = 0; //comboboxun ilk nesnesi secili olsun 0 1 2 3
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");

        DataSet daset = new DataSet();


        private void ListDepositBookNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks", baglanti);
            adtr.Fill(daset, "DepositBooks");
            DataGridViewDepositBooks.ItemsSource = daset.Tables["DepositBooks"].DefaultView; //kayitlari datagride yukluyoz
            baglanti.Close();
        }

        private void combobox_FilterDepositBooks_Admin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            daset.Tables["DepositBooks"].Clear();
            if (combobox_FilterDepositBooks_Admin.SelectedIndex==0)
            {
                ListDepositBookNow();
            }
            else if(combobox_FilterDepositBooks_Admin.SelectedIndex==1) //geciken kitaplar
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks where '"+DateTime.Now.ToShortDateString()+"'>ReturnDate ", baglanti);
                  adtr.Fill(daset, "DepositBooks");
                DataGridViewDepositBooks.ItemsSource = daset.Tables["DepositBooks"].DefaultView; //kayitlari datagride yukluyoz
                baglanti.Close();
            }
            else if (combobox_FilterDepositBooks_Admin.SelectedIndex == 2) //gecikmeyen kitaplar
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks where '" + DateTime.Now.ToShortDateString() + "'<= ReturnDate ", baglanti);
                adtr.Fill(daset, "DepositBooks");
                DataGridViewDepositBooks.ItemsSource = daset.Tables["DepositBooks"].DefaultView; //kayitlari datagride yukluyoz
                baglanti.Close();
            }

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
