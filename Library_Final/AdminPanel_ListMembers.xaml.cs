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
    /// Interaction logic for AdminPanel_ListMembers.xaml
    /// </summary>
    public partial class AdminPanel_ListMembers : Window
    { 
        public AdminPanel_ListMembers()
        {
            InitializeComponent();
            ListMemberNow();
        }
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");
        private void txt_Name_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void txt_Number_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Member where SchoolNumber ='" + txt_Number_Admin.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader(); //textlerde kayıtların görülmesi için yazdım
            while (read.Read())
            {
                txt_Name_Admin.Text = read["Name"].ToString();
                txt_SurName_Admin.Text = read["Surname"].ToString();
                txt_Mail_Admin.Text = read["Mail"].ToString();
                txt_Password_Admin.Text = read["Password"].ToString();
                combobox_MemberType_Admin.Text = read["MemberType"].ToString();

            }
            baglanti.Close();
        }

        DataSet daset = new DataSet();

        private void ListMemberNow()
            {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member", baglanti);
            adtr.Fill(daset,"Member");
            DataGridView1.ItemsSource = daset.Tables["Member"].DefaultView;
            baglanti.Close();
        }



        private void txt_SearchNumber_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {
            daset.Tables["Member"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member where SchoolNumber like '%" + txt_SearchNumber_Admin.Text + "%'", baglanti); //youtubeden bakarak yazdım. 
            adtr.Fill(daset, "Member");
            DataGridView1.ItemsSource = daset.Tables["Member"].DefaultView; //1 tane olduugu için ismi değişmedim
            baglanti.Close();
        }

        

        private void btn_Update_Admin_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Member set Name=@Name,Mail=@Mail,Password=@Password,MemberType=@MemberType,SurName=@Surname where SchoolNumber=@SchoolNumber", baglanti);
            komut.Parameters.AddWithValue("@SchoolNumber", txt_Number_Admin.Text);
            komut.Parameters.AddWithValue("@Name", txt_Name_Admin.Text);
            komut.Parameters.AddWithValue("@Mail", txt_Mail_Admin.Text);
            komut.Parameters.AddWithValue("@Password", txt_Password_Admin.Text);
            komut.Parameters.AddWithValue("@MemberType", combobox_MemberType_Admin.Text);
            komut.Parameters.AddWithValue("@Surname", txt_SurName_Admin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Done.");
            daset.Tables["Member"].Clear();
            ListMemberNow();
            
            
        }

        private void btn_Delete_Admin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete Member where SchoolNumber=@SchoolNumber", baglanti);
                komut.Parameters.AddWithValue("@SchoolNumber", txt_Number_Admin.Text); //okul numarasi yazmak lazim
                komut.ExecuteNonQuery();
                baglanti.Close();


                daset.Tables["Member"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 10 - 19 - 19+8= 27
                ListMemberNow();
                MessageBox.Show("Done.");

            }
            catch (Exception)
            {
                MessageBox.Show("Done.");
            };
        }
    }
}
