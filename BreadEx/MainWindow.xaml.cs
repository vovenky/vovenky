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

namespace BreadEx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VidBox.Items.Add("Ржаной");
            VidBox.Items.Add("Белый");
            VidBox.Items.Add("Черный");
        }
        int costBread;
       
        bool belHleb = false;
        bool rjHleb = false;
        bool BlackHleb = false;
        private void VidBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (int.TryParse(VesBox.Text,out int ves) == true)
            {
                
                    Hleb HlebClass = new Hleb();
                    CostLabel.Content = HlebClass.CostForVes(ves, VidBox.Text);
                    costBread = HlebClass.CostForVes(ves, VidBox.Text);
               
                
                  
               

                
            }
            else
            {
                MessageBox.Show("Введите вес хлеба", "ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                
            }
            belHleb = false;
            rjHleb = false;
            BlackHleb = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sklad sklad = new Sklad();
                if (sklad.Kolvo(Convert.ToInt32(VesBox.Text), VidBox.Text) == true)
                {
                    Zakaz zakaz = new Zakaz();
                    BusketBox.Items.Add(zakaz.OrderForBusket(Convert.ToInt32(VesBox.Text), VidBox.Text, costBread));
                }
                else
                {
                    MessageBox.Show("На складе недостаточно хлеба", "ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка данных", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            AllCost.Content = Zakaz.allcost;
        }
        
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BusketBox.Items.Remove(BusketBox.SelectedIndex);
        }

        private void BusketBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled = true;
            
        }
    }
}
