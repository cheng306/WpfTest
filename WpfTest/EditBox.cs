using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfTest
{
    class EditBox : Control
    {

        
            public static readonly DependencyProperty ValueProperty =
                    DependencyProperty.Register(
                            "Value",
                            typeof(object),
                            typeof(EditBox),
                            new FrameworkPropertyMetadata());

        public static DependencyProperty IsEditingProperty =
                    DependencyProperty.Register(
                            "IsEditing",
                            typeof(bool),
                            typeof(EditBox),
                            new FrameworkPropertyMetadata(false)
                            );

    }
}
