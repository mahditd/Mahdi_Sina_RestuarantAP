using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mahdi_Sina_AP_Project
{
    
    public class NavButton3 : ButtonBase
    {
        static NavButton3()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavButton3), new FrameworkPropertyMetadata(typeof(NavButton3)));
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(NavButton3), new PropertyMetadata(null));
        public static readonly DependencyProperty NavUriProperty = DependencyProperty.Register("NavUri", typeof(Uri), typeof(NavButton3), new PropertyMetadata(null));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Uri NavUri
        {
            get { return (Uri)GetValue(NavUriProperty); }
            set { SetValue(NavUriProperty, value); }
        }
    }
}
