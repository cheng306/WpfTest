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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for Circle.xaml
    /// </summary>
    public partial class Circle : UserControl
    {

        private Brush _previousFill = null;

        public Circle()
        {
            InitializeComponent();
        }

        public Circle(Circle c)
        {
            InitializeComponent();
            this.circleUI.Height = c.circleUI.Height;
            this.circleUI.Width = c.circleUI.Height;
            this.circleUI.Fill = c.circleUI.Fill;
        }

        public string IntegerPro2
        {
            get { return a; }
            set { b = value; }
        }

        private string b;

        public static String a = "sdf";

        public string IntegerPro
        {
            get { return (string)GetValue(IntegerrProProperty); }
            set { SetValue(IntegerrProProperty, value); }
        }

      public static readonly DependencyProperty IntegerrProProperty
      = DependencyProperty.Register("IntegerPro", typeof(string),typeof(Circle));

      public int A { get; set; }

    }
}
