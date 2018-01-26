using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> oc;
        public MainWindow()
        {
            InitializeComponent();
            oc = new ObservableCollection<User>();
            oc.Add(new User { Number=12});
            oc.Add(new User { Number = 6 });
            oc.Add(new User { Number = 15 });

            lv.ItemsSource = oc;

            Console.WriteLine(lv.Items.Count);

            Console.WriteLine(System.Windows.SystemParameters.PrimaryScreenWidth);

        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            lv.Items.SortDescriptions.Add(
        new SortDescription("Number", ListSortDirection.Descending));
            Console.WriteLine(oc[0].Number);
        }
    }

    public class User{

        public int Number
        {
            get;set;
        }

    }
}
