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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5QSBG5;Initial Catalog=Library_Final;Integrated Security=True");


        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        bool isThere;

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {

            string SchoolNumber = txt_Number_Login.Text;
            string Password = txt_password_Login.Text;
            string MemberType = txt_AdminRule.Text;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Member", baglanti);
            SqlDataReader reader = komut.ExecuteReader(); //tablodaki tum degerleri okumak icin executereader yazdim

            while (reader.Read())
            {

                if (SchoolNumber == reader["SchoolNumber"].ToString() && Password == reader["Password"].ToString() && MemberType==reader["Mail"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }

            }

            if (isThere)
            {
                MessageBox.Show("Succesful!");
                this.Close();
                AdminPanel AdminPanelMain = new AdminPanel();
                AdminPanelMain.ShowDialog();

            }
            else
            {
                MessageBox.Show("ERROR! Please check School Number and Password!");
            }
            baglanti.Close();

        }
    }
}
