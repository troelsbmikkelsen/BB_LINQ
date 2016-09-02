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

namespace BB_LINQ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private static string connectionString = @"Data Source=CV-PC-T-04\SQLEXPRESS;Initial Catalog=BorgesBadevaerelser;Integrated Security=True";

        public MainWindow() {
            InitializeComponent();

            DataContext = new RammeAftaleViewModel(1);
        }
    }
}
