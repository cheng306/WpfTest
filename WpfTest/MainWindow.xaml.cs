using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
    ObservableCollection<String> oc;
    public MainWindow()
    {
      InitializeComponent();

      oc = new ObservableCollection<String>
      {
        "aaa",
        "bbb",
        "ccc"
      };
      listBox.ItemsSource = oc;

    }

    public class A{
      public B A1 { get; set; }
      public int A2 { get; set; }
    }

    public class B
    {
      public int B1 { get; set; }
    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
      Console.WriteLine("ooooo");
    }

    private void Btn_Click2(object sender, RoutedEventArgs e)
    {
      Console.WriteLine("ooooo2");
    }

    private void LoadTest()
    {

    }

    private void Button_MouseDown(object sender, MouseButtonEventArgs e)
    {
      Console.WriteLine("yes");
    }

    private void Button_TouchDown(object sender, TouchEventArgs e)
    {

    }

    private void Button_TouchMove(object sender, TouchEventArgs e)
    {
      //Console.WriteLine("Move" + stopWatch.Elapsed);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      oc[2] = "sdf";
      //ste = "hooo";
      Console.WriteLine(oc[1]);
      
    }
  }

}
