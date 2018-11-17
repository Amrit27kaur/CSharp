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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace FirstFormSubmitClear14Nov
{
    /// <summary>
    /// Interaction logic for SecondWindowListOfStudent.xaml
    /// </summary>
    public partial class SecondWindowListOfStudent : Window
    {
        public SecondWindowListOfStudent()
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=trios_college;";

            // Select all

            string query = "SELECT * FROM student;";



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
            da.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;

            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;



           
                databaseConnection.Close();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
