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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            combobox_MemberType.SelectedIndex = 0; // 0 1 2 3 4 5
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");


        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btn_AddMember_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("insert into Member(Name,SchoolNumber,Mail,Password,MemberType,Surname) values(@Name,@SchoolNumber,@Mail,@Password,@MemberType,@Surname)", baglanti);
            komut.Parameters.AddWithValue("@Name", txt_Name.Text);
            komut.Parameters.AddWithValue("@Surname", txt_SurName.Text);
            komut.Parameters.AddWithValue("@SchoolNumber", txt_Number.Text);
            komut.Parameters.AddWithValue("@Mail", txt_Mail.Text);
            komut.Parameters.AddWithValue("@Password", txt_Password.Text);
            komut.Parameters.AddWithValue("@MemberType", combobox_MemberType.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registration Successful.");
        }
    }
}
