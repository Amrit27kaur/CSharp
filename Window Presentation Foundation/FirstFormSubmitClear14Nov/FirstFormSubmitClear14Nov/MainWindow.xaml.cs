using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace FirstFormSubmitClear14Nov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            //for enter the data in text box
            var FName = nameFirst.Text;
            var LName = nameLast.Text;

            var AName = add.Text;
            var PName = number.Text;


            //for radio btn coding
            var gender = "";
            if (male.IsChecked == true)
            {
                gender = "Male";
            }

            if (female.IsChecked == true)
            {
                gender = "Female";
            }

              //for preference
                var preference = "";
                if (partBtn.IsChecked == true)
                {
                    preference = "Part Time";
                }

                if (fullBtn.IsChecked == true)
                {
                    preference = "Full Time";
                } 

            //int PName = Convert.ToInt32(number.Text);   in if condition PName == null



            //for textbox
            if (FName == "" || LName == "" || AName =="" || PName == "")
            {
                MessageBox.Show("please enter valid value");
            }
            else
            {
                MessageBox.Show("Sucessfully Uploaded");
            }

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=trios_college;";

            string query = "INSERT INTO student(`Student_id`, `FirstName`, `LastName`, `Address`,`Phone`,`gender`,`preference`) VALUES (NULL, '" + FName + "', '" + LName + "', '" + AName + "','" + PName + "','" + gender + "','" + preference + "')";

            // Which could be translated manually to :

            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;



            try

            {

                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();



                MessageBox.Show("User succesfully registered");



                databaseConnection.Close();

            }

            catch (Exception ex)

            {

                // Show any error message.

                MessageBox.Show(ex.Message);

            }



            

             /*   //for preference
                var preference = "";
                if (partBtn.IsChecked == true)
                {
                    preference = "Part Time";
                }

                if (fullBtn.IsChecked == true)
                {
                    preference = "Full Time";
                } */


        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            //for clear the value of text
            nameFirst.Text = "";
            nameLast.Text = "";
            add.Text = "";
            number.Text = "";

        }

       
        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            //for close the window
            Application.Current.MainWindow.Close();
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondWindowListOfStudent wind2 = new SecondWindowListOfStudent();
            wind2.Show();
            this.Hide();

        }
    }

    
    
}
