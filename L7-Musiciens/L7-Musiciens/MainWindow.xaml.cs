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

namespace L7_Musiciens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            txtRes.SetValue(TextBlock.TextProperty, "");
            ChefOrchestre chef = new ChefOrchestre();
            chef.PréparerOrchestration(ckPianist, ckGuitarist, ckDrummer, ckSinger, ckBassist);
            chef.Orchestrer(txtRes);
        }
    }

    class ChefOrchestre
    {
        delegate void DelegueJouerInstrument(TextBlock txt);
        private DelegueJouerInstrument JouerInstrument = null;

        private Pianist ipianist = new Pianist();
        private Guitarist iguitarist = new Guitarist();
        private Drummer idrummer = new Drummer();
        private Singer isinger = new Singer();
        private Bassist ibassist = new Bassist();


        public void PréparerOrchestration(CheckBox pianist, CheckBox guitarist, CheckBox drummer, CheckBox singer, CheckBox bassist)
        {
            if (pianist.IsChecked == true)
            {
                JouerInstrument += ipianist.PlayPiano;
            }
            if (guitarist.IsChecked == true)
            {
                JouerInstrument += iguitarist.PlayGuitar;
            }
            if (drummer.IsChecked == true)
            {
                JouerInstrument += idrummer.PlayDrums;
            }
            if (singer.IsChecked == true)
            {
                JouerInstrument += isinger.Sing;
            }
            if (bassist.IsChecked == true)
            {
                JouerInstrument += ibassist.PlayBass;
            }
        }

        public void Orchestrer(TextBlock txt)
        {
            //this.JouerInstrument -= v.JouerDuViolon;
            if (JouerInstrument != null)
            {
                JouerInstrument(txt);
            }

        }

    }

    class Pianist
    {
        public void PlayPiano(TextBlock txt)
        {
            txt.Text += "Pianist plays piano\n";
        }
    }

    class Guitarist
    {
        public void PlayGuitar(TextBlock txt)
        {
            txt.Text += "Guitarist plays guitar\n";
        }
    }


    class Drummer
    {
        public void PlayDrums(TextBlock txt)
        {
            txt.Text += "Drummer plays drums\n";
        }
    }


    class Singer
    {
        public void Sing(TextBlock txt)
        {
            txt.Text += "Singer sings\n";
        }
    }


    class Bassist
    {
        public void PlayBass(TextBlock txt)
        {
            txt.Text += "Bassist plays bass\n";
        }
    }

}


