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
    /// Interaction logic for AdminPanel_GiveDepositBook.xaml
    /// </summary>
    public partial class AdminPanel_GiveDepositBook : Window
    {
        public AdminPanel_GiveDepositBook()
        {
            InitializeComponent();
            ListCartNow(); //listeleme
            NumberBooks();
            InitializeComponent();
            picker_DeliveryDate.SelectedDate = DateTime.Today; //return date yi bugüne almak
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");

        private void btn_Cancel_DepositBook_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ListCartNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Cart ", baglanti);
            adtr.Fill(daset, "Cart");
            DataGridViewDepositBook.ItemsSource = daset.Tables["Cart"].DefaultView;
            baglanti.Close();
        }


        private void NumberBooks()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(BookPiece) from Cart", baglanti);
            label_books_2.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }





        DataSet daset = new DataSet(); //silme islemi ve listeleme
        private void btn_Add_DepositBook_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Cart(BookName,BookPage,BookAuthor,BookCategory,BookYear,BookPiece,DeliveryDate,ReturnDate) values(@BookName,@BookPage,@BookAuthor,@BookCategory,@BookYear,@BookPiece,@DeliveryDate,@ReturnDate) ", baglanti); //@ degisen anlaminda kullandim
            komut.Parameters.AddWithValue("@BookName", txt_BookName.Text);
            komut.Parameters.AddWithValue("@BookPage", txt_BookPage.Text);
            komut.Parameters.AddWithValue("@BookAuthor", txt_BookAuthor.Text);
            komut.Parameters.AddWithValue("@BookCategory", combobox_BookCategory.Text);
            komut.Parameters.AddWithValue("@BookYear", txt_BookYear.Text);
            komut.Parameters.AddWithValue("@BookPiece", int.Parse(txt_BookPiece.Text)); //sayisal deger girilmesi icin int parse ekledim
            komut.Parameters.AddWithValue("@DeliveryDate", picker_DeliveryDate.Text);
            komut.Parameters.AddWithValue("@ReturnDate", picker_ReturnDate.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Books are added in cart.");
            daset.Tables["Cart"].Clear(); //silme islemi
            ListCartNow();
            label_books_2.Text = "";
            NumberBooks();

        }

        private void txt_MemberSchoolNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Member where SchoolNumber ='" + txt_MemberSchoolNumber.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txt_MemberName.Text = read["Name"].ToString();
                txt_MemberSurname.Text = read["Surname"].ToString();
                txt_MemberMail.Text = read["Mail"].ToString();
                combobox_MemberType.Text = read["MemberType"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(BookPiece) from DepositBooks", baglanti);
            label_RegisteredBooks_2.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txt_MemberSchoolNumber.Text == "") //temizleme
            {
                label_books_2.Text = "";
                label_RegisteredBooks_2.Text = "";
            }

        }

        private void txt_BookName_TextChanged(object sender, TextChangedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Book where BookName like '" + txt_BookName.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txt_BookPage.Text = read["BookPage"].ToString();
                combobox_BookCategory.Text = read["BookCategory"].ToString();
                txt_BookAuthor.Text = read["BookAuthor"].ToString();
                txt_BookYear.Text = read["BookYear"].ToString();
            }
            baglanti.Close();

        }

        private void btn_Lend_DepositBook_Click(object sender, RoutedEventArgs e)
        {
            if (label_books_2.Text != "")
            {
                //sayisal deger olcagi icin int parse dedim
                if ((string.IsNullOrEmpty(label_RegisteredBooks_2.Text) && int.Parse(label_books_2.Text) <= 399999) ||
                    (!string.IsNullOrEmpty(label_RegisteredBooks_2.Text) && (int.Parse(label_RegisteredBooks_2.Text) + int.Parse(label_books_2.Text)) <= 99999999)) //en fazla 3 kitap alabilirsin
                {

                    if (txt_MemberSchoolNumber.Text != "" && txt_MemberName.Text != "" && txt_MemberSurname.Text != "" && txt_MemberMail.Text != "" && combobox_MemberType.Text != "")
                    {
                        var dataGrid = (IEditableCollectionView)DataGridViewDepositBook.Items;
                        dataGrid.NewItemPlaceholderPosition = NewItemPlaceholderPosition.None;

                        foreach (var aaa in DataGridViewDepositBook.Items)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into DepositBooks(SchoolNumber,Name,Surname,Mail,MemberType,BookName,BookAuthor,BookPage,BookCategory,BookYear,BookPiece,DeliveryDate,ReturnDate) values(@SchoolNumber,@Name,@Surname,@Mail,@MemberType,@BookName,@BookAuthor,@BookPage,@BookCategory,@BookYear,@BookPiece,@DeliveryDate,@ReturnDate) ", baglanti);
                            komut.Parameters.AddWithValue("@SchoolNumber", txt_MemberSchoolNumber.Text);
                            komut.Parameters.AddWithValue("@Name", txt_MemberName.Text);
                            komut.Parameters.AddWithValue("@Surname", txt_MemberSurname.Text);
                            komut.Parameters.AddWithValue("@Mail", txt_MemberMail.Text);
                            komut.Parameters.AddWithValue("@MemberType", combobox_MemberType.Text);

                            var item = (DataRowView)aaa;

                            komut.Parameters.AddWithValue("@BookName", !string.IsNullOrEmpty(item.Row.ItemArray[0].ToString()) ? item.Row.ItemArray[0] : "Boş");
                            komut.Parameters.AddWithValue("@BookPage", !string.IsNullOrEmpty(item.Row.ItemArray[1].ToString()) ? item.Row.ItemArray[1] : "Boş");
                            komut.Parameters.AddWithValue("@BookAuthor", !string.IsNullOrEmpty(item.Row.ItemArray[2].ToString()) ? item.Row.ItemArray[2] : "Boş");
                            komut.Parameters.AddWithValue("@BookCategory", !string.IsNullOrEmpty(item.Row.ItemArray[3].ToString()) ? item.Row.ItemArray[3] : "Boş");
                            komut.Parameters.AddWithValue("@BookYear", !string.IsNullOrEmpty(item.Row.ItemArray[4].ToString()) ? item.Row.ItemArray[4] : "Boş");
                            komut.Parameters.AddWithValue("@BookPiece", !string.IsNullOrEmpty(item.Row.ItemArray[5].ToString()) ? item.Row.ItemArray[5] : "Boş");
                            komut.Parameters.AddWithValue("@DeliveryDate", !string.IsNullOrEmpty(item.Row.ItemArray[6].ToString()) ? item.Row.ItemArray[6] : "Boş");
                            komut.Parameters.AddWithValue("@ReturnDate", !string.IsNullOrEmpty(item.Row.ItemArray[7].ToString()) ? item.Row.ItemArray[7] : "Boş");


                            komut.ExecuteNonQuery();

                            baglanti.Close();
                        }



                        //       SqlCommand komut2 = new SqlCommand("update Member set MemberBooks=MemberBooks+'"+int.Parse(DataGridViewDepositBook.Rows.[i].Cells["BookPiece"].Value.ToString())+"' where SchoolNumber='"+txt_MemberSchoolNumber.Text+"' ",baglanti);
                        //                            komut2.ExecuteNonQuery();
                        //      SqlCommand komut3 = new SqlCommand("update Book set BookStock=BookStock-'" + int.Parse(DataGridViewDepositBook.Rows.[i].Cells["BookPiece"].Value.ToString()) + "' where BookName='" + DataGridViewDepositBook.Rows.[i].Cells["BookName"].Value.ToString() + "' ", baglanti);
                        //                           komut3.ExecuteNonQuery();


                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from Cart", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Done."); //kitaplar emanet edildi mesaji
                        daset.Tables["Cart"].Clear();
                        ListCartNow();
                        txt_BookName.Text = "";
                        label_RegisteredBooks_2.Text = "";
                        label_books_2.Text = "";
                        NumberBooks();
                        //commands
                    }
                    else
                    {
                        MessageBox.Show("You should first select MemberName!", "WARNING!");
                    }

                }
                else
                {
                    MessageBox.Show("You can borrow maximum 3 book!", "WARNING!");
                }



            }
            else
            {
                MessageBox.Show("First add books to cart!", "WARNING!");
            }









        }

        private void txt_MemberName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_delete_DepositBook_Admin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var aaa = DataGridViewDepositBook.SelectedItem;
                var row = (DataRowView)aaa;


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete Cart where Id=@Id", baglanti);
                komut.Parameters.AddWithValue("@Id", row.Row.ItemArray[0]);
                komut.ExecuteNonQuery();
                baglanti.Close();


                daset.Tables["Cart"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9
                ListCartNow();

            }
            catch (Exception)
            {
                MessageBox.Show("Done.");
            };


        }


    }
}

