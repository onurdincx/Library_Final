using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AdminPanel_ReturnDepositBook.xaml
    /// </summary>
    public partial class AdminPanel_ReturnDepositBook : Window
    {
        public AdminPanel_ReturnDepositBook()
        {
            InitializeComponent();
            ListDepositBookNow();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");

        DataSet daset = new DataSet();


        private void ListDepositBookNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks", baglanti);
            adtr.Fill(daset, "DepositBooks");
            DataGridViewReturnDepositBook.ItemsSource = daset.Tables["DepositBooks"].DefaultView; //kayitlari datagride yukluyoz
            baglanti.Close();
        }


        private void btn_Cancel_Admin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_SearchSchoolNumber_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["DepositBooks"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks where SchoolNumber like '%" + txt_SearchSchoolNumber_Admin.Text + "%' ", baglanti); //kelimenin icinde olunca aramasi icin yuzde isareti
            adtr.Fill(daset, "DepositBooks"); 
            baglanti.Close();

            if (txt_SearchSchoolNumber_Admin.Text == "")
            {
                daset.Tables["DepositBooks"].Clear();
                ListDepositBookNow();
            }

        }

        private void txt_SearchBookName_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["DepositBooks"].Clear(); //her harften sonra listeye ekleme yapmamasi icin 
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks where BookPage like '%" + txt_SearchBookName_Admin.Text + "%' ", baglanti); //kelimenin icinde olunca aramasi icin yuzde isareti
            adtr.Fill(daset, "DepositBooks");
            baglanti.Close();

            if (txt_SearchBookName_Admin.Text == "")
            {
                daset.Tables["DepositBooks"].Clear();
                ListDepositBookNow();
            }
        }

        private void btn_ReturnDeposit_Admin_Click(object sender, RoutedEventArgs e)
        {

            var dataGrid = (IEditableCollectionView)DataGridViewReturnDepositBook.Items;
            dataGrid.NewItemPlaceholderPosition = NewItemPlaceholderPosition.None;

            foreach (var aaa in DataGridViewReturnDepositBook.Items)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from DepositBooks where SchoolNumber=@SchoolNumber and BookName=@BookName", baglanti);
                var item = (DataRowView)aaa;
                komut.Parameters.AddWithValue("@SchoolNumber", !string.IsNullOrEmpty(item.Row.ItemArray[0].ToString()) ? item.Row.ItemArray[0] : "Boş");
                komut.Parameters.AddWithValue("@BookName", !string.IsNullOrEmpty(item.Row.ItemArray[0].ToString()) ? item.Row.ItemArray[5] : "Boş");

                SqlCommand komut2 = new SqlCommand("update Book set BookStock=BookStock+ '" + item.Row.ItemArray[10] + "' where BookName=@BookName", baglanti); //stogu arttirma
                komut2.Parameters.AddWithValue("@BookName", !string.IsNullOrEmpty(item.Row.ItemArray[0].ToString()) ? item.Row.ItemArray[5] : "Boş");

                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("DONE RETURN DEPOSIT BOOK REQUEST!");
            }
                daset.Tables["DepositBooks"].Clear();

                ListDepositBookNow();

            }
        }

    }
