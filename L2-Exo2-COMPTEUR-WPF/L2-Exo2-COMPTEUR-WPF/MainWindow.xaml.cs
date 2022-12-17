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

namespace L2_Exo2_COMPTEUR_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Compteur> compteurList;

        public MainWindow()
        {
            InitializeComponent();
            compteurList = new List<Compteur>();
        }

        private void btnInst_Click(object sender, RoutedEventArgs e)
        {
            compteurList.Add(new Compteur());
        }

        private void btnDisplayNbObj_Click(object sender, RoutedEventArgs e)
        {
            lblNbObj.Content = Compteur.NbObj;
        }
    }
}
