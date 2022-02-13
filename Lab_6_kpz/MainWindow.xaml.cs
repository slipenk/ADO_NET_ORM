using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Lab_6_kpz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GreenResortManagementSystemModels db;
        public MainWindow()
        {
            InitializeComponent();
            db = new GreenResortManagementSystemModels();
            db.Clients.Load(); 
            DGrid.ItemsSource = db.Clients.Local.ToBindingList();
           
           

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }


        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
  
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DGrid.SelectedItems.Count; i++)
                {
                    Client client = DGrid.SelectedItems[i] as Client;
                   
                    
                    if (client != null)
                    {
      
                        var TC = db.MM_Tours_Clients.Where(t => t.ID_clients == client.ID_client).ToList();
                        foreach( var c in  TC)
                        {
                            db.MM_Tours_Clients.Remove(c);
                        }
                             
                        db.Clients.Remove(client);
                    }
                }
            }
            db.SaveChanges();
            
        }
        private void OtherWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();

        }

       
    }
}
