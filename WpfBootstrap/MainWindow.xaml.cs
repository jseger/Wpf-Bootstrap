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

namespace WpfBootstrap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public List<object> DataItems
        {
            get {
                return new List<object>() {
                    new {
                        Name = "Joe",
                        Age = 65,
                        Phone = "906-356-6880"
                    },
                    new {
                        Name = "Jim",
                        Age = 32,
                        Phone = "906-356-6946"
                    },
                    new {
                        Name = "Jane",
                        Age = 27,
                        Phone = "906-356-6990"
                    }
                };
            }
        }
    }
}
