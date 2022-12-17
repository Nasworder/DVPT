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

namespace L2_Exo3_SINGLETON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TheClass theClass;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void idCreateInstance_Click(object sender, RoutedEventArgs e)
        {
            string actualRandom = RandomString();
            lblGenKey.Content = actualRandom;
            theClass = TheClass.Instance(actualRandom);
            lblCurrentInstKey.Content = theClass.Value;

        }

        // Return random String of 10 characters
        private string RandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void idCreateInstance2_Click(object sender, RoutedEventArgs e)
        {
            string actualRandom = RandomString();
            lblGenKey.Content = actualRandom;
            theClass = TheClass.Instance(actualRandom);
            lblCurrentInstKey.Content = theClass.Value;
        }
    }

}
