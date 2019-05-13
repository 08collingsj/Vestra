using MyPortfolio.HelperClasses;
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

namespace MyPortfolio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PowerShellObject localPS = new PowerShellObject();
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            localPS.CloseExplorer();
            base.OnClosing(e);
        }
        private void CloseExplorerClick(object sender, RoutedEventArgs e)
        {
            localPS.CloseExplorer();
        }

        private void UniWorkClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void MyProjectsClick(object sender, RoutedEventArgs e)
        {

        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
