using System;
using System.Collections.Generic;
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
using System.Data;


namespace Library_Final
{
    /// <summary>
    /// Interaction logic for AdminPanel_ListBook.xaml
    /// </summary>
    public partial class AdminPanel_ListBook : Window
    {
        public AdminPanel_ListBook()
        {
            InitializeComponent();
            ListBookNow(); //kitap listelemeyi başlatır başlangıçta
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");

        DataSet daset = new DataSet();
        private void ListBookNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Book", baglanti);
            adtr.Fill(daset, "Book");
            DataGridViewBookList.ItemsSource = daset.Tables["Book"].DefaultView; //toros discordunda aldım kodu
            baglanti.Close();
        }

        private void btn_UpdateBook_Admin_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Book set BookPage=@BookPage,BookCategory=@BookCategory,BookAuthor=@BookAuthor,BookYear=@BookYear,BookStock=@BookStock where BookName=@BookName", baglanti);
            komut.Parameters.AddWithValue("@BookName", txt_BookName_Admin.Text);
            komut.Parameters.AddWithValue("@BookPage", txt_BookPage_Admin.Text);
            komut.Parameters.AddWithValue("@BookCategory", combobox_BookCategory_Admin.Text);
            komut.Parameters.AddWithValue("@BookAuthor", txt_BookAuthor_Admin.Text);
            komut.Parameters.AddWithValue("@BookYear", txt_BookYear_Admin.Text);
            komut.Parameters.AddWithValue("@BookStock", txt_BookStock_Admin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Done.");
            daset.Tables["Book"].Clear();
            ListBookNow();

        }

        private void Search_BookName_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["Book"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Book where BookName like '%" + Search_BookName_Admin.Text + "%'", baglanti); //youtubeden bakarak yazdım. 
            adtr.Fill(daset, "Book");
            DataGridViewBookList.ItemsSource = daset.Tables["Book"].DefaultView; 
            baglanti.Close();
        }

        private void btn_CloseListBook_Admin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_BookName_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Book where BookName ='" + txt_BookName_Admin.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader(); //textlerde kayıtların görülmesi için yazdım
            while (read.Read())
            {
                txt_BookPage_Admin.Text = read["BookPage"].ToString();
                combobox_BookCategory_Admin.Text = read["BookCategory"].ToString();
                txt_BookAuthor_Admin.Text = read["BookAuthor"].ToString();
                txt_BookYear_Admin.Text = read["BookYear"].ToString();
                txt_BookStock_Admin.Text = read["BookStock"].ToString();

            }
            baglanti.Close();
        }
    }
}