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

namespace GIT_taak
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

        private void Red_MouseEnter(object sender, MouseEventArgs e)
        {
            Background = Brushes.Red;
        }

        private void Red_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = Brushes.LightGray;
            colorcodeTextBox.Text = " ";
            informationTextBox.Text = " ";
        }

        private void Yellow_MouseEnter(object sender, MouseEventArgs e)
        {
            Background = Brushes.Yellow;
        }

        private void Yellow_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = Brushes.LightGray;
            colorcodeTextBox.Text = " ";
            informationTextBox.Text = " ";
        }

        private void Green_MouseEnter(object sender, MouseEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void Green_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = Brushes.LightGray;
            colorcodeTextBox.Text = " ";
            informationTextBox.Text = " ";
        }

        private void Blue_MouseEnter(object sender, MouseEventArgs e)
        {
            Background = Brushes.Blue;
        }

        private void Blue_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = Brushes.LightGray;
            colorcodeTextBox.Text = " ";
            informationTextBox.Text = " ";
        }

        private void Red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "Rood: #FF0000";
            informationTextBox.Text = "Rood is de kleur van warmte.";
        }

        private void Yellow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "Geel: #FFFF00";
            informationTextBox.Text = "Geel is de kleur van levenslust.";
        }

        private void Green_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "Groen: #008000";
            informationTextBox.Text = "Groen is de kleur van genezing.";
        }
    

        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorcodeTextBox.Text = "Blauw: #0000FF";
            informationTextBox.Text = "Blauw is de kleur van intelligentie.";
        }
    }
}
