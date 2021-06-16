using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

        private void walidator(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-F0-9]");
            if (regex.IsMatch(TextAX.Text))
            {
                MessageBox.Show("Błędna wartość! Podaj wartości w systemie szesnastkowym!");
                TextAX.Text = String.Empty;
            }

            if (regex.IsMatch(TextBX.Text))
            {
                MessageBox.Show("Błędna wartość! Podaj wartości w systemie szesnastkowym!");
                TextBX.Text = String.Empty;
            }

            if (regex.IsMatch(TextCX.Text))
            {
                MessageBox.Show("Błędna wartość! Podaj wartości w systemie szesnastkowym!");
                TextCX.Text = String.Empty;
            }

            if (regex.IsMatch(TextDX.Text))
            {
                MessageBox.Show("Błędna wartość! Podaj wartości w systemie szesnastkowym!");
                TextDX.Text = String.Empty;
            }

        }
        private void ButtonMOVAXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            TextAX.Text = TextBX.Text;
        }


        private void ButtonMOVAXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            TextAX.Text = TextCX.Text;
        }

        private void ButtonMOVAXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            TextAX.Text = TextDX.Text;
        }

        private void ButtonMOVBXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            TextBX.Text = TextAX.Text;
        }

        private void ButtonMOVBXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            TextBX.Text = TextCX.Text;
        }

        private void ButtonMOVBXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            TextBX.Text = TextDX.Text;
        }

        private void ButtonMOVCXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            TextCX.Text = TextAX.Text;
        }

        private void ButtonMOVCXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            TextCX.Text = TextBX.Text;
        }

        private void ButtonMOVCXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            TextCX.Text = TextDX.Text;
        }

        private void ButtonMOVDXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            TextDX.Text = TextAX.Text;
        }

        private void ButtonMOVDXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            TextDX.Text = TextBX.Text;
        }

        private void ButtonMOVDXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            TextDX.Text = TextCX.Text;
        }

        private void ButtonXCHGAXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            String temp = TextAX.Text;
            TextAX.Text = TextBX.Text;
            TextBX.Text = temp;
        }

        private void ButtonXCHGAXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            String temp = TextAX.Text;
            TextAX.Text = TextCX.Text;
            TextCX.Text = temp;
        }

        private void ButtonXCHGAXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextAX.Text;
            String temp = TextAX.Text;
            TextAX.Text = TextDX.Text;
            TextDX.Text = temp;
        }

        private void ButtonXCHGBXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            String temp = TextBX.Text;
            TextBX.Text = TextAX.Text;
            TextAX.Text = temp;
        }

        private void ButtonXCHGBXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            String temp = TextBX.Text;
            TextBX.Text = TextCX.Text;
            TextCX.Text = temp;
        }

        private void ButtonXCHGBXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextBX.Text;
            String temp = TextBX.Text;
            TextBX.Text = TextDX.Text;
            TextDX.Text = temp;
        }

        private void ButtonXCHGCXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            String temp = TextCX.Text;
            TextCX.Text = TextAX.Text;
            TextAX.Text = temp;
        }

        private void ButtonXCHGCXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            String temp = TextCX.Text;
            TextCX.Text = TextBX.Text;
            TextBX.Text = temp;
        }

        private void ButtonXCHGCXDX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextCX.Text;
            String temp = TextCX.Text;
            TextCX.Text = TextDX.Text;
            TextDX.Text = temp;
        }

        private void ButtonXCHGDXAX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            String temp = TextDX.Text;
            TextDX.Text = TextAX.Text;
            TextAX.Text = temp;
        }

        private void ButtonXCHGDXBX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            String temp = TextDX.Text;
            TextDX.Text = TextBX.Text;
            TextBX.Text = temp;
        }

        private void ButtonXCHGDXCX_Click(object sender, RoutedEventArgs e)
        {
            var operation = TextDX.Text;
            String temp = TextDX.Text;
            TextDX.Text = TextCX.Text;
            TextCX.Text = temp;
        }
    }
}
