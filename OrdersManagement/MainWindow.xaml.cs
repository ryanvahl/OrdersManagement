using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrdersManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        // Implements interface INotifyPropertyChanged
        // Allows invoking of event manually instead of automatically as GUI does when interacted with
        public event PropertyChangedEventHandler? PropertyChanged;

        private void Maxbtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private GridLength _firstColumn = new GridLength(20, GridUnitType.Star);
        private GridLength _secondColumn;

        public GridLength FirstColumn {
            get { return _firstColumn; }
            set
            {

            _firstColumn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstColumn"));
            }            
        }

        private void OpenCloseNav_Click(object sender, RoutedEventArgs e)
        {
            if (FirstColumn.Value != 0)
            {
                FirstColumn = new GridLength(0, GridUnitType.Star);
            }
            else
            {
                FirstColumn = new GridLength(20, GridUnitType.Star);
            }

            //SideNavContainer
            // How do you restore the responsive sizing when "20*" is a string in XAML
            //if (SideNavContainer.Width != 0)
            //{
            //    SideNav.Width = 0;
            //}
            //else
            //{
            //    SideNavContainer.Width = 0
            //}
            //if (SideNav.Width != 0)
            //{
            //    SideNav.Width = 0;
            //}
            //else
            //{
            //    SideNav.Width = 230;
            //}            
        }
    }
}