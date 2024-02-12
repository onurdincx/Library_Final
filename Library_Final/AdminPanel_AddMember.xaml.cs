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

namespace Library_Final
{
    /// <summary> 
    /// Interaction logic for AdminPanel_AddMember.xaml
    /// </summary>    
    public partial class AdminPanel_AddMember : Window
    {
        public AdminPanel_AddMember()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True"); 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       
        
        private void btn_AddMember_Admin_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open(); //kodları Akay Yazılım youtube hesabından bakarak yazdım. kopyala yapıştır yapmadım
            SqlCommand komut = new SqlCommand("insert into Member(Name,SchoolNumber,Mail,Password,MemberType,Surname) values(@Name,@SchoolNumber,@Mail,@Password,@MemberType,@Surname)", baglanti);
            komut.Parameters.AddWithValue("@Name", txt_Name_Admin.Text);
            komut.Parameters.AddWithValue("@Surname", txt_SurName_Admin.Text);
            komut.Parameters.AddWithValue("@SchoolNumber", txt_Number_Admin.Text);
            komut.Parameters.AddWithValue("@Mail", txt_Mail_Admin.Text);
            komut.Parameters.AddWithValue("@Password", txt_Password_Admin.Text);
            komut.Parameters.AddWithValue("@MemberType", combobox_MemberType_Admin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registration Successful.");
            

        }

        private void combobox_MemberType_Admin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txt_Password_Admin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
