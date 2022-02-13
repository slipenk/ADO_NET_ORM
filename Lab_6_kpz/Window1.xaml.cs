using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Lab_6_kpz
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable WorkersT;
        SqlConnection conn;

        public Window1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GreenResortManagementSystemModels"].ConnectionString;
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            string s = "SELECT * FROM Workers";
            WorkersT = new DataTable();
           
            try
            {
                conn = new SqlConnection(connectionString);
                SqlCommand sqlcommand = new SqlCommand(s, conn);
                adapter = new SqlDataAdapter(sqlcommand);
                conn.Open();
                adapter.Fill(WorkersT);
                DGrid.ItemsSource = WorkersT.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(WorkersT);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItems != null)
            {
                for (int i = 0; i < DGrid.SelectedItems.Count; i++)
                {
                    DataRowView DRV = DGrid.SelectedItems[i] as DataRowView;
                    if (DRV != null)
                    {
                        
                        DataRow dataRow = (DataRow)DRV.Row;
                        DeleteForeign(dataRow[3].ToString(), dataRow[8].ToString());
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void DeleteForeign(string Phone, string Email)
        {



            string sW = "DELETE  FROM Workers_Tours WHERE ID_worker = (SELECT ID_workers FROM Workers WHERE Phone_number = '" + Phone + "' AND Email = '" + Email + "')";
       
            try
            {
                conn.Open();
                SqlCommand sqlcommandW = new SqlCommand(sW, conn);
                sqlcommandW.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
