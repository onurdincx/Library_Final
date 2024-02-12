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
using System.Data.SqlClient;
using System.Data;

namespace Library_Final
{
    /// <summary>
    /// Interaction logic for TeacherStudent.xaml
    /// </summary>
    public partial class TeacherStudent : Window
    {
        public TeacherStudent()
        {
            InitializeComponent();
            ListBookNow();
            ListDepositBookNow();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");


        DataSet daset = new DataSet();

        private void ListBookNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Book", baglanti);
            adtr.Fill(daset, "Book");
            DataGridViewListBooks.ItemsSource = daset.Tables["Book"].DefaultView; //toros discordunda aldım kodu
            baglanti.Close();
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["Book"].Clear(); // 5 kitap: armut, a 10, r 15
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Book where BookName like '%" + txt_SearchBookName_Member.Text + "%'", baglanti); //youtubeden bakarak yazdım. 
            adtr.Fill(daset, "Book");
            DataGridViewListBooks.ItemsSource = daset.Tables["Book"].DefaultView;
            baglanti.Close();
        }

        private void ListDepositBookNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks", baglanti);
            adtr.Fill(daset, "DepositBooks");
            DataGridView_ListDepositBooks.ItemsSource = daset.Tables["DepositBooks"].DefaultView; //kayitlari datagride yukluyoz
            baglanti.Close();
        }

        private void txt_SearchMyBooks_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["DepositBooks"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from DepositBooks where SchoolNumber like '%" + txt_SearchMyBooks.Text + "%'", baglanti); 
            adtr.Fill(daset, "DepositBooks");
            DataGridView_ListDepositBooks.ItemsSource = daset.Tables["DepositBooks"].DefaultView; 
            baglanti.Close();
        }

        private void btn_LogOUT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            txt_SearchBookName_Member.Clear();
        }

        private void btn_LogOUT_2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            txt_SearchBookName_Member.Clear();
        }
    }
}
