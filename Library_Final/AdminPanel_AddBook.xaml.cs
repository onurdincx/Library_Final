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

namespace Library_Final
{
    /// <summary>
    /// Interaction logic for AdminPanel_AddBook.xaml
    /// </summary>
    public partial class AdminPanel_AddBook : Window
    {
        public AdminPanel_AddBook()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");

        private void btn_CancelBook_Admin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_AddBook_Admin_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open(); //kodları Akay Yazılım youtube hesabından bakarak yazdım. kopyala yapıştır yapmadım
            SqlCommand komut = new SqlCommand("insert into Book(BookName,BookPage,BookCategory,BookAuthor,BookYear,BookStock,BookDate) values(@BookName,@BookPage,@BookCategory,@BookAuthor,@BookYear,@BookStock,@BookDate)", baglanti);
            komut.Parameters.AddWithValue("@BookName", txt_BookName_Admin.Text);
            komut.Parameters.AddWithValue("@BookPage", txt_BookPage_Admin.Text);
            komut.Parameters.AddWithValue("@BookCategory", combobox_BookCategory_Admin.Text);
            komut.Parameters.AddWithValue("@BookAuthor", txt_BookAuthor_Admin.Text);
            komut.Parameters.AddWithValue("@BookYear", txt_BookYear_Admin.Text);
            komut.Parameters.AddWithValue("@BookStock", txt_BookStock_Admin.Text);
            komut.Parameters.AddWithValue("@BookDate", DateTime.Now.ToShortDateString()); //KAYIT TARIHI

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registration Successful.");

        }
    }
}
