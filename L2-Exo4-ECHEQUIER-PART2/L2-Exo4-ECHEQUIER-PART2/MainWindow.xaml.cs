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

namespace L2_Exo4_ECHEQUIER_PART2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Echequier echequier;
        private Label[,] arrLabels = new Label[8, 8];
        
        public MainWindow()
        {
            InitializeComponent();
            echequier = new Echequier();
            SetColors();
        }

        private void SetColors()
        {
            bool alt = false;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Label label = new Label();


                    if (alt)
                    {
                        label.Background = Brushes.Black;
                        label.Foreground = Brushes.White;     
                        alt = false;
                    }
                    else
                    {
                        alt = true;
                    }
                    

                    label.FontSize = 14;

                    label.Content = echequier.echequier[7-y, x];
                    label.HorizontalContentAlignment = HorizontalAlignment.Center;
                    label.VerticalContentAlignment = VerticalAlignment.Center;

                    Grid.SetRow(label, y);
                    Grid.SetColumn(label, x);

                    arrLabels[y, x] = label;

                    gridEchequier.Children.Add(label);
                }

                if (alt)
                {
                    alt = false;
                }
                else
                {
                    alt = true;
                }
            }
        }
    }
}
