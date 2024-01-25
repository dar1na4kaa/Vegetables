using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Vegetables
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Products; Integrated Security=SSPI;");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try {
                conn.Open();
                mainLabel.Background = new SolidColorBrush(Colors.Green);
                mainLabel.Content = "База данных подключена";
            }
            catch 
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "База данных неподключена";
            }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Close();
                mainLabel.Background = new SolidColorBrush(Colors.MediumPurple);
                mainLabel.Content = "База данных отключена";
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AllInfo_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select * from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while(read.Read())
                {
                    for(int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AllName_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select NAME from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AllColors_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select COLOR from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void MaxCalories_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select MAX(CALORIES) from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void MinCalories_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select MIN(CALORIES) from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AVGCalories_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select AVG(CALORIES) from Fruits_And_Vegetables";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void CountFruits_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select TYPE, COUNT(*) AS 'COUNT' from Fruits_And_Vegetables GROUP BY TYPE;";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void CountVegetable_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select TYPE, COUNT(*) AS 'COUNT' from Fruits_And_Vegetables GROUP BY TYPE;";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void CountColors_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string color = colorBox.Text;
                string command = @"select COUNT(ID) AS 'COUNT' from Fruits_And_Vegetables where COLOR = " + color;
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void CountALLColors_Checked(object sender, RoutedEventArgs e)
        {
           
            try
            {
                string command = @"select COLOR, COUNT(*) AS 'COUNT' from Fruits_And_Vegetables group by COLOR;";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AllLessCalories_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                int lessCalor = Int32.Parse(lessCalorBox.Text.Trim());
                string command = @"select NAME from Fruits_And_Vegetables where CALORIES  < " + lessCalor + ";";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void AllMoreCalories_Checked(object sender, RoutedEventArgs e)
        {
        try
        {
            int moreCalor = Int32.Parse(moreCalorBox.Text.Trim());
            string command = @"select NAME from Fruits_And_Vegetables where CALORIES  >= " + moreCalor + ";";
            SqlCommand cmd = new SqlCommand(command, conn);

            SqlDataReader read = cmd.ExecuteReader();
            string text = "";

            while (read.Read())
            {
                for (int i = 0; i < read.FieldCount; i++)
                {
                    text += read[i] + " \t ";
                }
                text += "\n";
            }
            outputText.Text = text;
        }
        catch
        {
            mainLabel.Background = new SolidColorBrush(Colors.Red);
            mainLabel.Content = "Проблема с БД";
        }
    }

        private void AllDiapozon_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                int startCalor = Int32.Parse(startCalorBox.Text.Trim());
                int endCalor = Int32.Parse(endCalorBox.Text.Trim());
                string command = @"select NAME from Fruits_And_Vegetables where CALORIES BETWEEN " + startCalor + " AND "+ endCalor + " ;";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }

        private void YeallowRedVegFr_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                string command = @"select NAME from Fruits_And_Vegetables where COLOR = 'Красный' OR COLOR = 'Желтый';";
                SqlCommand cmd = new SqlCommand(command, conn);

                SqlDataReader read = cmd.ExecuteReader();
                string text = "";

                while (read.Read())
                {
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        text += read[i] + " \t ";
                    }
                    text += "\n";
                }
                outputText.Text = text;
            }
            catch
            {
                mainLabel.Background = new SolidColorBrush(Colors.Red);
                mainLabel.Content = "Проблема с БД";
            }
        }
    }
}
