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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Play(object sender, RoutedEventArgs e)
        {
            Trailes.Play();
        }

        private void Button_Pause(object sender, RoutedEventArgs e)
        {
            Trailes.Pause();
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            Trailes.Stop();
        }

        private void Checked_Trailers(object sender, RoutedEventArgs e)
        {
            Trailes.Play();
            if (((RadioButton)sender).Name == "Trailer1")
            {
                Trailes.Source = new Uri("C:/Users/alumno/source/repos/Reproductor/Reproductor/Trailers/trailer1.mp4");
            }
            else if (((RadioButton)sender).Name == "Trailer1")
            {
                Trailes.Source = new Uri("C:/Users/alumno/source/repos/Reproductor/Reproductor/Trailers/trailer2.mp4");
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(((CheckBox)sender).IsChecked == true)
                Trailes.IsMuted = true;
            else
                Trailes.IsMuted = false;
        }
    }
}
