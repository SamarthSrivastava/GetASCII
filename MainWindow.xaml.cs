using System;
using System.Collections.Generic;
using System.Linq;
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

namespace GetASCII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtInptChar.MaxLength = 1;
            txtInptChar.Focus();
        }

        private void btnGetVal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Int32 var1 = Convert.ToInt32(txtInptChar.Text[0]);
                if (var1 >= 32 && var1 <= 126)
                    lblAns.Content = Convert.ToString(var1);
            }
            catch 
            {
                lblAns.Visibility = System.Windows.Visibility.Hidden;
                lblASCII.Visibility = System.Windows.Visibility.Hidden;
                lblWrngChar.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void txtInptChar_KeyDown(object sender, KeyEventArgs e)
        {
            lblAns.Content = null;
            lblAns.Visibility = System.Windows.Visibility.Visible;
            lblASCII.Visibility = System.Windows.Visibility.Visible;
            lblWrngChar.Visibility = System.Windows.Visibility.Hidden;

            if(e.Key == Key.Enter)
                 btnGetVal_Click(sender, new RoutedEventArgs());
        }

        private void getAscii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
