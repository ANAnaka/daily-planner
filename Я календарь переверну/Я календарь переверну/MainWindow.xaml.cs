using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using static Я_календарь_переверну.json;

namespace Я_календарь_переверну
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            data.SelectedDate = DateTime.Now;
           
        } 
/*        public void z()
        {
                string jsonchik = JsonConvert.SerializeObject(Zametki);
                File.WriteAllText("C:\\Рабочий стол\\Soxran", jsonchik);
        
        }*/

        private void Cozdanie_Click(object sender, RoutedEventArgs e)
        {
            Nazvanie
        }
    }
}
